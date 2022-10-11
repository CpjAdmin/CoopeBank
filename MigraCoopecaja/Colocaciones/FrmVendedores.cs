using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos.EntidadesAux;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Security.Cryptography;
using System.IO;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmVendedores : Form
    {
        CapaLogica objLogica;

        public static int Cod_vendedor = 0;
        public static string Des_nombre = "";
        public static string Cod_Usuario = "";
        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;

        public FrmVendedores()
        {
            InitializeComponent();
        }

        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        void PROC_INSERTARVENDEDOR()
        {
            try
            {
                objLogica = new CapaLogica();
                ResVendedor respuesta;

                respuesta = objLogica.PROC_INSERTAVENDEDOR(this.txtUsuario.Text.Trim());
                if (respuesta.cod_error != 1)
                {
                    MessageBox.Show("Vendedor creado correctamente. Codigo: " + respuesta.cod_vendedor.ToString(), "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtCodigo.Text = respuesta.cod_vendedor.ToString();
                    this.BtnNuevo.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se logro crear el vendedor " + respuesta.des_error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro crear el vendedor. " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarControles()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtNomUsuario.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                result = MessageBox.Show(null, "Desea crear el vendedor ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    PROC_INSERTARVENDEDOR();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar vendedor. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAsesor_Click(object sender, EventArgs e)
        {
            Cod_vendedor = 0;
            Des_nombre = "";
            Cod_Usuario = "";
          
            Colocaciones.FrmBuscarVendedor2 gestion = new Colocaciones.FrmBuscarVendedor2(cadenaConnOracle);
            gestion.ShowDialog();
            if (Cod_Usuario == "")
            {
                LimpiarControles();
            }
            else
            {
                this.txtCodigo.Text = Cod_vendedor.ToString();
                this.txtNomUsuario.Text = Des_nombre;
                this.txtUsuario.Text = Cod_Usuario;
                this.BtnNuevo.Enabled = false;
                if(Cod_vendedor == 0)
                    this.BtnNuevo.Enabled = true;
            }

        }

    }
}
