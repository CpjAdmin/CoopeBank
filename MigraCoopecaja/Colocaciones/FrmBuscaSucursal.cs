using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmBuscaSucursal : Form
    {
        string connectionStringO = "";
        List<estructuras.sucursales> listaSucursal;

        public FrmBuscaSucursal(string ConnectionString)
        {
            InitializeComponent();
            connectionStringO = ConnectionString;
            listaSucursal = ListaSucursales( "", "");
            dtgSucursales.DataSource = listaSucursal;
        }



        private void FrmBuscaSucursal_Load(object sender, EventArgs e)
        {

        }

        private List<estructuras.sucursales> ListaSucursales(string cod_sucursal, string nom_sucursal)
        {
            List<estructuras.sucursales> listaS = new List<estructuras.sucursales>();
            estructuras.sucursales sucursal = null;
            string sentencia = "SELECT COD_UBICACION,DES_UBICACION FROM GENERAL.GL_UBICACIONES WHERE 1 = 1";

            if (cod_sucursal.Trim() != "")
            {
                sentencia = sentencia + " AND COD_UBICACION LIKE '" + cod_sucursal.Trim() + "'"; ;
            }
            if (nom_sucursal.Trim() != "")
            {
                sentencia = sentencia + " AND DES_UBICACION LIKE '" + nom_sucursal.ToUpper().Trim() + "'";
            }
            sentencia = sentencia + " ORDER BY COD_UBICACION";

            try
            {
                using (OracleConnection connORA = new OracleConnection(connectionStringO))
                {
                    connORA.Open();
                    OracleCommand Query = new OracleCommand(sentencia, connORA);
                    Query.CommandType = CommandType.Text;
                    Query.CommandTimeout = 10000;

                    OracleDataReader SqlDR = Query.ExecuteReader();

                    if (SqlDR.HasRows)
                    {
                        while (SqlDR.Read())
                        {
                            sucursal = new estructuras.sucursales();
                            sucursal.cod_sucursal = (String)SqlDR["COD_UBICACION"];
                            sucursal.nom_sucursal = (String)SqlDR["DES_UBICACION"];
                            listaS.Add(sucursal);
                        }

                    }
                    else
                    {


                    }
                    SqlDR.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SUCURSALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaS;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
            this.txtNombre.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaSucursal = ListaSucursales(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
            dtgSucursales.DataSource = listaSucursal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Colocaciones.FrmCambVend.Cod_sucursal = "";
            Colocaciones.FrmCambVend.Nom_Sucursal = "";
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Colocaciones.FrmCambVend.Cod_sucursal = listaSucursal[dtgSucursales.CurrentCell.RowIndex].cod_sucursal;
                Colocaciones.FrmCambVend.Nom_Sucursal = listaSucursal[dtgSucursales.CurrentCell.RowIndex].nom_sucursal;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se seleccionó ningún vendedor", "SUCURSAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
