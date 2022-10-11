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

namespace AppEscritorio.Sugef
{
    public partial class FrmActividadEconomica : Form
    {
        public FrmActividadEconomica()
        {
            InitializeComponent();
        }

        /**
              * 
              * Pantalla de asignación de actividad económica a transacciones superiores a $10 000
              * - R-017284 - Requerimiento XML SUGEF - Por Diego Arguedas Rojas
              * 
                    Modificación de la estructura del xml clase de datos 6 a clase de datos 50 -Legitimación de Capitales.
              * 
              * 
         * */

        private void seleccionaTransaccion()
        {
            string cod_persona = "";
            string des_identificacion = "";
            string tip_operacion = "";
            string fec_transaccion = "";
            string tip_transaccion = "";
            string nom_persona = "";
            string pri_apellido = "";
            string seg_apellido = ""; 
            string nom_razon_social = "";
            string mon_ingreso = "0.00";
            string cod_moneda_ingreso = "";
            string mon_engreso = "";
            string cod_moneda_egreso = "";
            string det_transaccion = "";
            string det_origen = "";
            
            string comando = "SELECT COD_PERSONA, DES_IDENTIFICACION, TIP_OPERACION, FEC_TRANSACCION, TIP_TRANSACCION, NOM_PERSONA, PRI_APELLIDO, SEG_APELLIDO, " +
                "NOM_RAZON_SOCIAL, MON_INGRESO, COD_MONEDA_INGRESO, MON_EGRESO, COD_MONEDA_EGRESO, DET_TRANSACCION, DET_ORIGEN " +
                "FROM MERCADO.LV_EFECTIVO_MAYOR_MONTO_TEMP ORDER BY FEC_TRANSACCION DESC";

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
                            cod_persona = (String)sqlDR["COD_PERSONA"].ToString();
                            des_identificacion = (String)sqlDR["DES_IDENTIFICACION"].ToString();
                            tip_operacion = (String)sqlDR["TIP_OPERACION"].ToString();
                            fec_transaccion = (String)sqlDR["FEC_TRANSACCION"].ToString();
                            string fecha = fec_transaccion;
                            String fecha_sin_hora = fecha.Substring(0, 10);
                            tip_transaccion = (String)sqlDR["TIP_TRANSACCION"].ToString();
                            nom_persona = (String)sqlDR["NOM_PERSONA"].ToString();
                            pri_apellido = (String)sqlDR["PRI_APELLIDO"].ToString();
                            seg_apellido = (String)sqlDR["SEG_APELLIDO"].ToString();
                            nom_razon_social = (String)sqlDR["NOM_RAZON_SOCIAL"].ToString();
                            mon_ingreso = (String)sqlDR["MON_INGRESO"].ToString();
                            cod_moneda_ingreso = (String)sqlDR["COD_MONEDA_INGRESO"].ToString();
                            mon_engreso = (String)sqlDR["MON_EGRESO"].ToString();
                            cod_moneda_egreso = (String)sqlDR["COD_MONEDA_EGRESO"].ToString();
                            det_transaccion = (String)sqlDR["DET_TRANSACCION"].ToString();
                            det_origen = (String)sqlDR["DET_ORIGEN"].ToString();

                            int n = dgTransacciones.Rows.Add();

                            dgTransacciones.Rows[n].Cells[0].Value = cod_persona;
                            dgTransacciones.Rows[n].Cells[1].Value = des_identificacion;
                            dgTransacciones.Rows[n].Cells[2].Value = tip_operacion;
                            dgTransacciones.Rows[n].Cells[3].Value = fecha_sin_hora;
                            dgTransacciones.Rows[n].Cells[4].Value = tip_transaccion;
                            dgTransacciones.Rows[n].Cells[5].Value = nom_persona;
                            dgTransacciones.Rows[n].Cells[6].Value = pri_apellido;
                            dgTransacciones.Rows[n].Cells[7].Value = seg_apellido;
                            dgTransacciones.Rows[n].Cells[8].Value = nom_razon_social;
                            dgTransacciones.Rows[n].Cells[9].Value = mon_ingreso;
                            dgTransacciones.Rows[n].Cells[10].Value = cod_moneda_ingreso;
                            dgTransacciones.Rows[n].Cells[11].Value = mon_engreso;
                            dgTransacciones.Rows[n].Cells[12].Value = cod_moneda_egreso;
                            dgTransacciones.Rows[n].Cells[13].Value = det_transaccion;
                            dgTransacciones.Rows[n].Cells[14].Value = det_origen;

                        }
                        dgTransacciones.AutoResizeColumns();
                    }
                    sqlDR.Close();
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;
        private int n = 0;

        private void FrmActividadEconomica_Load(object sender, EventArgs e)
        {
            seleccionaTransaccion();
            this.txtCodigoPersona.Enabled = false;
            this.txtIdentificacion.Enabled = false;
            this.txtTipoOperacion.Enabled = false;
            this.txtFecha.Enabled = false;
            this.txtTipoTransaccion.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtPrimerApellido.Enabled = false;
            this.txtSegundoApellido.Enabled = false;
            this.txtRazonSocial.Enabled = false;
            this.txtMontoIngreso.Enabled = false;
            this.txtCodigoIngreso.Enabled = false;
            this.txtMontoEgreso.Enabled = false;
            this.txtCodigoEgreso.Enabled = false;
            this.txtDetalleTransaccion.Enabled = false;
            this.txtDetalleOrigen.Enabled = false;
            this.txtCodigo.Enabled = false;
            this.txtActividad.Enabled = false;
        }

        private void dgTransacciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.RowIndex != this.dgTransacciones.NewRowIndex)
            {
                if (dgTransacciones.Rows[e.RowIndex].Cells[9].Value != null)
                {
                    double val1 = double.Parse(e.Value.ToString());
                    e.Value = val1.ToString("N2");
                }
            }

            if (e.ColumnIndex == 11 && e.RowIndex != this.dgTransacciones.NewRowIndex)
            {
                if (dgTransacciones.Rows[e.RowIndex].Cells[11].Value != null)
                {
                    double val2 = double.Parse(e.Value.ToString());
                    e.Value = val2.ToString("N2");
                }
            }
        }

        private void dgTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.txtCodigoPersona.Text = (string)dgTransacciones.Rows[n].Cells[0].Value;
                this.txtIdentificacion.Text = (string)dgTransacciones.Rows[n].Cells[1].Value;
                this.txtTipoOperacion.Text = (string)dgTransacciones.Rows[n].Cells[2].Value;
                this.txtFecha.Text = (string)dgTransacciones.Rows[n].Cells[3].Value;
                this.txtTipoTransaccion.Text = (string)dgTransacciones.Rows[n].Cells[4].Value;
                this.txtNombre.Text = (string)dgTransacciones.Rows[n].Cells[5].Value;
                this.txtPrimerApellido.Text = (string)dgTransacciones.Rows[n].Cells[6].Value;
                this.txtSegundoApellido.Text = (string)dgTransacciones.Rows[n].Cells[7].Value;
                this.txtRazonSocial.Text = (string)dgTransacciones.Rows[n].Cells[8].Value;
                this.txtMontoIngreso.Text = (string)dgTransacciones.Rows[n].Cells[9].Value;
                this.txtCodigoIngreso.Text = (string)dgTransacciones.Rows[n].Cells[10].Value;
                this.txtMontoEgreso.Text = (string)dgTransacciones.Rows[n].Cells[11].Value;
                this.txtCodigoEgreso.Text = (string)dgTransacciones.Rows[n].Cells[12].Value;
                this.txtDetalleTransaccion.Text = (string)dgTransacciones.Rows[n].Cells[13].Value;
                this.txtDetalleOrigen.Text = (string)dgTransacciones.Rows[n].Cells[14].Value;
            }
        }

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


        private void txtMontoIngreso_TextChanged(object sender, EventArgs e)
        {
            FormatoMoneda(txtMontoIngreso);
        }

        private void txtMontoEgreso_TextChanged(object sender, EventArgs e)
        {
            FormatoMoneda(txtMontoEgreso);
        }

        private void btnActividadEconomica_Click(object sender, EventArgs e)
        {
            Sugef.FrmSeleccionarActividad ObjBuscarActividad = new Sugef.FrmSeleccionarActividad();
            ObjBuscarActividad.evento += new FrmSeleccionarActividad.delegado(ejecutarDelegado);
            ObjBuscarActividad.ShowDialog();
        }

        public void ejecutarDelegado(string codigo,  string descripcion)
        {
            this.txtCodigo.Text = codigo;
            this.txtActividad.Text = descripcion;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string tipo_persona = this.txtCodigoPersona.Text;
            string id_persona = this.txtIdentificacion.Text;
            string tipo_operacion = this.txtTipoOperacion.Text;
            double monto_ingreso = Double.Parse(this.txtMontoIngreso.Text);
            double monto_egreso = Double.Parse(this.txtMontoEgreso.Text);
            string tipoentrada_salidafondos = "";
            string tipo_moneda_transaccion = "";
            double monto = 0.00;
            DateTime fecha_transaccion = DateTime.Parse(this.txtFecha.Text);
            string fecha = this.txtFecha.Text;
            string tipo_transaccion = this.txtTipoTransaccion.Text;
            string tipo_actividad_economica = this.txtCodigo.Text;            
            string det_origen = this.txtDetalleOrigen.Text;

            if (this.txtCodigoPersona.Text == "" || this.txtIdentificacion.Text == "" || this.txtFecha.Text == "")
            {
                MessageBox.Show("No ha seleccionado correctamente la transacción!", "Favor seleccione una transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.txtCodigo.Text == "" || this.txtActividad.Text == "")
            {
                MessageBox.Show("No ha seleccionado correctamente la actividad económica para procesar la transacción!", "Favor seleccione una actividad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (monto_ingreso > 0 && monto_egreso == 0)
                {
                    tipoentrada_salidafondos = "1";
                    tipo_moneda_transaccion = this.txtCodigoIngreso.Text;
                    monto = monto_ingreso;
                } 
                else if (monto_ingreso == 0 && monto_egreso > 0)
                {
                    tipoentrada_salidafondos = "2";
                    tipo_moneda_transaccion = this.txtCodigoEgreso.Text;
                    monto = monto_egreso;
                }

                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("SUGEF.INSERTAR_TRANSACCIONES_MAY", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pTIPOPERSONA", OracleDbType.Varchar2).Value = tipo_persona;
                        comando.Parameters.Add("pIDPERSONA", OracleDbType.Varchar2).Value = id_persona;
                        comando.Parameters.Add("pTIPOOPERACION", OracleDbType.Varchar2).Value = tipo_operacion;
                        comando.Parameters.Add("pTIPOENTRADASALIDAFONDOS", OracleDbType.Varchar2).Value = tipoentrada_salidafondos;
                        comando.Parameters.Add("pTIPOMONEDATRANSACCION", OracleDbType.Varchar2).Value = tipo_moneda_transaccion;
                        comando.Parameters.Add("pMONTO", OracleDbType.Double).Value = monto;
                        comando.Parameters.Add("pFECHATRANSACCION", OracleDbType.Date).Value = fecha_transaccion;
                        comando.Parameters.Add("pTIPOTRANSACCION", OracleDbType.Varchar2).Value = tipo_transaccion;
                        comando.Parameters.Add("pTIPOACTIVIDADECONOMICA", OracleDbType.Varchar2).Value = tipo_actividad_economica;
                        comando.Parameters.Add("pORIGENFONDOS", OracleDbType.Varchar2).Value = det_origen;
                        comando.Parameters.Add("pFECHA", OracleDbType.Varchar2).Value = fecha;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Se han ingresado los datos correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
