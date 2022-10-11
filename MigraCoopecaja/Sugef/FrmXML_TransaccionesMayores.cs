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
using Datos.EntidadesAux.XMLLegitimacion;
using Logica;

namespace AppEscritorio.Sugef
{
    public partial class FrmXML_TransaccionesMayores : Form
    {
        /**
              * 
              * Pantalla de generación de XML, transacciones superiores a $10 000
              * - R-017284 - Requerimiento XML SUGEF - Por Diego Arguedas Rojas
              * 
                    Modificación de la estructura del xml clase de datos 6 a clase de datos 50 -Legitimación de Capitales.
              * 
              * 
         * */
        CapaLogica objCapaLogica;
        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;
        private int n = 0;
        List<DatosXMLLegitimacion> ListaDatos;
        public FrmXML_TransaccionesMayores()
        {
            InitializeComponent();
            dtFecha_Antes.Format = DateTimePickerFormat.Custom;
            dtFecha_Antes.CustomFormat = "dd MMMM yyyy";
            dtFecha_Despues.Format = DateTimePickerFormat.Custom;
            dtFecha_Despues.CustomFormat = "dd MMMM yyyy";
        }

        private void FrmXML_TransaccionesMayores_Load(object sender, EventArgs e)
        {
            consultaTransacciones();
            this.label12.Visible = false;
        }

        private void consultaTransacciones()
        {
            string id = "0";
            string tipo_persona = "";
            string id_persona = "";
            string tipo_operacion = "";
            string tipoentrada_salidafondos = "";
            string tipo_moneda_transaccion = "";
            string monto = "0.00";
            string fecha_transaccion = "";
            string tipo_transaccion = "";
            string tipo_actividad_economica = "";
            string origen_fondos = "";
            string comando = "SELECT ID, TIPOPERSONA, IDPERSONA, TIPOOPERACION, TIPOENTRADASALIDAFONDOS, TIPOMONEDATRANSACCION, " +
                "MONTO, FECHATRANSACCION, TIPOTRANSACCION, TIPOACTIVIDADECONOMICA, ORIGENFONDOS FROM SUGEF.LV_EFECTIVO_MAYOR_MONTO " +
                "ORDER BY FECHATRANSACCION DESC";

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
                            id = (String)sqlDR["ID"].ToString();
                            tipo_persona = (String)sqlDR["TIPOPERSONA"].ToString();
                            id_persona = (String)sqlDR["IDPERSONA"].ToString();
                            tipo_operacion = (String)sqlDR["TIPOOPERACION"].ToString();
                            tipoentrada_salidafondos = (String)sqlDR["TIPOENTRADASALIDAFONDOS"].ToString();
                            tipo_moneda_transaccion = (String)sqlDR["TIPOMONEDATRANSACCION"].ToString();
                            monto = (String)sqlDR["MONTO"].ToString();
                            fecha_transaccion = (String)sqlDR["FECHATRANSACCION"].ToString();
                            string fecha = fecha_transaccion;
                            String fecha_sin_hora = fecha_transaccion.Substring(0, 10);
                            tipo_transaccion = (String)sqlDR["TIPOTRANSACCION"].ToString();
                            tipo_actividad_economica = (String)sqlDR["TIPOACTIVIDADECONOMICA"].ToString();
                            origen_fondos = (String)sqlDR["ORIGENFONDOS"].ToString();

                            int n = dgTransacciones.Rows.Add();

                            dgTransacciones.Rows[n].Cells[0].Value = id;
                            dgTransacciones.Rows[n].Cells[1].Value = tipo_persona;
                            dgTransacciones.Rows[n].Cells[2].Value = id_persona;
                            dgTransacciones.Rows[n].Cells[3].Value = tipo_operacion;
                            dgTransacciones.Rows[n].Cells[4].Value = tipoentrada_salidafondos;
                            dgTransacciones.Rows[n].Cells[5].Value = tipo_moneda_transaccion;
                            dgTransacciones.Rows[n].Cells[6].Value = monto;
                            dgTransacciones.Rows[n].Cells[7].Value = fecha_sin_hora;
                            dgTransacciones.Rows[n].Cells[8].Value = tipo_transaccion;
                            dgTransacciones.Rows[n].Cells[9].Value = tipo_actividad_economica;
                            dgTransacciones.Rows[n].Cells[10].Value = origen_fondos;
                            
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

        private void dgTransacciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.label12.Text = (string)dgTransacciones.Rows[n].Cells[0].Value;
                this.txtTipoPersona.Text = (string)dgTransacciones.Rows[n].Cells[1].Value;
                this.txtIdPersona.Text = (string)dgTransacciones.Rows[n].Cells[2].Value;
                this.txtTipo_Operacion.Text = (string)dgTransacciones.Rows[n].Cells[3].Value;
                this.txtTipoEntradaSalida.Text = (string)dgTransacciones.Rows[n].Cells[4].Value;
                this.txtTipoMoneda.Text = (string)dgTransacciones.Rows[n].Cells[5].Value;
                this.txtMonto.Text = (string)dgTransacciones.Rows[n].Cells[6].Value;
                this.txtFecha.Text = (string)dgTransacciones.Rows[n].Cells[7].Value;
                this.txtTipoTransaccion.Text = (string)dgTransacciones.Rows[n].Cells[8].Value;
                this.txtTipoActividad.Text = (string)dgTransacciones.Rows[n].Cells[9].Value;
                this.txtOrigenFondos.Text = (string)dgTransacciones.Rows[n].Cells[10].Value;    
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

        private void dgTransacciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex != this.dgTransacciones.NewRowIndex)
            {
                if (dgTransacciones.Rows[e.RowIndex].Cells[6].Value != null)
                {
                    double val2 = double.Parse(e.Value.ToString());
                    e.Value = val2.ToString("N2");
                }
            }
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {
            FormatoMoneda(txtMonto);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.label12.Text);
            string tipo_persona = this.txtTipoPersona.Text;
            string id_persona = this.txtIdPersona.Text;
            string tipo_operacion = this.txtTipo_Operacion.Text;
            string tipo_entrada_salida = this.txtTipoEntradaSalida.Text;
            string tipo_moneda = this.txtTipoMoneda.Text;
            double monto = Double.Parse(this.txtMonto.Text);
            DateTime fecha_transaccion = DateTime.Parse(this.txtFecha.Text);
            string tipo_transaccion = this.txtTipoTransaccion.Text;
            string tipo_actividad = this.txtTipoActividad.Text;
            string origen_fondos = this.txtOrigenFondos.Text;
            string fecha = this.txtFecha.Text;
                

            if (tipo_persona == "" && id_persona == "" && tipo_operacion == "" && tipo_entrada_salida == "" && tipo_moneda == "" && monto == 0.00 && fecha_transaccion == null &&
                tipo_transaccion == "" && tipo_actividad == "" && origen_fondos == "")
            {
                MessageBox.Show("No ha seleccionado correctamente la transacción para modificarla!", "Favor seleccione una transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("SUGEF.MODIFICAR_TRANSACCIONES_MAY", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pID", OracleDbType.Int32).Value = id;
                        comando.Parameters.Add("pTIPOPERSONA", OracleDbType.Varchar2).Value = tipo_persona;
                        comando.Parameters.Add("pIDPERSONA", OracleDbType.Varchar2).Value = id_persona;
                        comando.Parameters.Add("pTIPOOPERACION", OracleDbType.Varchar2).Value = tipo_operacion;
                        comando.Parameters.Add("pTIPOENTRADASALIDAFONDOS", OracleDbType.Varchar2).Value = tipo_entrada_salida;
                        comando.Parameters.Add("pTIPOMONEDATRANSACCION", OracleDbType.Varchar2).Value = tipo_moneda;
                        comando.Parameters.Add("pMONTO", OracleDbType.Double).Value = monto;
                        comando.Parameters.Add("pFECHATRANSACCION", OracleDbType.Date).Value = fecha_transaccion;
                        comando.Parameters.Add("pTIPOTRANSACCION", OracleDbType.Varchar2).Value = tipo_transaccion;
                        comando.Parameters.Add("pTIPOACTIVIDADECONOMICA", OracleDbType.Varchar2).Value = tipo_actividad;
                        comando.Parameters.Add("pORIGENFONDOS", OracleDbType.Varchar2).Value = origen_fondos;
                        comando.Parameters.Add("pFECHA", OracleDbType.Varchar2).Value = fecha;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Se han modificado los datos correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        connOra.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se han modificado los datos correctamente", "Datos No Guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            dgTransacciones.Rows.Clear();
            consultaTransacciones();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.label12.Text);
            string tipo_persona = this.txtTipoPersona.Text;
            string id_persona = this.txtIdPersona.Text;
            string tipo_operacion = this.txtTipo_Operacion.Text;
            string tipo_entrada_salida = this.txtTipoEntradaSalida.Text;
            string tipo_moneda = this.txtTipoMoneda.Text;
            double monto = Double.Parse(this.txtMonto.Text);
            string fecha_transaccion = this.txtFecha.Text;
            string fecha = fecha_transaccion;
            String fecha_sin_hora = fecha.Substring(0, 10);
            string tipo_transaccion = this.txtTipoTransaccion.Text;
            string tipo_actividad = this.txtTipoActividad.Text;
            string origen_fondos = this.txtOrigenFondos.Text;

            if (tipo_persona == "" && id_persona == "" && tipo_operacion == "" && tipo_entrada_salida == "" && tipo_moneda == "" && monto == 0.00 && fecha_transaccion == null &&
                tipo_transaccion == "" && tipo_actividad == "" && origen_fondos == "")
            {
                MessageBox.Show("No ha seleccionado correctamente la transacción para eliminarla!", "Favor seleccione una transacción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("SUGEF.ELIMINAR_TRANSACCIONES_MAY", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pID", OracleDbType.Int32).Value = id;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Se han eliminado los datos correctamente", "Datos Eliminados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        connOra.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se han eliminado los datos correctamente", "Datos No Eliminados", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    throw ex;
                }
            }
            dgTransacciones.Rows.Clear();
            consultaTransacciones();
        }

        private void filtrarPorFecha(string fecha_desde, string fecha_hasta)
        {
            
            DateTime fechaD = dtFecha_Antes.Value;
            DateTime fechaH = dtFecha_Despues.Value;
            int diaD = fechaD.Day;
            int mesD = fechaD.Month;
            int annoD = fechaD.Year;
            int diaH = fechaH.Day;
            int mesH = fechaH.Month;
            int annoH = fechaH.Year;
            string periodo_desde = diaD.ToString() +  "/" + (mesD.ToString().Length == 1 ? "0" + mesD.ToString() : mesD.ToString()) + "/" + annoD.ToString();
            string periodo_hasta = diaH.ToString() + "/" + (mesH.ToString().Length == 1 ? "0" + mesH.ToString() : mesH.ToString()) + "/" + annoH.ToString();
            string id = "0";
            string tipo_persona = "";
            string id_persona = "";
            string tipo_operacion = "";
            string tipoentrada_salidafondos = "";
            string tipo_moneda_transaccion = "";
            string monto = "0.00";
            string fecha_transaccion = "";
            string tipo_transaccion = "";
            string tipo_actividad_economica = "";
            string origen_fondos = "";

            string comando = "SELECT * " +
                "FROM SUGEF.LV_EFECTIVO_MAYOR_MONTO WHERE FECHATRANSACCION BETWEEN TO_DATE('" + fecha_desde + "', 'DD/MM/YYYY') " +
                "AND TO_DATE('" + fecha_hasta + "', 'DD/MM/YYYY') ORDER BY FECHATRANSACCION DESC";

            try
            {

                if (fecha_desde.Trim() == "" || fecha_hasta.Trim() == "")
                {
                    return;
                }

                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("fecha_desde", periodo_desde));
                    Query.Parameters.Add(new OracleParameter("fecha_hasta", periodo_hasta));
                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            id = (String)sqlDR["ID"].ToString();
                            tipo_persona = (String)sqlDR["TIPOPERSONA"].ToString();
                            id_persona = (String)sqlDR["IDPERSONA"].ToString();
                            tipo_operacion = (String)sqlDR["TIPOOPERACION"].ToString();
                            tipoentrada_salidafondos = (String)sqlDR["TIPOENTRADASALIDAFONDOS"].ToString();
                            tipo_moneda_transaccion = (String)sqlDR["TIPOMONEDATRANSACCION"].ToString();
                            monto = (String)sqlDR["MONTO"].ToString();
                            fecha_transaccion = (String)sqlDR["FECHATRANSACCION"].ToString();
                            string fecha = fecha_transaccion;
                            String fecha_sin_hora = fecha_transaccion.Substring(0, 10);
                            tipo_transaccion = (String)sqlDR["TIPOTRANSACCION"].ToString();
                            tipo_actividad_economica = (String)sqlDR["TIPOACTIVIDADECONOMICA"].ToString();
                            origen_fondos = (String)sqlDR["ORIGENFONDOS"].ToString();


                            int n = dgTransacciones.Rows.Add();

                            dgTransacciones.Rows[n].Cells[0].Value = id;
                            dgTransacciones.Rows[n].Cells[1].Value = tipo_persona;
                            dgTransacciones.Rows[n].Cells[2].Value = id_persona;
                            dgTransacciones.Rows[n].Cells[3].Value = tipo_operacion;
                            dgTransacciones.Rows[n].Cells[4].Value = tipoentrada_salidafondos;
                            dgTransacciones.Rows[n].Cells[5].Value = tipo_moneda_transaccion;
                            dgTransacciones.Rows[n].Cells[6].Value = monto;
                            dgTransacciones.Rows[n].Cells[7].Value = fecha_sin_hora;
                            dgTransacciones.Rows[n].Cells[8].Value = tipo_transaccion;
                            dgTransacciones.Rows[n].Cells[9].Value = tipo_actividad_economica;
                            dgTransacciones.Rows[n].Cells[10].Value = origen_fondos;
                        }
                    }
                    else if (!(sqlDR.HasRows))
                    {

                        MessageBox.Show("No existen registros para este periodo seleccionado, valide el periodo nuevamente", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        consultaTransacciones();
                    }

                    sqlDR.Close();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pbFecha_Click(object sender, EventArgs e)
        {
            dgTransacciones.Rows.Clear();

            if (this.dtFecha_Antes.Value == null || dtFecha_Despues.Value == null)
            {
                MessageBox.Show("No ha seleccionado un periodo para la búsqueda",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DateTime fechaD = dtFecha_Antes.Value;
                DateTime fechaH = dtFecha_Despues.Value;
                int diaD = fechaD.Day;
                int mesD = fechaD.Month;
                int annoD = fechaD.Year;
                int diaH = fechaH.Day;
                int mesH = fechaH.Month;
                int annoH = fechaH.Year;
                string periodo_desde = diaD.ToString() + "/" + (mesD.ToString().Length == 1 ? "0" + mesD.ToString() : mesD.ToString()) + "/" + annoD.ToString();
                string periodo_hasta = diaH.ToString() + "/" + (mesH.ToString().Length == 1 ? "0" + mesH.ToString() : mesH.ToString()) + "/" + annoH.ToString();

                filtrarPorFecha(periodo_desde, periodo_hasta);
            }
        }

        private void pbRefrescar_Click(object sender, EventArgs e)
        {
            dgTransacciones.Rows.Clear();
            consultaTransacciones();
        }

        public List<DatosXMLLegitimacion> obtenerDatosXML(string fecha_desde, string fecha_hasta)
        {
            List<DatosXMLLegitimacion> listaDatos = null;
            DateTime fechaD = dtFecha_Antes.Value;
            DateTime fechaH = dtFecha_Despues.Value;
            int diaD = fechaD.Day;
            int mesD = fechaD.Month;
            int annoD = fechaD.Year;
            int diaH = fechaH.Day;
            int mesH = fechaH.Month;
            int annoH = fechaH.Year;

            string periodo_desde = (diaD.ToString().Length == 1 ? "0" + diaD.ToString() : diaD.ToString()) + "/" + (mesD.ToString().Length == 1 ? "0" + mesD.ToString() : mesD.ToString()) + "/" + annoD.ToString();
            string periodo_hasta = (diaH.ToString().Length == 1 ? "0" + diaH.ToString() : diaH.ToString()) + "/" + (mesH.ToString().Length == 1 ? "0" + mesH.ToString() : mesH.ToString()) + "/" + annoH.ToString();

            string comando = "SELECT TIPOPERSONA, IDPERSONA, TIPOOPERACION, TIPOENTRADASALIDAFONDOS, TIPOMONEDATRANSACCION, MONTO, FECHA, " +
                "TIPOTRANSACCION, TIPOACTIVIDADECONOMICA, ORIGENFONDOS " +
                "FROM SUGEF.LV_EFECTIVO_MAYOR_MONTO WHERE FECHATRANSACCION BETWEEN TO_DATE('" + fecha_desde + "', 'DD/MM/YYYY') " +
                "AND TO_DATE('" + fecha_hasta + "', 'DD/MM/YYYY') ORDER BY FECHATRANSACCION DESC";

            try
            {
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle)) {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("periodo_desde", periodo_desde));
                    Query.Parameters.Add(new OracleParameter("periodo_hasta", periodo_hasta));
                    Query.CommandTimeout = 10000;

                    OracleDataReader sqlDR = Query.ExecuteReader();
                    listaDatos = new List<DatosXMLLegitimacion>();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            DatosXMLLegitimacion datos = new DatosXMLLegitimacion();
                            datos.tipo_persona = sqlDR.GetString(0);
                            datos.id_persona = sqlDR.GetString(1);
                            datos.tipo_operacion = sqlDR.GetString(2);
                            datos.tipo_entrada_salida = sqlDR.GetString(3);
                            datos.tipo_moneda = sqlDR.GetString(4);
                            datos.monto = sqlDR.GetDecimal(5);
                            datos.fecha = sqlDR.GetString(6);
                            datos.tipo_transaccion = sqlDR.GetString(7);
                            datos.tipo_actividad = sqlDR.GetString(8);
                            datos.origen_fondos = sqlDR.GetString(9);
                            
                            listaDatos.Add(datos);
                        }
                    }

                    sqlDR.Close();
                    return listaDatos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void generaXMLLegitimacion(string ruta)
        {
            try
            {
                objCapaLogica = new CapaLogica();
                DateTime fechaD = dtFecha_Antes.Value;
                DateTime fechaH = dtFecha_Despues.Value;
                int diaD = fechaD.Day;
                int mesD = fechaD.Month;
                int annoD = fechaD.Year;
                int diaH = fechaH.Day;
                int mesH = fechaH.Month;
                int annoH = fechaH.Year;
                string periodo_desde = (diaD.ToString().Length == 1 ? "0" + diaD.ToString() : diaD.ToString()) + "/" + (mesD.ToString().Length == 1 ? "0" + mesD.ToString() : mesD.ToString()) + "/" + annoD.ToString();
                string periodo_hasta = (diaH.ToString().Length == 1 ? "0" + diaH.ToString() : diaH.ToString()) + "/" + (mesH.ToString().Length == 1 ? "0" + mesH.ToString() : mesH.ToString()) + "/" + annoH.ToString();

                Encabezado_Legitimacion encabezado = new Encabezado_Legitimacion()
                {
                    clase = "50",
                    versionClase = "1.0",
                    archivo = "5001",
                    versionArchivo = "1.0",
                    Periodo = periodo_desde,
                    entidad = "3004045110",
                    tipoCarga = "1",
                    tipoMoneda = "1"
                };

                ListaDatos = obtenerDatosXML(periodo_desde, periodo_hasta);

                ToolSistema.PrintXMLLegitimacion(ruta, encabezado, ListaDatos);

                MessageBox.Show("El XML se generó en la ruta seleccionada", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            catch (Exception e)
            {

                MessageBox.Show("No se pudo generar el proceso. Favor vuelva a intentarlo! (2)" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        generaXMLLegitimacion(fbd.SelectedPath);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el proceso. Vuelva a intentarlo" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}