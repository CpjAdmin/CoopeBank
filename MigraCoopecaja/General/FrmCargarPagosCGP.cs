using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using AppEscritorio.estructuras;
using Logica;
using Datos;



namespace AppEscritorio.General
{



    public partial class FrmCargarPagosCGP : Form
    {
        #region "Propiedades"
        CapaLogica objLogica;
        List<datosXmlNominas> datosList = new List<datosXmlNominas>();
        private List<ParametrosArcCGP> ListarParametrosArc;
        private string IdNegocio = "";
        private string NomNegocio = "";
        private string CodMoneda = "";
        private string CuentaClienteOrigen = "";
        private string serResul = "";
        private string CodServicio = "" ;
        System.Data.DataTable dt;
        List<DestinationCustomer> ListadoCuentasIBANPIN;

        #endregion

        #region "Metodos"
        //Metodo para consultar los tipos de servicio sinpe
        private void ConsultarTipoServSinpe()
        {
            try
            {
                objLogica = new CapaLogica();
                cmbTiposServSinpe.DisplayMember = "DescServicio";
                cmbTiposServSinpe.ValueMember = "codServicio";
                cmbTiposServSinpe.DataSource = objLogica.ConsultarTipoServicioSinpe().ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para actualizar los consecutivos del archivo
        private void actualizarParametrosCGP()
        {
            try
            {
                ParametrosArcCGP param = new ParametrosArcCGP();

                // param.CodServicio = Convert.ToInt32(cmbTiposServSinpe.SelectedValue.ToString());
                param.FecGeneracion = DateTime.Now;
                param.IdConsecutivo = Convert.ToInt32(txtConsecutivo.Text);
                param.IdNumEnvio = Convert.ToInt32(txtNumEnvio.Text);
                param.FecModificacion = DateTime.Now;
                objLogica.ModificarParametroCGP(param);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar parametros" + ex.Message.ToString());
            }



        }

        //Metodo para guardar los datos en la tabla de pagos
        private void registrarDatosPago(string IdDestino, string TitularServicio, string CuentaClienteDestino, decimal Monto)
        {
            try
            {
                CargaPagosCGP param = new CargaPagosCGP();


                param.IdDestino = IdDestino;
                param.TitularServicio = TitularServicio;
                param.CuentaClienteDestino = CuentaClienteDestino;
                param.Monto = Monto;
                param.IdUsuario = Environment.UserName;
                objLogica.RegistroTablaPago(param);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar los datos" + ex.Message.ToString());
            }
        }


        //Metodo para consultar los datos de la nomina
        private void ConsultaDatosPago(string tipoMoneda)
        {
            try
            {
                objLogica = new CapaLogica();
                dtDatos.DataSource = objLogica.consultarPagosCGP(tipoMoneda);
                
                this.dtDatos.Columns["Monto"].DefaultCellStyle.Format = "#,0.00;- #,0.00;'0.00'";


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        //Metodo para eliminar los datos ya generados del xml de la tabla machaves
        private void EliminarInfoPagoCGP()
        {
            try
            {

                //foreach (DataGridViewRow row in dtDatos.Rows)
                //{
                CargaPagosCGP objCGP = new CargaPagosCGP();
                objCGP.IdUsuario = "machaves";//Environment.UserName;
                objLogica = new CapaLogica();
                objLogica.EliminarDatosPagoCGP(objCGP);
                //}


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        #endregion

        public FrmCargarPagosCGP()
        {
            InitializeComponent();
        }

        private void FrmCargarPagosCGP_Load(object sender, EventArgs e)
        {
            try
            {


                objLogica = new CapaLogica();
                ListarParametrosArc = objLogica.ConsultarParametrosArcCGP();
                //txtDetallePago.Text = "PAGOS CGP";

                //Mostrar los consecutivos del archivo   
                foreach (var item in ListarParametrosArc)
                {
                    txtNumEnvio.Text = (item.IdNumEnvio + 1).ToString();
                    txtConsecutivo.Text = (item.IdConsecutivo + 1).ToString();
                    txtCodEntidad.Text = item.CodEntidad.ToString();
                    IdNegocio = item.IdNegocio.ToString();
                    NomNegocio = item.NomNegocio.ToString();
                    // CodMoneda = item.CodMoneda.ToString();
                    // CuentaClienteOrigen = item.CuentaClienteOrigen.ToString();
                }


                //Cargamos los tipos de servicio que existen
                ConsultarTipoServSinpe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la pantalla " + ex.Message.ToString());
            }
        }



        private void btnCargar_Click(object sender, EventArgs e)
        {

            if (rbDolares.Checked == true || rbColones.Checked == true)
            {


                pbAvance.Value = 0;
                string archivo = "";   //localizacion del archivo Excel
                dt = new System.Data.DataTable();  //datatable que contendra los datos del Excel                
                DataRow fila;
                DialogResult result = openFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    archivo = openFile.FileName; //buscamos el nombre del archivo a cargar
                    txtCargaArc.Text = archivo.ToString();
                    try
                    {
                        //creamos los objetos de Microsoft.Office.Interop.Excel que usaremos para leer el archivo

                        Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(archivo);
                        Microsoft.Office.Interop.Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                        Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;


                        int filaConta = excelRange.Rows.Count;  //obtenemos la cantidad de filas del archivo

                        int colConta = excelRange.Columns.Count; // Obtenemos la cantidad de columnas del archivo

                        //Obtenemos la primera columna del excel  
                        pbAvance.Maximum = filaConta;

                        //for (int i = 1; i <= filaConta; i++)
                        //{
                        //    for (int j = 1; j <= colConta; j++)
                        //    {
                        //        dt.Columns.Add(excelRange.Cells[i, j].Value2.ToString());
                        //    }
                        //    break;
                        //}

                        for (int j = 1; j <= colConta; j++)
                        {
                            dt.Columns.Add(excelRange.Cells[1, j].Value2.ToString());
                        }


                        //Carlos G. Se tiene que eliminar la tabla antes de cargarla ya que usuarios paralelo traen registros que no competen
                        EliminarInfoPagoCGP();

                        //Obtengo los datos de las filas             
                        int contadorFilas;  //numero de index
                        for (int i = 2; i <= filaConta; i++) //Loop for available row of excel data
                        {
                            fila = dt.NewRow();  //asignamos nuevas filas al datatable
                            contadorFilas = 0;
                            for (int j = 1; j <= colConta; j++) //Loop for available column of excel data
                            {
                                //ver si la celda esta vacio
                                if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
                                {
                                    fila[contadorFilas] = excelRange.Cells[i, j].Value2.ToString();
                                }
                                else
                                {
                                    fila[i] = "";
                                }

                                
                                contadorFilas++;

                            }
                            dt.Rows.Add(fila); //add fila al datatable

                            string IdDestino = fila[0].ToString().Trim();
                            string TitularServicio = fila[1].ToString().Trim();
                            string CuentaClienteDestino = fila[2].ToString().Trim();
                            string Monto = fila[3].ToString().Trim();
                            registrarDatosPago(IdDestino, TitularServicio, CuentaClienteDestino, Convert.ToDecimal(Monto));




                            pbAvance.Value += 1;
                            lbContador.Text = pbAvance.Value.ToString();

                        }

                        //Se incorpora dentro del primer ciclo el registo
                        //foreach (DataRow rows in dt.Rows)
                        //{

                        //    string IdDestino = rows[0].ToString();
                        //    string TitularServicio = rows[1].ToString();
                        //    string CuentaClienteDestino = rows[2].ToString();
                        //    string Monto = rows[3].ToString();
                        //    registrarDatosPago(IdDestino, TitularServicio, CuentaClienteDestino, Convert.ToDecimal(Monto));

                        //}

                        
                     


                        if (rbColones.Checked == true)
                        {
                            ConsultaDatosPago("COL");

                        }
                        else if (rbDolares.Checked == true)
                        {
                            ConsultaDatosPago("DOL");
                        }



                        


                        pbAvance.Maximum = dt.Rows.Count;
                        dtDatos.AllowUserToAddRows = false;

                        //cerramos y limpiamos los procesos de Excel
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        Marshal.ReleaseComObject(excelRange);
                        Marshal.ReleaseComObject(excelWorksheet);
                        excelWorkbook.Close();
                        Marshal.ReleaseComObject(excelWorkbook);

                        //cerramos  
                        excelApp.Quit();
                        Marshal.ReleaseComObject(excelApp);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            } //if validar moneda
            else
            {
                MessageBox.Show("Debe de elegir el tipo de moneda a utilizar para la generación.");
            } //fin if validacion 

        }


        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                CodServicio = cmbTiposServSinpe.SelectedValue.ToString();
                if (txtDetallePago.TextLength > 50 || txtDetallePago.TextLength <= 15)
                {
                    MessageBox.Show("La descripción del pago debe ser mayor a 15 caracteres o menor a 50 caracteres, por favor validar.");
                }
                // verificamos que hayan datos para exportar
                else if (dtDatos.Rows.Count <= 0)
                {
                    MessageBox.Show("No existen datos para generar, favor revisar los parametros ingresados.");
                }
                else
                {
                    saveFile.Filter = "Xml files (*.xml)|*.xml";
                    saveFile.FilterIndex = 2;

                    saveFile.FileName = "TransaccionCGP";
                    saveFile.Title = "Exportar archivo";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        //Se inicializa la colección que va a tener las cuentas IBAN que permiten PIN
                        ListadoCuentasIBANPIN = new List<DestinationCustomer>();

                        foreach (DataGridViewRow row in dtDatos.Rows)                        
                        {
                            bool permitePIN = false;

                            string servicio = (string)row.Cells["Servicio"].Value;
                            string negocio = (string)row.Cells["IdNegocio"].Value;
                            if (Convert.ToInt16(cmbTiposServSinpe.SelectedValue.ToString()) == 24)
                            {
                                serResul = negocio.Replace("-", "");
                            }
                            else
                            {
                                serResul = servicio;
                            }

                            datosXmlNominas dato = new datosXmlNominas();
                            dato.CodMoneda = ((string)Convert.ToString(row.Cells["CodMoneda"].Value)).Trim();
                            dato.Servicio = ((string)row.Cells["IdDestino"].Value).Replace("-", "").Trim(); //Lo modifico cgonzalez ya que para el tipo de cobro que ahori se puede hacer y la domiciliacion que se esta haciendo Servicio debe ser mismo IDDESTINO //serResul;// si es codigo  24 DTR se pone cedula de coopecaja segun nueva actualizacion de CGP 
                            //dato.IdNegocio = ((string)row.Cells["IdNegocio"].Value).Trim();
                            dato.IdNegocio = ((string)row.Cells["IdDestino"].Value).Trim();
                            dato.NomNegocio = ((string)row.Cells["NomNegocio"].Value).Trim();
                            objLogica = new CapaLogica();
                            string CuentaOrigen = objLogica.ConsultarCuentaClienteProducto(((string)row.Cells["IdDestino"].Value).Replace("-", "").Trim());
                            //dato.CuentaClienteOrigen = ((string)row.Cells["CuentaClienteOrigen"].Value).Trim();
                            dato.CuentaClienteOrigen = CuentaOrigen;
                            dato.IdDestino = ((string)row.Cells["IdDestino"].Value).Trim();
                            string TitularServicio = row.Cells["TitularServicio"].Value.ToString().Trim();
                            if (TitularServicio.Length > 24)
                            {
                                TitularServicio = TitularServicio.Substring(0, 23);
                            }
                            dato.TitularServicio = TitularServicio;
                            dato.CuentaClienteDestino = ((string)row.Cells["CuentaClienteDestino"].Value).Trim();
                            dato.Monto = ((string)row.Cells["Monto"].Value.ToString()).Trim();
                            dato.DesGeneral = ((string)txtDetallePago.Text).Trim();

                            //Se valida que la cuenta sea cuenta IBAN (22 digitos)
                            if (dato.CuentaClienteDestino.Length == 22  && CodServicio == "21")
                            {
                                double Monto = Convert.ToDouble(row.Cells["Monto"].Value);
                                //Si la cuenta IBAN no es de Costa Rica se asume que es para transaccion tipo PIN
                                if (!dato.CuentaClienteDestino.Substring(0, 2).Equals("CR"))
                                {
                                    ListadoCuentasIBANPIN.Add(new DestinationCustomer() { Id = dato.IdDestino, IBAN = dato.CuentaClienteDestino, MontoTran = Monto, Name = dato.TitularServicio });
                                    continue; //Se itera en el otro elemento del ciclo para no permitir que registre en datosList
                                }
                                else
                                {
                                    //Se valida contra el webServices de CGP que determina si una cuenta IBAN permite o no pagarse por PIN
                                    permitePIN = await ToolSistema.IsPINEntity(dato.CuentaClienteDestino);

                                    //Si la cuenta IBAN permite PIN entonces se agrega a la lista que permitira generar un archivo
                                    //en formato PIN de estas cuentas y se excluye del formato de archivo TFT
                                    if (permitePIN)
                                    {
                                        ListadoCuentasIBANPIN.Add(new DestinationCustomer() { Id = dato.IdDestino, IBAN = dato.CuentaClienteDestino, MontoTran = Monto, Name = dato.TitularServicio, CurrencyCode = dato.CodMoneda == "1" ? "CRC" : "USD" });            
                                        continue; //Se itera en el otro elemento del ciclo para no permitir que registre en datosList
                                    }

                                }
                            }

                            datosList.Add(dato);
                        }

                        //Si la lista ListadoCuentasIBANPIN entonces se crea el archivo en formato PIN
                        if (ListadoCuentasIBANPIN.Count > 0)
                        {
                            ToolSistema.PrintXMLPIN(this.saveFile.FileName, ListadoCuentasIBANPIN, "PagoProveedores");
                        }

                        using (XmlTextWriter Writer = new XmlTextWriter(this.saveFile.FileName, Encoding.UTF8))
                        {
                            int contadorRows = 0;// contador de número de registros para pago
                            decimal montoTotal = 0;//monto total a pagar
                            //Declaración inicial del Xml.
                            Writer.WriteStartDocument();

                            ////Configuración.
                            Writer.Formatting = Formatting.Indented;
                            Writer.Indentation = 3;

                            //Escribimos el nodo principal.
                            Writer.WriteStartElement("SINPEDOCUMENTOXML");

                            //Inicio del encabezado
                            Writer.WriteStartElement("ENCABEZADO");

                            //Inicio del elemento CICLO
                            Writer.WriteStartElement("CICLO");
                            Writer.WriteAttributeString("Fecha", DateTime.Now.ToString("yyyy-MM-dd"));
                            Writer.WriteAttributeString("CodServicio", cmbTiposServSinpe.SelectedValue.ToString());
                            Writer.WriteAttributeString("NumeroEnvio", txtNumEnvio.Text);
                            Writer.WriteAttributeString("EstadoTransacciones", "Todos");
                            Writer.WriteEndElement();
                            //Fin Elemento CICLO 

                            //Inicio del elemento ENTIDAD
                            Writer.WriteStartElement("ENTIDAD");
                            Writer.WriteAttributeString("CodEntidad", txtCodEntidad.Text);
                            Writer.WriteAttributeString("Consecutivo", txtConsecutivo.Text);
                            Writer.WriteEndElement();
                            //Fin Elemento ENTIDAD 

                            Writer.WriteEndElement();  //Fin del Encabezado

                            //codigo 24 se cambia la etiqueta por DEBITOS segun nueva actualizacion CGP
                            if (Convert.ToInt16(cmbTiposServSinpe.SelectedValue.ToString()) == 24)
                            {
                                //Escribimos el nodo secundario Creditos. para DTR
                                Writer.WriteStartElement("DEBITOS");
                            }
                            else
                            {
                                //Escribimos el nodo secundario Creditos. para pagos  TFT
                                Writer.WriteStartElement("CREDITOS");
                            }


                            foreach (datosXmlNominas item in datosList)
                            {
                                decimal montoNeto = Convert.ToDecimal(item.Monto.ToString());
                                string monNeto = montoNeto.ToString("#,0.00;- #,0.00;'0.00'");

                                //codigo 24 se cambia la etiqueta por DEBITOS segun nueva actualizacion CGP
                                if (Convert.ToInt16(cmbTiposServSinpe.SelectedValue.ToString()) == 24)
                                {
                                    //Escribimos el nodo secundario Creditos. para DTR
                                    //Inicio del elemento DEBITO
                                    Writer.WriteStartElement("DEBITO");
                                }
                                else
                                {
                                    //Escribimos el nodo secundario Creditos. para pagos  TFT
                                    //Inicio del elemento CREDITO
                                    Writer.WriteStartElement("CREDITO");
                                }


                                Writer.WriteAttributeString("CodMoneda", item.CodMoneda.ToString());

                                Writer.WriteAttributeString("Servicio", item.Servicio.ToString());

                                Writer.WriteAttributeString("IdNegocio", item.IdNegocio.ToString());
                                Writer.WriteAttributeString("NomNegocio", item.NomNegocio.ToString());
                                Writer.WriteAttributeString("CuentaClienteOrigen", item.CuentaClienteOrigen.ToString());
                                Writer.WriteAttributeString("IdDestino", item.IdDestino.ToString());
                                Writer.WriteAttributeString("TitularServicio", item.TitularServicio.ToString());
                                Writer.WriteAttributeString("CuentaClienteDestino", item.CuentaClienteDestino.ToString());
                                Writer.WriteAttributeString("Monto", monNeto);
                                //Writer.WriteAttributeString("DesGeneral", item.DesGeneral.ToString());
                                Writer.WriteAttributeString("DesGeneral", txtDetallePago.Text);
                                Writer.WriteEndElement();
                                //Fin Elemento CREDITO 


                                contadorRows++;
                                montoTotal = montoTotal + montoNeto;
                            }

                            //Inicio del RESUMEN
                            Writer.WriteStartElement("RESUMEN");
                            Writer.WriteAttributeString("CantidadDatos", contadorRows.ToString());
                            Writer.WriteAttributeString("SumatoriaMontos", montoTotal.ToString("#,0.00;- #,0.00;'0.00'"));
                            Writer.WriteEndElement();
                            //Fin del RESUMEN
                            datosList.Clear();
                        }

                    }
                    MessageBox.Show("Archivo generado correctamente en " + this.saveFile.FileName.ToString());
                    datosList.Clear();

                    // actualizamos el consecutivo del siguiente archivo 
                    actualizarParametrosCGP();
                    //eliminamos los datos de el archivo generado
                    EliminarInfoPagoCGP();

                }//fin if else





            } //fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el archivo" + ex.Message.ToString());
            }//fin catch


        }

        private void dtDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarInfoPagoCGP();
        }

        private void txtDetallePago_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dtDatos.Rows.Count.ToString());
            MessageBox.Show(dt.Rows.Count.ToString());
            
        }

        private void cmbTiposServSinpe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
