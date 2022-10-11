using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;


/*Mantenimiento de categorías comerciales
 * Por Diego Arguedas Rojas Abril-2022
 * R-015304
 * 
 * Mantenimientos de la tablas CL_CAT_COMERCIAL &&& CL_PRODUCTOS_CAT_COMERCIAL
 * 
 * 
 */
namespace AppEscritorio.Captacion
{
    public partial class FrmCategoriaComercial : Form
    {
        public FrmCategoriaComercial()
        {
            InitializeComponent();
        }

        private void FrmCategoriaComercial_Load(object sender, EventArgs e)
        { 
            consultarCategoria();
            this.lblModulo.Visible = false;
            this.lblTipo.Visible = false;
            this.lblMontoI.Visible = false;
            this.lblMontoF.Visible = false;
        }

        private void limpiarCampos()
        {
            this.cmbModulo.Text = "";
            this.cmbTipoCliente.Text = "";
            this.txtMontoIni.Text = "";
            this.txtMontoFin.Text = "";
            this.txtCategoria.Text = "";
            this.txtMensaje.Text = "";
        }
        private void consultarCategoria()
        {
            string modulo = "";
            string tipocliente = "";
            string monto_inicial = "";
            string monto_final = ""; 
            string categoria = "";
            string alerta = "";
            string comando = "SELECT COD_MODULO, TIPOPERSONA, MONTOI,  MONTOF, CATEGORIA, MENSAJE FROM CL_CAT_COMERCIAL " +
                "ORDER BY COD_MODULO, TIPOPERSONA, MONTOI, MONTOF ASC";

            try
            {
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {
                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            modulo = (String)sqlDR["COD_MODULO"].ToString();
                            tipocliente = (String)sqlDR["TIPOPERSONA"].ToString();
                            monto_inicial = (String)sqlDR["MONTOI"].ToString();
                            monto_final = (String)sqlDR["MONTOF"].ToString();
                            categoria = (String)sqlDR["CATEGORIA"].ToString();
                            alerta = (String)sqlDR["MENSAJE"].ToString();
                           
                            int n = dgCategoria.Rows.Add();

                            dgCategoria.Rows[n].Cells[0].Value = modulo;
                            dgCategoria.Rows[n].Cells[1].Value = tipocliente;
                            dgCategoria.Rows[n].Cells[2].Value = monto_inicial;
                            dgCategoria.Rows[n].Cells[3].Value = monto_final;
                            dgCategoria.Rows[n].Cells[4].Value = categoria;
                            dgCategoria.Rows[n].Cells[5].Value = alerta;
                           
                        }
                    }
                    sqlDR.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgCategoria.Rows.Clear();
            consultarCategoria();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnCargaAhorros_Click(object sender, EventArgs e)
        {
            Captacion.FrmCategoriaAhorros ObjCategoriaAhorros = new FrmCategoriaAhorros();
            ObjCategoriaAhorros.ShowDialog();
        }
        /// <summary>
        ///DIEGO
        /// /INSERTAR REGISTROS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string modulo = this.cmbModulo.SelectedIndex.ToString();
            int tipoCliente = Int32.Parse(this.cmbTipoCliente.SelectedIndex.ToString());
            string montoi = this.txtMontoIni.Text;
            string montof = this.txtMontoFin.Text;
            string categoria = this.txtCategoria.Text;
            string mensaje = this.txtMensaje.Text;
            string valor_cod = "";
            int valor_tC = 0;

            if (this.cmbModulo.SelectedItem == null || this.cmbTipoCliente.SelectedItem == null ||
                montoi == "" || montof == "" || this.txtCategoria.Text == "")
            {
                MessageBox.Show("Ha dejado campos vacíos!", "Favor ingrese todos los valores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if ((montoi) == "0.00" || (montof) == "0.00")
            {
                MessageBox.Show("El monto inicial y final no puede ser cero!", "Ingrese otro valor para el rango", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else {

                if (modulo == "0")
                {
                    valor_cod = "IN";
                } 
                
                if (modulo == "1")
                {
                    valor_cod = "CP";
                }

                if (tipoCliente == 0)
                {
                    valor_tC = 1;
                }

                if (tipoCliente == 1)
                {
                    valor_tC = 2;
                }

                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("DB_UTILIDADES.PKG_COOPEBANK.INSERTARCATEGORIA", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pCOD_MODULO", OracleDbType.Varchar2).Value = valor_cod;
                        comando.Parameters.Add("pTIPOPERSONA", OracleDbType.Int32).Value = valor_tC;
                        comando.Parameters.Add("pMONTOI", OracleDbType.Decimal).Value = Double.Parse(montoi);
                        comando.Parameters.Add("pMONTOF", OracleDbType.Decimal).Value = Double.Parse(montof);
                        comando.Parameters.Add("pCATEGORIA", OracleDbType.Varchar2).Value = categoria;
                        comando.Parameters.Add("pMENSAJE", OracleDbType.Varchar2).Value = mensaje;
                        
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Se han ingresado los datos correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connOra.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se han ingresado los datos correctamente", "Datos No Guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    throw ex;
                }
            }  
        }
 

        /// <summary>
        ///DIEGO
        /// /ELIMINAR REGISTROS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.lblModulo.Text = (string)dgCategoria.Rows[n].Cells[0].Value;
                this.lblTipo.Text = (string)dgCategoria.Rows[n].Cells[1].Value;
                this.lblMontoI.Text = (string)dgCategoria.Rows[n].Cells[2].Value;
                this.lblMontoF.Text = (string)dgCategoria.Rows[n].Cells[3].Value;
            }
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {

                if (this.lblModulo.Text == "" || this.lblTipo.Text == "" || this.lblMontoI.Text == "" || this.lblMontoF.Text == "")
                {
                    MessageBox.Show("No se seleccionó valor en el grid correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    DialogResult resultado = MessageBox.Show("Desea eliminar el registro de la siguiente operación: \n\n"
                        + "Módulo: " + this.lblModulo.Text + "\n"
                        + "Tipo Cliente: " + this.lblTipo.Text + "\n"
                        + "Monto Inicial: " + this.lblMontoI.Text + "\n"
                        + "Monto Final: " + this.lblMontoF.Text,
                        "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                            {
                                connOra.Open();
                                OracleCommand comando = new OracleCommand("DB_UTILIDADES.PKG_COOPEBANK.ELIMINARCATEGORIA", connOra);
                                comando.CommandType = System.Data.CommandType.StoredProcedure;
                                comando.Parameters.Add("pCOD_MODULO", OracleDbType.Varchar2).Value = this.lblModulo.Text;
                                comando.Parameters.Add("pTIPOPERSONA", OracleDbType.Int32).Value = this.lblTipo.Text;
                                comando.Parameters.Add("pMONTOI", OracleDbType.Decimal).Value = this.lblMontoI.Text;
                                comando.Parameters.Add("pMONTOF", OracleDbType.Decimal).Value = this.lblMontoF.Text;
                                comando.ExecuteNonQuery();

                                MessageBox.Show("Se ha eliminado el registro de la operación: \n\n"
                                    + "Módulo: " + this.lblModulo.Text + "\n"
                                    + "Tipo Cliente: " + this.lblTipo.Text + "\n"
                                    + "Monto Inicial: " + this.lblMontoI.Text + "\n"
                                    + "Monto Final: " + this.lblMontoF.Text, 
                                    "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("No se eliminó el registro seleccionado)" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (resultado == DialogResult.No)

                    {
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// /FORMATO DE MONEDA PARA TEXTBOX
        /// DIEGO ARGUEDAS ROJAS - ABRIL/2022
        /// </summary>
        /// <param name="xTBox"></param>
        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");
            }
        }

        private void txtMontoIni_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtMontoIni);
        }

        private void txtMontoFin_Leave(object sender, EventArgs e)
        {
            FormatoMoneda(txtMontoFin);
        }

        /// <summary>
        /// //DAR FORMATO MONEDA A CELDAS DEL GRID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgCategoria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != this.dgCategoria.NewRowIndex)
            {
                if (dgCategoria.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }

            if (e.ColumnIndex == 3 && e.RowIndex != this.dgCategoria.NewRowIndex)
            {
                if (dgCategoria.Rows[e.RowIndex].Cells[3].Value != null)
                {
                    double val2 = double.Parse(e.Value.ToString());
                    e.Value = val2.ToString("N2");
                }
            }
        }

        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;
        private int n = 0;

    }
}