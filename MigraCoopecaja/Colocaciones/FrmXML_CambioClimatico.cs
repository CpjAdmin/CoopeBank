using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.EntidadesAux.XMLCambioClimatico;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using Logica;


namespace AppEscritorio.Colocaciones
{
    public partial class FrmXML_CambioClimatico : Form
    {

        CapaLogica objCapaLogica;
        List<ListaSubTema> ListaSubTemas;
        List<ListaActividades> ListaActividades;
        List<ListaFinanciamiento> ListaFinanciamiento;
        List<DatosXMLCambioClimatico> ListaDatos;
        private int n = 0;

        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;


        public FrmXML_CambioClimatico()
        {
            InitializeComponent();
            dtPeriodo.Format = DateTimePickerFormat.Custom;
            dtPeriodo.CustomFormat = "MMMM yyyy";
        }

        public List<DatosXMLCambioClimatico> obtenerDatosXML(string periodo_op)
        {

            List<DatosXMLCambioClimatico> listaDatos = null;
            DateTime fecha = dtPeriodo.Value;
            int mes = fecha.Month;
            int anno = fecha.Year;
            string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();
            string comando = "SELECT NUM_OPERACION, MONTO, AMBITO, TEMA, SUBTEMA, ACTIVIDAD, FUENTE, TIPOFUENTE, MODALIDAD FROM SUGEF.CC_XML_HIST WHERE PERIODO = '" + periodo_op + "' ORDER BY ID DESC";
            
            try
            {

                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle)) {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    //Query.Parameters.Add(new OracleParameter("numero_op", numero_op));
                    Query.Parameters.Add(new OracleParameter("periodo_op", periodo_op));
                    Query.CommandTimeout = 10000;

                    OracleDataReader sqlDR = Query.ExecuteReader();
                    listaDatos = new List<DatosXMLCambioClimatico>();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            
                            DatosXMLCambioClimatico datos = new DatosXMLCambioClimatico();
                            datos.operacion = sqlDR.GetString(0);
                            datos.monto = sqlDR.GetString(1);
                            datos.ambito = sqlDR.GetString(2);
                            datos.tema = sqlDR.GetString(3);
                            datos.subtema = sqlDR.GetString(4);
                            datos.actividad = sqlDR.GetString(5);
                            datos.fuente = sqlDR.GetString(6);
                            datos.tipofuente = sqlDR.GetString(7);
                            datos.modalidad = sqlDR.GetString(8);
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

        private void seleccionaOperacion(string periodo_op)
        {
            DateTime fecha = dtPeriodo.Value;
            int mes = fecha.Month;
            int anno = fecha.Year;
            string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();
            string num_operacion = "";
            string monto = "";
            string ambito = "";
            string tema = "";
            string subtema = "";
            string actividad = "";
            string fuente = "";
            string tipofuente = "";
            string modalidad = "";
            string comando = "SELECT * " +
                "FROM SUGEF.CC_XML_HIST WHERE PERIODO = '" + periodo_op + "' ORDER BY NUM_OPERACION";

            try
            {

                if (periodo_op.Trim() == "")
                {
                    return;
                }
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle)) {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    //Query.Parameters.Add(new OracleParameter("numero_op", numero_op));
                    Query.Parameters.Add(new OracleParameter("periodo_op", periodo));

                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {

                            num_operacion = (String)sqlDR["NUM_OPERACION"].ToString();
                            monto = (String)sqlDR["MONTO"].ToString();
                            periodo = (String)sqlDR["PERIODO"].ToString();
                            ambito = (String)sqlDR["AMBITO"].ToString();
                            tema = (String)sqlDR["TEMA"].ToString();
                            subtema = (String)sqlDR["SUBTEMA"].ToString();
                            actividad = (String)sqlDR["ACTIVIDAD"].ToString();
                            fuente = (String)sqlDR["FUENTE"].ToString();
                            tipofuente = (String)sqlDR["TIPOFUENTE"].ToString();
                            modalidad = (String)sqlDR["MODALIDAD"].ToString();


                            int n = dgClimatico.Rows.Add();

                            dgClimatico.Rows[n].Cells[0].Value = num_operacion;
                            dgClimatico.Rows[n].Cells[1].Value = monto;
                            dgClimatico.Rows[n].Cells[2].Value = periodo;
                            dgClimatico.Rows[n].Cells[3].Value = ambito;
                            dgClimatico.Rows[n].Cells[4].Value = tema;
                            dgClimatico.Rows[n].Cells[5].Value = subtema;
                            dgClimatico.Rows[n].Cells[6].Value = actividad;
                            dgClimatico.Rows[n].Cells[7].Value = fuente;
                            dgClimatico.Rows[n].Cells[8].Value = tipofuente;
                            dgClimatico.Rows[n].Cells[9].Value = modalidad;
                        }
                    }
                    else if (!(sqlDR.HasRows))
                    {

                        MessageBox.Show("No existen registros para este periodo seleccionado, valide el periodo nuevamente", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    sqlDR.Close();
                }

            }
            catch (Exception ex) {

                throw ex;
            }

        }

        private void validaOperacion(string numero)
        {
          
            string nombreCliente = "";
            string numeroOperacion = "";
            string monto = "";
            string fecha_formalizacion = "";

            string comando = "SELECT C.NOM_CLIENTE, D.MON_ORIGINAL, D.NUM_OPERACION, D.FEC_CONSTITUCION FROM CREDITO.CR_SOLICITUDES  A" +
                                                           " LEFT JOIN FVENTAS.FV_VENDEDORES B ON A.COD_VENDEDOR = B.COD_VENDEDOR AND A.COD_COMPANIA = B.COD_COMPANIA " +
                                                           " JOIN CLIENTES.CL_CLIENTES C ON A.COD_CLIENTE = C.COD_CLIENTE " +
                                                           " JOIN CREDITO.CR_OPERACIONES D ON A.NUM_SOLICITUD  = D.NUM_SOLICITUD " +
                                                           " JOIN GENERAL.GL_UBICACIONES E ON D.COD_UBICACION = E.COD_UBICACION " +
                                                           " where D.NUM_OPERACION = :1";

            try
            {
                if (numero.Trim() == "")
                {
                    this.txtNombre.Text = "";
                    this.txtMonto.Text = "";
                    this.txtFechaForm.Text = "";
                    return;
                }

                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {
                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("numero", numero));
                    Query.CommandTimeout = 10000;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {

                            nombreCliente = (String)sqlDR["NOM_CLIENTE"].ToString();
                            monto = (String)sqlDR["MON_ORIGINAL"].ToString();
                            numeroOperacion = (String)sqlDR["NUM_OPERACION"].ToString();
                            fecha_formalizacion = (String)sqlDR["FEC_CONSTITUCION"].ToString(); ;
                            this.txtNombre.Text = nombreCliente;
                            this.txtMonto.Text = monto;
                            string sub = fecha_formalizacion;
                            String res = sub.Substring(0, 10);
                            this.txtFechaForm.Text = res;
                        }
                    } 
                    else {

                        MessageBox.Show("No se encontró la solicitud u operación digitada", "CREDITOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtOperacion.Text = "";
                        this.txtMonto.Text = "";
                        this.txtNombre.Text = "";
                        this.txtFechaForm.Text = "";
                    }
                    sqlDR.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "SOLICITUDES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmXML_CambioClimatico_Load(object sender, EventArgs e)
        {
            CargaSubTemas();
            CargaActividades();
            CargaFinanciamiento();
            cbxTema.SelectedIndex = 0;
            cbxAmbito.SelectedIndex = 0;
            cbxModalidad.SelectedIndex = 0;
            cbxTipoFuente.SelectedIndex = 0;
        }

        public void CargaFinanciamiento()
        {
            objCapaLogica = new CapaLogica();
            ListaFinanciamiento = new List<ListaFinanciamiento>();
            ListaFinanciamiento = objCapaLogica.ConsultarFinanciamiento().OrderBy(x => x.CODIGO).ToList();
            lstFinanciamiento.DisplayMember = "FUENTE";
            lstFinanciamiento.ValueMember = "FUENTE";
            lstFinanciamiento.DataSource = ListaFinanciamiento;
        }

        public void CargaActividades()
        {
            objCapaLogica = new CapaLogica();
            ListaActividades = new List<ListaActividades>();
            ListaActividades = objCapaLogica.ConsultarActividades().OrderBy(x => x.CODIGO).ToList();
            lstActividad.DisplayMember = "ACTIVIDAD";
            lstActividad.ValueMember = "ACTIVIDAD";
            lstActividad.DataSource = ListaActividades;
        }

        public void CargaSubTemas()
        {
            objCapaLogica = new CapaLogica();
            ListaSubTemas = new List<ListaSubTema>();
            ListaSubTemas = objCapaLogica.ConsultarSubTema().OrderBy(x => x.CODIGO).ToList();
            cbxSubTema.DisplayMember = "SUBTEMAS";
            cbxSubTema.ValueMember = "SUBTEMAS";
            cbxSubTema.DataSource = ListaSubTemas;

        }

        //Este es el botón para ingresar las solicitudes de operación
        private void btnVer_Click(object sender, EventArgs e)
        {
            DatosXMLCambioClimatico datos = new DatosXMLCambioClimatico();
            
            if (this.txtOperacion.Text == "" || this.txtFechaForm.Text == "" || this.txtMonto.Text == "" || this.txtNombre.Text == "")
            {
                MessageBox.Show("Los campos obligatorios están incompletos, no se podrá realizar ninguna operación",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int subtema = Int32.Parse(cbxSubTema.SelectedIndex.ToString());
                int actividades = Int32.Parse(lstActividad.SelectedIndex.ToString());
                DateTime fecha = dtPeriodo.Value;
                int mes = fecha.Month;
                int anno = fecha.Year;
                string sub = this.txtFechaForm.Text;
                String month = sub.Substring(3, 2);
                String year = sub.Substring(6, 4);
                
                string fec_const = "01/" + month + "/" + year;

                string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();

                double fuente = Double.Parse(cbxTipoFuente.SelectedIndex.ToString());

                switch (fuente)
                {

                    case 0:
                        fuente = 1.1;
                        break;
                    case 1:
                        fuente = 1.2;
                        break;
                    case 2:
                        fuente = 2.1;
                        break;
                    case 3:
                        fuente = 2.2;
                        break;
                    case 4:
                        fuente = 3.1;
                        break;
                    case 5:
                        fuente = 3.2;
                        break;
                    case 6:
                        fuente = 3.3;
                        break;
                    case 7:
                        fuente = 3.4;
                        break;
                    case 8:
                        fuente = 4.1;
                        break;
                    case 9:
                        fuente = 4.2;
                        break;
                    default:
                        break;
                }

                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))

                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("SUGEF.INSERTADATOSXMLCLIMATICO", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pNUM_OPERACION", OracleDbType.Varchar2).Value = txtOperacion.Text;
                        comando.Parameters.Add("pMONTO", OracleDbType.Varchar2).Value = txtMonto.Text;
                        comando.Parameters.Add("pFEC_CONSTITUCION", OracleDbType.Varchar2).Value = txtFechaForm.Text;
                        comando.Parameters.Add("pPERIODO", OracleDbType.Varchar2).Value = fec_const;
                        comando.Parameters.Add("pAMBITO", OracleDbType.Varchar2).Value = cbxAmbito.SelectedIndex.ToString();
                        comando.Parameters.Add("pTEMA", OracleDbType.Varchar2).Value = cbxTema.SelectedIndex.ToString();
                        comando.Parameters.Add("pSUBTEMA", OracleDbType.Varchar2).Value = subtema + 1;
                        comando.Parameters.Add("pACTIVIDAD", OracleDbType.Varchar2).Value = actividades + 1;
                        comando.Parameters.Add("pFUENTE", OracleDbType.Varchar2).Value = fuente;
                        comando.Parameters.Add("pTIPOFUENTE", OracleDbType.Varchar2).Value = lstFinanciamiento.SelectedIndex.ToString();
                        comando.Parameters.Add("pMODALIDAD", OracleDbType.Varchar2).Value = cbxModalidad.SelectedIndex.ToString();
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

        private void generaXMLClimatico(string ruta)
        {
            try
            {
                objCapaLogica = new CapaLogica();
                DateTime fecha = dtPeriodo.Value;
                int mes = fecha.Month;
                int anno = fecha.Year;

                string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();

                Encabezado encabezado = new Encabezado()
                {
                    clase = "3",
                    versionClase = "1.0",
                    archivo = "313",
                    versionArchivo = "1.0",
                    Periodo = periodo,
                    entidad = "3004045110",
                    tipoCarga = "1",
                    tipoMoneda = "1"
                };

                ListaDatos = obtenerDatosXML(periodo);

                ToolSistema.PrintXMLCambioClimatico(ruta, encabezado, ListaDatos);

                MessageBox.Show("El XML se generó en la ruta seleccionada", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            catch (Exception e) {

                MessageBox.Show("No se pudo generar el proceso. Favor vuelva a intentarlo! (2)" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (this.txtOperacion.Text == "" || this.txtFechaForm.Text == "" || this.txtMonto.Text == "" || this.txtNombre.Text == "")
            {
                MessageBox.Show("Los campos obligatorios están incompletos, no se podrá realizar ninguna operación",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            generaXMLClimatico(fbd.SelectedPath);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo generar el proceso. Vuelva a intentarlo (1)" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            dgClimatico.Rows.Clear();

            if (this.dtPeriodo.Value == null)
            {
                MessageBox.Show("No ha seleccionado un periodo para la búsqueda",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else

            {
                DateTime fecha = dtPeriodo.Value;
                int mes = fecha.Month;
                int anno = fecha.Year;


                string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();

                seleccionaOperacion(periodo);
            }
        }

        public void FormatoMoneda(TextBox txtBox)
        {
            if (txtBox.Text == string.Empty) {
                return;
            }
            else
            {
                Decimal monto;
                monto = Convert.ToDecimal(txtBox.Text);
                txtBox.Text = monto.ToString("N2");
            }
        }



        private void txtOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) {

                if (this.txtOperacion.Text == "")
                {
                    MessageBox.Show("El campo de número de operación está incompleto, no se podrá realizar ninguna operación",
                        "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string numero = this.txtOperacion.Text.Trim();
                    validaOperacion(numero);
                }
            }
        }

        private void txtOperacion_Leave(object sender, EventArgs e)
        {
            if (this.txtOperacion.Text == "")
            {
                MessageBox.Show("El campo de número de operación está incompleto, no se podrá realizar ninguna operación",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string numero = this.txtOperacion.Text.Trim();
                validaOperacion(numero);
            }
        }

        private void dgClimatico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.lblOperacion.Text = (string)dgClimatico.Rows[n].Cells[0].Value;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
            if (n != -1)
            {

                
                if (this.lblOperacion.Text == "")
                {
        
                        MessageBox.Show("No se seleccionó valor en el grid correctamente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    
                    DialogResult resultado = MessageBox.Show("Desea eliminar el registro de la operación: " + this.lblOperacion.Text, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {
                            using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                            {
                                connOra.Open();
                                OracleCommand comando = new OracleCommand("SUGEF.ELIMINARDATOS", connOra);
                                comando.CommandType = System.Data.CommandType.StoredProcedure;
                                comando.Parameters.Add("pNUM_OPERACION", OracleDbType.Varchar2).Value = this.lblOperacion.Text.ToString();
                                comando.ExecuteNonQuery();

                                MessageBox.Show("Se ha eliminado el registro de la operación: " + this.lblOperacion.Text + " correctamente",
                                "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                dgClimatico.Rows.Clear();
                                DateTime fecha = dtPeriodo.Value;
                                int mes = fecha.Month;
                                int anno = fecha.Year;
                                string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();
                                seleccionaOperacion(periodo);
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
    }  
}
