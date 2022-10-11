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
using Datos;


namespace AppEscritorio.Colocaciones
{
    public partial class FrmCambVend : Form
    {

        String Cod_compania = "";
        String numSolicitud = "";
        public static int Cod_vendedor = 0;
        public static string Cod_sucursal = "";
        public static string Nombre_Vendedor = "";
        public static string Nom_Sucursal = "";
        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;

        public FrmCambVend()
        {
            InitializeComponent();
        }
       

        private void validaOperacion(string NUMERO)
        {
            this.btnGuardar.Enabled = false;
            string comando;


            try
            {
                if (NUMERO.Trim() == "")
                {
                    Cod_compania = "";
                    this.txtCodCliente.Text = "";
                    this.txtNumero.Text = "";
                    this.txtNomCliente.Text = "";
                    this.txtCodAsesor.Text = "";
                    this.txtNomAsesor.Text = "";
                    this.txtCodAsesorN.Text = "";
                    this.txtNomAsesorN.Text = "";
                    this.txtSucursal.Text = "";
                    this.txtNomSucursal.Text = "";
                    this.txtSucursalN.Text = "";
                    this.txtNomSucursalN.Text = "";
                    numSolicitud = "";
                    Cod_vendedor = 0;
                    Cod_sucursal = "";
                    Nombre_Vendedor = "";
                    Nom_Sucursal = "";
                    return;
                }


                if (rdbSoli.Checked)
                {
                    comando = "SELECT A.COD_COMPANIA,A.NUM_SOLICITUD,A.COD_CLIENTE, C.NOM_CLIENTE,A.COD_VENDEDOR, B.NOMBRE_VENDEDOR,E.COD_UBICACION,E.DES_UBICACION FROM CREDITO.CR_SOLICITUDES  A" +
                                                            " LEFT JOIN FVENTAS.FV_VENDEDORES B ON A.COD_VENDEDOR = B.COD_VENDEDOR AND A.COD_COMPANIA = B.COD_COMPANIA " +
                                                            " JOIN CLIENTES.CL_CLIENTES C ON A.COD_CLIENTE = C.COD_CLIENTE " +
                                                            " JOIN CREDITO.CR_OPERACIONES D ON A.NUM_SOLICITUD  = D.NUM_SOLICITUD " +
                                                            " JOIN GENERAL.GL_UBICACIONES E ON D.COD_UBICACION = E.COD_UBICACION " +
                                                            " where A.NUM_SOLICITUD = :1";
                }
                else
                {
                    comando = "SELECT A.COD_COMPANIA,A.NUM_SOLICITUD,A.COD_CLIENTE, C.NOM_CLIENTE,A.COD_VENDEDOR, B.NOMBRE_VENDEDOR,E.COD_UBICACION,E.DES_UBICACION FROM CREDITO.CR_SOLICITUDES  A" +
                                                           " LEFT JOIN FVENTAS.FV_VENDEDORES B ON A.COD_VENDEDOR = B.COD_VENDEDOR AND A.COD_COMPANIA = B.COD_COMPANIA " +
                                                           " JOIN CLIENTES.CL_CLIENTES C ON A.COD_CLIENTE = C.COD_CLIENTE " +
                                                           " JOIN CREDITO.CR_OPERACIONES D ON A.NUM_SOLICITUD  = D.NUM_SOLICITUD " +
                                                           " JOIN GENERAL.GL_UBICACIONES E ON D.COD_UBICACION = E.COD_UBICACION " +
                                                           " where D.NUM_OPERACION = :1";
                }


                using (OracleConnection connORA = new OracleConnection(cadenaConnOracle))
                {
                    connORA.Open();
                    OracleCommand Query = new OracleCommand(comando, connORA);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("NUMERO", NUMERO));
                    Query.CommandTimeout = 10000;

                    OracleDataReader SqlDR = Query.ExecuteReader();

                    if (SqlDR.HasRows)
                    {
                        while (SqlDR.Read())
                        {
                            Cod_compania = (String)SqlDR["COD_COMPANIA"].ToString();
                            numSolicitud = (String)SqlDR["NUM_SOLICITUD"].ToString();
                            Cod_vendedor = int.Parse( SqlDR["COD_VENDEDOR"].ToString()) ;
                            Cod_sucursal = (String)SqlDR["COD_UBICACION"].ToString(); ;
                            Nombre_Vendedor = (String)SqlDR["NOMBRE_VENDEDOR"].ToString();
                            Nom_Sucursal = (String)SqlDR["DES_UBICACION"].ToString();
                            this.txtCodCliente.Text = (String)SqlDR["COD_CLIENTE"].ToString();
                            this.txtNomCliente.Text = (String)SqlDR["NOM_CLIENTE"].ToString();
                            this.txtCodAsesor.Text = (String)SqlDR["COD_VENDEDOR"].ToString();
                            this.txtNomAsesor.Text = (String)SqlDR["NOMBRE_VENDEDOR"].ToString();
                            this.txtCodAsesorN.Text = (String)SqlDR["COD_VENDEDOR"].ToString(); 
                            this.txtNomAsesorN.Text = (String)SqlDR["NOMBRE_VENDEDOR"].ToString();
                            this.txtSucursal.Text = (String)SqlDR["COD_UBICACION"].ToString();
                            this.txtNomSucursal.Text = (String)SqlDR["DES_UBICACION"].ToString();
                            this.txtSucursalN.Text = (String)SqlDR["COD_UBICACION"].ToString();
                            this.txtNomSucursalN.Text = (String)SqlDR["DES_UBICACION"].ToString();
                        }

                        

                    }
                    else
                    {
                        MessageBox.Show("No se encontró la solicitud u operación digitada","CREDITOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cod_compania = "";
                        this.txtCodCliente.Text = "";
                        this.txtNumero.Text = "";
                        this.txtNomCliente.Text = "";
                        this.txtCodAsesor.Text = "";
                        this.txtNomAsesor.Text = "";
                        this.txtCodAsesorN.Text = "";
                        this.txtNomAsesorN.Text = "";
                        this.txtSucursal.Text = "";
                        this.txtNomSucursal.Text = "";
                        this.txtSucursalN.Text = "";
                        this.txtNomSucursalN.Text = "";
                        numSolicitud = "";
                        Cod_vendedor = 0;
                        Cod_sucursal = "";
                        Nombre_Vendedor = "";
                        Nom_Sucursal = "";
                    }
                    SqlDR.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SOLICITUDES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private int guardarDatos(string numero, int idVendedor, string cod_sucursal)
        {
            int resultado = 0;
            try
            {
                using (OracleConnection connORA = new OracleConnection(cadenaConnOracle))
                {
                    connORA.Open();
                    OracleCommand Query = new OracleCommand("UPDATE CREDITO.CR_SOLICITUDES SET COD_VENDEDOR = :1, COD_UBICACION = :2  where NUM_SOLICITUD = :3", connORA);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("COD_VENDEDOR", idVendedor));
                    Query.Parameters.Add(new OracleParameter("COD_UBICACION", cod_sucursal));
                    Query.Parameters.Add(new OracleParameter("NUM_SOLICITUD", numero));
                    Query.CommandTimeout = 10000;
                    int SqlR = Query.ExecuteNonQuery();
                    resultado = SqlR;


                    Query.CommandText = "UPDATE CREDITO.CR_OPERACIONES SET COD_UBICACION = :1  where NUM_SOLICITUD = :2";
                    Query.Parameters.Clear();
                    Query.Parameters.Add(new OracleParameter("COD_UBICACION", cod_sucursal));
                    Query.Parameters.Add(new OracleParameter("NUM_SOLICITUD", numero));
                    SqlR = Query.ExecuteNonQuery();

                    Query.CommandText = "commit";
                    SqlR = Query.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Guardar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado;

        }


        private void txtSolicitud_Validating(object sender, CancelEventArgs e)
        {
            string numero  = this.txtNumero.Text.Trim();
            validaOperacion(numero);
        }

        private void btnAsesor_Click(object sender, EventArgs e)
        {
            Cod_vendedor = 0;
            Nombre_Vendedor = "";
            if (Cod_compania.Trim() == "") { return; };
            Colocaciones.FrmBuscaVendedor gestion = new Colocaciones.FrmBuscaVendedor(Cod_compania, cadenaConnOracle);
            gestion.ShowDialog();
            if (Cod_vendedor == 0) 
            {
                this.txtCodAsesorN.Text = "";
                this.txtNomAsesorN.Text = "";
                this.btnGuardar.Enabled = false;
            }
            else
            {
                this.txtCodAsesorN.Text = Cod_vendedor.ToString();
                this.txtNomAsesorN.Text = Nombre_Vendedor.ToString();
                this.btnGuardar.Enabled = true;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Desea actualizar los datos del crédito??",
                                     "Confirmar Cambio",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.No)
            {
                return;
            }

            int resultado = guardarDatos(numSolicitud, Cod_vendedor,Cod_sucursal);
            if (resultado <= 0)
            {
                MessageBox.Show("Error al actualizar los datos", "Actualizar crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Datos actuliazados correctamente", "Actualizar vendedor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Cod_compania = "";
                this.txtCodCliente.Text = "";
                this.txtNumero.Text = "";
                this.txtNomCliente.Text = "";
                this.txtCodAsesor.Text = "";
                this.txtNomAsesor.Text = "";
                this.txtCodAsesorN.Text = "";
                this.txtNomAsesorN.Text = "";
                this.txtNomSucursal.Text = "";
                this.txtSucursal.Text = "";
                this.txtNomSucursalN.Text = "";
                this.txtSucursalN.Text = "";

                Cod_vendedor = 0;
                Nombre_Vendedor = "";

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
               
        }

        private void FrmCambVend_Load(object sender, EventArgs e)
        {

        }

        private void txtSolicitud_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSucursal_Click(object sender, EventArgs e)
        {
            Cod_sucursal = "";
            Nombre_Vendedor = "";
            Colocaciones.FrmBuscaSucursal gestionS = new Colocaciones.FrmBuscaSucursal(cadenaConnOracle);
            gestionS.ShowDialog();
            if (Cod_sucursal == "")
            {
                this.txtSucursalN.Text = "";
                this.txtNomSucursalN.Text = "";
                this.btnGuardar.Enabled = false;
            }
            else
            {
                this.txtSucursalN.Text = Cod_sucursal.ToString();
                this.txtNomSucursalN.Text = Nom_Sucursal.ToString();
                this.btnGuardar.Enabled = true;
            }
        }
    }
}
