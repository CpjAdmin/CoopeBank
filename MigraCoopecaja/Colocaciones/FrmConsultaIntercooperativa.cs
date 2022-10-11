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
                * Se reutilizan métodos del proyecto APIs Crédito Consulta Intercooperativas, y se crea una pantalla para 
                * consumir las APIs. La consulta se hará por medio del parámetro de identificación del asociado a consultar.
                * Se mostrarán los datos de la consulta (identificación, nombre, estado y la entidad del asociado).
                * 
                * 
                * */

namespace AppEscritorio.Colocaciones
{
    public partial class FrmConsultaIntercooperativa : Form
    {
        public FrmConsultaIntercooperativa()
        {
            InitializeComponent();
        }

        private async void llamar_api_mep(string cedula)
        {
            string url = "http://172.28.41.219:8080/";
            var client2 = new HttpClient();
            var form2 = new Dictionary<string,
                string> {
                    {
                        "identificacion",
                        cedula
                    },
                };


            string id = Newtonsoft.Json.JsonConvert.SerializeObject(form2);
            var httpContent = new StringContent(id, Encoding.UTF8, "application/json");
            client2.DefaultRequestHeaders.Accept.Clear();
            var authorizedResponse = client2.PostAsync(url + "api/consultaCoopemep", httpContent).Result;
            var result2 = await authorizedResponse.Content.ReadAsStringAsync();
            var respuesta = JsonConvert.DeserializeObject<Respuesta_1>(result2);


            CheckForIllegalCrossThreadCalls = false;

            DataTable dt = new DataTable();

            dt.Columns.Add("Identificación", typeof(string));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Posee Créditos", typeof(string));
            dt.Columns.Add("Entidad", typeof(string));

            dataGridView1.Columns["Identificación"].Visible = false;
            dataGridView1.Columns["Nombre"].Visible = false;
            dataGridView1.Columns["Estado"].Visible = false;
            dataGridView1.Columns["Entidad"].Visible = false;

            if (respuesta != null)
            {
                if (respuesta.entidad == "822")
                {
                    respuesta.entidad = "COOPEMEP";
                }

                if (respuesta.estado == "S")
                {
                    respuesta.estado = "SI POSEE";
                }

                if (respuesta.estado == "N")
                {
                    respuesta.estado = "NO POSEE";
                }

                dt.Rows.Add(respuesta.identificacion, respuesta.nombre, respuesta.estado, respuesta.entidad);
                this.dataGridView1.DataSource = dt;
                
            }

            else if (respuesta == null)
            {

                if (txtCedula.Text == "")
                {
                    lblCedula.Visible = true;
                    lblCedula.Text = "Favor ingresa un número de cédula";

                }
                else
                {
                    lblCedula.Visible = false;
                    string respuesta2 = "No se encontraron gestiones en Coopemep";
                    
                    dt.Rows.Add(respuesta2);
                    this.dataGridView1.DataSource = dt;
                    dataGridView1.AutoResizeColumns();
                }

            }

        }

        private async void llamar_api_ande(string usuario_ande, string pass_ande, string cedula)
        {
            string url = "https://online.coope-ande.co.cr/ords/api/";
            var client1 = new HttpClient();
            var client2 = new HttpClient();

            var form = new Dictionary<string,
                string> {
                    {
                        "usuario",
                        usuario_ande
                    },
                    {
                        "password",
                        pass_ande
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
            var tokenResponse = client1.PostAsync(url + "token/v1/token/solicitar", httpContentCredentials).Result;

            string id = Newtonsoft.Json.JsonConvert.SerializeObject(form2);
            var httpContent = new StringContent(id, Encoding.UTF8, "application/json");

            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {
                var result = await tokenResponse.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<Token_2>(result);

                client2.DefaultRequestHeaders.Accept.Clear();
                client2.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.token);

                var authorizedResponse = client2.PostAsync(url + "creditos/v1/gestion/consultar", httpContent).Result;
                var result2 = await authorizedResponse.Content.ReadAsStringAsync();
                var respuesta = JsonConvert.DeserializeObject<Respuesta_2>(result2);

               
                CheckForIllegalCrossThreadCalls = false;
                
                DataTable dt2 = new DataTable();
               
                dt2.Columns.Add("Identificación", typeof(string));
                dt2.Columns.Add("Nombre", typeof(string));
                dt2.Columns.Add("Posee Créditos", typeof(string));
                dt2.Columns.Add("Entidad", typeof(string));

                dg2.Columns["Identificacion2"].Visible = false;
                dg2.Columns["Nombre2"].Visible = false;
                dg2.Columns["Estado2"].Visible = false;
                dg2.Columns["Entidad2"].Visible = false;


                if (respuesta != null)
                {
                    if (respuesta.entidad == "817")
                    {
                        respuesta.entidad = "COOPEANDE";
                    }

                    if (respuesta.estado == "S")
                    {
                        respuesta.estado = "SI POSEE";
                    }

                    if (respuesta.estado == "N")
                    {
                        respuesta.estado = "NO POSEE";
                    }

                    dt2.Rows.Add(respuesta.identificacion, respuesta.nombre, respuesta.estado, respuesta.entidad);
                    this.dg2.DataSource = dt2;
                    
                }

                else if (respuesta == null)
                {

                    if (txtCedula.Text == "")
                    {
                        lblCedula.Visible = true;
                        lblCedula.Text = "Favor ingresa un número de cédula";

                    }
                    else
                    {
                        lblCedula.Visible = false;
                        string respuesta2 = "No se encontraron gestiones en Coopeande";
                        
                        dt2.Rows.Add(respuesta2);
                        this.dg2.DataSource = dt2;
                        dg2.AutoResizeColumns();
                    }
                   
                }

            }

          

        }
        
        public class Token_1
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

        public class Token_2
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

        public class Respuesta_1
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

        public class Respuesta_2
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
            Thread t_ande;
            Thread t_mep;

            string usuario_ande = "06oGS61seiabPHr7lspNNQ..";
            string pass_ande = "cNYLXKg4E1_beUlD8aDePw..";
            string cedula = txtCedula.Text;

          
            t_ande = new Thread(() => llamar_api_ande(usuario_ande, pass_ande, cedula));
            t_mep = new Thread(() => llamar_api_mep(cedula));
            t_ande.Start();
            t_mep.Start();

        }

        private void FrmConsultaIntercooperativa_Load(object sender, EventArgs e)
        {

        }

     
    }    
}