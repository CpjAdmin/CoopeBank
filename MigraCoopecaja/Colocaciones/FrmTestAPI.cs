using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

                /**
                * 
                * Pantalla de consulta de crédito de asociados a la cooperativa - R-012007 - Proyecto Intercooperativas Septiembre 2021 - Por Diego Arguedas Rojas
                * Se reutilizan métodos del proyecto APIs Crédito Consulta Intercooperativas, y se crea una pantalla que pedirá las credenciales para 
                * consumir la API publicada, la consulta se hará por medio del parámetro de identificación del asociado a consultar.
                * Se mostrarán los datos de la consulta (identificación, nombre, estado y la entidad del asociado), por medio de un grid.
                * 
                * 
                * */

namespace AppEscritorio.Colocaciones
{
    public partial class FrmTestAPI : Form
    {
        public FrmTestAPI()
        {
            InitializeComponent();
        }
       
        

        private async void llamar_api(string usuario, string pass, string cedula)
        {
            string url = "http://172.28.50.42:8080";
            var client1 = new HttpClient();
            var client2 = new HttpClient();

            var form = new Dictionary<string,
                string> {
                    {
                        "usuario",
                        usuario
                    },
                    {
                        "password",
                        pass
                    },
                };
            var form2 = new Dictionary<string,
                string> {
                    {
                        "identificacion",
                        cedula
                    },
                };

            var httpContentCredentials = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(form), Encoding.UTF8, "application/json");
            var tokenResponse = client1.PostAsync(url + "/api/token", httpContentCredentials).Result;

            string id = Newtonsoft.Json.JsonConvert.SerializeObject(form2);
            var httpContent = new StringContent(id, Encoding.UTF8, "application/json");

            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {
                var result = await tokenResponse.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<Token>(result);

                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.token);

                var authorizedResponse = client2.PostAsync(url + "/api/credito", httpContent).Result;

                if (authorizedResponse.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show("No ha digitado correctamente la cédula del asociado, o este no se encuentra registrado!", "Favor validar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var result2 = await authorizedResponse.Content.ReadAsStringAsync();
                var respuesta = JsonConvert.DeserializeObject<Respuesta>(result2);

               
                CheckForIllegalCrossThreadCalls = false;
                
                DataTable dt = new DataTable();
               
                dt.Columns.Add("Identificación", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Estado", typeof(string));
                dt.Columns.Add("Entidad", typeof(string));
                
                dataGridView1.Columns["Identificación"].Visible = false;
                dataGridView1.Columns["Nombre"].Visible = false;
                dataGridView1.Columns["Estado"].Visible = false;
                dataGridView1.Columns["Entidad"].Visible = false;

                dt.Rows.Add(respuesta.identificacion, respuesta.nombre, respuesta.estado, respuesta.entidad);
                this.dataGridView1.DataSource = dt;
                this.txtCedula.Text = "";

            }

            else {

                if (txtCedula.Text == "") {

                    MessageBox.Show("No ha ingresado un número de cédula", "Favor validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    

                } else if (txtUsuario.Text == "" || txtPassword.Text == "") {

                    MessageBox.Show("No ha completado los campos de usuario o contraseña", "Favor validar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                } else {

                    MessageBox.Show("No ha colocado credenciales válidas", "Favor validar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }
        
        public class Token
        {
            [JsonProperty("token")]
            public string token
            {
                get;
                set;
            }
            [JsonProperty("expires")]
            public int expira
            {
                get;
                set;
            }
        }

        public class Respuesta
        {
            [JsonProperty("identificacion")]
            public string identificacion
            {
                get;
                set;
            }
            [JsonProperty("nombre")]
            public string nombre
            {
                get;
                set;
            }
            [JsonProperty("estado")]
            public string estado
            {
                get;
                set;
            }
            [JsonProperty("entidad")]
            public string entidad
            {
                get;
                set;
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Thread t;

            string usuario = txtUsuario.Text;
            string pass = txtPassword.Text;
            string cedula = txtCedula.Text;

            t = new Thread(() => llamar_api(usuario, pass, cedula));
            t.Start();

        }

    }    
}
