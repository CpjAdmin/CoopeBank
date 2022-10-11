using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Datos.EntidadesAux.ComparabilidadFinanciera;
using Datos.EntidadesAux;
using System.Net.Http;
using System.Net.Http.Formatting;
using AppEscritorio.estructuras;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Logica;
using Datos;
using Datos.EntidadesAux.XMLCambioClimatico;
using Datos.EntidadesAux.XMLLegitimacion;

namespace AppEscritorio
{
    

    public static class ToolSistema
    {
        static HttpClient Cliente;
        static CapaLogica objLogica;
        public static string CreateXmlDocumentToDB<type>(List<type> dataSource, List<string> fields)
        {
            PropertyInfo[] properties = typeof(type).GetProperties();
            if (fields == null)
                fields = properties.Select(x => x.Name).ToList<string>();
            XmlDocument xml = new XmlDocument();
            XmlDeclaration dec = xml.CreateXmlDeclaration("1.0", null, null);
            XmlElement parent = xml.CreateElement("ROOT");
            xml.AppendChild(dec);
            xml.AppendChild(parent);
            parent.SetAttribute("Type", typeof(type).Name);
            int i = 1;
            foreach (type elementValue in dataSource)
            {
                XmlElement subParent = xml.CreateElement("ROW");
                subParent.SetAttribute("num", i.ToString());
                foreach (PropertyInfo pi in properties.Where(p => fields.Any(f => f == p.Name)).ToList())
                {
                    XmlElement child = xml.CreateElement(pi.Name);
                    object val = pi.GetValue(elementValue, null);
                    child.InnerText = (val == null || val.ToString() == string.Empty) ? string.Empty : val.ToString();// GetValueFormated(pi.PropertyType, pi.GetValue(elementValue, null));
                    subParent.AppendChild(child);
                }
                parent.AppendChild(subParent);
                i++;
            }
            return xml.OuterXml;
        }

        public static List<string> listadoEtiquetasProductos { get {
                return  new List<string>()
                            {
                                "CodigoProducto",
                                "TipoProducto",
                                "TipoUso",
                                "TipoGenerador",
                                "TipoCliente",
                                "NombreProducto",
                                "TipoMoneda",
                                "Plazo",
                                "Prima",
                                "TipoTasa",
                                "MontoMaximo",
                                "TasaNominal",
                                "TasaMoratoria",
                                "ObsTasa",
                                "Beneficios"
                            };
            } }
            
           

        public static List<string> listadoEtiquetasCargos { get {

                return new List<string>()
                        {
                            "CodigoProducto",
                            "CodTipoCobro",
                            "TipoCargo",
                            "ValorCargo",
                            "TipoValorCargo",
                            "ObsCargo"
                        };
            }
        }

        public static List<string> listadoEtiquetasCargos_ICFMP
        {
            get
            {

                return new List<string>()
                        {
                            "CodigoProducto",
                            "CodTipoCobro",
                            "TipoCargo",
                            "ValorCargo",
                            "TipoValorCargo",
                            "ObsCargo",
                            "TipoMonedaCargo" 
                        };
            }
        }


        public static void PrintXML(object [] pDatos)
        {

            EncabezadoXML oEncabezado = ((List<EncabezadoXML>)pDatos[2]).Select(x => x).FirstOrDefault();
            List<ProductoFinanciero> ListadoProductos = (List<ProductoFinanciero>)pDatos[3];
            List<Cargo> ListadoCargos = (List<Cargo>)pDatos[4];

            //Se dibujan la sesión de Enbacezado del XML
            string Periodo = Convert.ToDateTime(oEncabezado.Periodo).ToString("yyyy/MM/dd");

            string NomArchivo = "IndiceProductosCrediticios.xml";
            var Parametros = ConfigurationManager.AppSettings;
            string rutaXML = Parametros["rutaXMLBCCR"];
            string Directorio = rutaXML  + Path.GetFileNameWithoutExtension(NomArchivo) + "_[" + Periodo.Replace('/','_') + "]";            

            if (!Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }

            

            XmlTextWriter doc = new XmlTextWriter(Directorio+ "\\"+ NomArchivo, Encoding.UTF8);
            doc.Formatting = System.Xml.Formatting.Indented;            
            doc.WriteStartElement("ModeloICFPC");
            doc.WriteStartElement("Encabezado");                        
            doc.WriteElementString("NombreContacto", oEncabezado.NombreContacto);
            doc.WriteElementString("CorreoContacto", oEncabezado.CorreoContacto);
            doc.WriteElementString("TelContacto", oEncabezado.TelContacto);
            doc.WriteElementString("NombreArchivo", Path.GetFileNameWithoutExtension(NomArchivo));
            doc.WriteElementString("TipoPersona", oEncabezado.TipoPersona == enum_TipoPersona.Fisica ? "1" : "2");
            doc.WriteElementString("IdOferente", oEncabezado.IdOferente);
            doc.WriteElementString("Periodo", Periodo);            
            doc.WriteEndElement();
            


            //Se dibujan la sesión de Datos del XML

            doc.WriteStartElement("Datos");

            foreach (ProductoFinanciero ProdFina in ListadoProductos)
            {
                doc.WriteStartElement("Producto");
                doc.WriteElementString("TipoProducto", ProdFina.TipoProducto.ToString());
                doc.WriteElementString("TipoUso", ProdFina.TipoUso.ToString());
                doc.WriteElementString("TipoGenerador", ProdFina.TipoGenerador.ToString());
                doc.WriteElementString("TipoCliente", ProdFina.TipoCliente.ToString());
                doc.WriteElementString("NombreProducto", ProdFina.NombreProducto.Trim().ToUpper());
                doc.WriteElementString("TipoMoneda", ProdFina.TipoMoneda.ToString());
                doc.WriteElementString("Plazo", ProdFina.Plazo.ToString());
                doc.WriteElementString("Prima", ProdFina.Prima.ToString("F1",CultureInfo.InvariantCulture).Replace(',','.'));
                doc.WriteElementString("TipoTasa", ProdFina.TipoTasa.ToString());
                //doc.WriteElementString("TasaNominal", String.Format("{0:N4}", ProdFina.TasaNominal).Replace(',', '.'));
                //doc.WriteElementString("TasaMoratoria", String.Format("{0:N4}", ProdFina.TasaMoratoria).Replace(',', '.'));
                doc.WriteElementString("TasaNominal", ProdFina.TasaNominal.ToString());
                doc.WriteElementString("TasaMoratoria",ProdFina.TasaMoratoria.ToString());
                doc.WriteElementString("ObsTasa", ProdFina.ObsTasa.Trim().ToUpper());
                doc.WriteElementString("Beneficios", ProdFina.Beneficios.Trim().ToUpper());
                doc.WriteStartElement("DetalleProducto");
                foreach (Cargo ProdCarg in ListadoCargos.Where(x => x.CodigoProducto == ProdFina.CodigoProducto).ToList())
                {
                    
                    doc.WriteStartElement("Detalle");
                    doc.WriteElementString("TipoCargo", ProdCarg.TipoCargo.ToString());
                    // doc.WriteElementString("ValorCargo", String.Format("{0:N4}", ProdCarg.ValorCargo).Replace(',', '.'));
                    doc.WriteElementString("ValorCargo", ProdCarg.ValorCargo.ToString());
                    doc.WriteElementString("TipoValorCargo", ProdCarg.TipoValorCargo.ToString());
                    doc.WriteElementString("ObsCargo", ProdCarg.ObsCargo.Trim().ToUpper());
                    doc.WriteEndElement();
                    
                }
                doc.WriteEndElement();
                doc.WriteEndElement();
            }
            doc.WriteEndElement();
            doc.WriteEndElement();
            doc.Close();



        }


        public static void PrintXML_ICFMP(object[] pDatos)
        {

            //EncabezadoXML oEncabezado = ((List<EncabezadoXML>)pDatos[2]).Select(x => x).FirstOrDefault();
            EncabezadoXML oEncabezado = (EncabezadoXML)pDatos[2];
            List<MedioPago> ListadoMedios = (List<MedioPago>)pDatos[3];
            List<Cargo> ListadoCargos = (List<Cargo>)pDatos[4];

            //Se dibujan la sesión de Enbacezado del XML
            string Periodo = Convert.ToDateTime(oEncabezado.Periodo).ToString("yyyy/MM/dd");

            string NomArchivo = "IndiceMediosElectronicosPago.xml";
            var Parametros = ConfigurationManager.AppSettings;
            string rutaXML = Parametros["rutaXMLBCCR"];
            string Directorio = rutaXML + Path.GetFileNameWithoutExtension(NomArchivo) + "_[" + Periodo.Replace('/', '_') + "]";

            if (!Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }



            XmlTextWriter doc = new XmlTextWriter(Directorio + "\\" + NomArchivo, Encoding.UTF8);
            doc.Formatting = System.Xml.Formatting.Indented;
            doc.WriteStartElement("ModeloICFMP");
            doc.WriteStartElement("Encabezado");
            doc.WriteElementString("NombreContacto", oEncabezado.NombreContacto);
            doc.WriteElementString("CorreoContacto", oEncabezado.CorreoContacto);
            doc.WriteElementString("TelContacto", oEncabezado.TelContacto);
            doc.WriteElementString("NombreArchivo", Path.GetFileNameWithoutExtension(NomArchivo));
            doc.WriteElementString("TipoPersona", oEncabezado.TipoPersona == enum_TipoPersona.Fisica ? "1" : "2");
            doc.WriteElementString("IdOferente", oEncabezado.IdOferente);
            doc.WriteElementString("Periodo", Periodo);
            doc.WriteEndElement();



            //Se dibujan la sesión de Datos del XML

            doc.WriteStartElement("Datos");

            foreach (MedioPago oMedio in ListadoMedios)
            {
                doc.WriteStartElement("Medio");
                doc.WriteElementString("TipoMedio", oMedio.TipoMedio.ToString());
                doc.WriteElementString("MarcaMedio", oMedio.MarcaMedio.ToString());
                doc.WriteElementString("NombreMedio", oMedio.NombreMedio.ToString());
                doc.WriteElementString("TipoMoneda", oMedio.TipoMoneda.ToString());

                if (oMedio.TipoMedio > 1)
                {
                    //David
                    doc.WriteElementString("LineaCredito", "NA");
                    doc.WriteElementString("Plazo", "NA");
                    doc.WriteElementString("PlazoMaximo", "NA");
                    doc.WriteElementString("Lugares", "NA");
                }

                else
                {
                    doc.WriteElementString("LineaCredito", oMedio.LineaCredito.ToString("F2", CultureInfo.InvariantCulture).Replace(',', '.'));
                    doc.WriteElementString("Plazo", oMedio.Plazo.ToString());
                    doc.WriteElementString("PlazoMaximo", oMedio.PlazoMaximo.ToString());
                    doc.WriteElementString("Lugares", oMedio.Lugares.ToString());

                }
                doc.WriteElementString("Cobertura", oMedio.Cobertura.ToString());
                doc.WriteElementString("Observaciones", oMedio.Observaciones.ToString().Trim());
                doc.WriteElementString("Beneficios", oMedio.Beneficios.ToString().Trim());
                doc.WriteStartElement("DetalleMedio");
                foreach (Cargo ProdCarg in ListadoCargos.Where(x => x.CodigoProducto == Convert.ToInt32(oMedio.CodigoProducto)).ToList())
                {

                    doc.WriteStartElement("Detalle");
                    doc.WriteElementString("TipoCargo", ProdCarg.TipoCargo.ToString());
                    //   doc.WriteElementString("ValorCargo", String.Format("{0:N4}", ProdCarg.ValorCargo).Replace(',', '.'));
                    doc.WriteElementString("ValorCargo", ProdCarg.ValorCargo.ToString());
                    doc.WriteElementString("TipoValorCargo", ProdCarg.TipoValorCargo.ToString());
                    doc.WriteElementString("TipoMonedaCargo", ProdCarg.TipoMonedaCargo.ToString());
                    doc.WriteElementString("ObsCargo", ProdCarg.ObsCargo.Trim().ToUpper());
                    doc.WriteEndElement();  //Detalle

                }
                doc.WriteEndElement(); //DetalleMedio
                doc.WriteEndElement();  //Medio
            }
            doc.WriteEndElement(); //Datos
            doc.WriteEndElement(); //ModeloICFMP
            doc.Close();

        }

        public static void PrintXMLLegitimacion(string ruta, Encabezado_Legitimacion encabezado, List<DatosXMLLegitimacion> listaDatos)
        {
            //Creación del encabezado del XML

            int contador = 0;
            string NomArchivo = "Legitimacion_OperacionesEfectivo.xml";
            string rutaXML = ruta;

            Encoding utf8noBOM = new UTF8Encoding(false);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = utf8noBOM;

            settings.Indent = true;

            XmlWriter doc = XmlWriter.Create(rutaXML + "\\" + NomArchivo, settings);

            doc.WriteStartElement("ArchivoSICVECA");
            doc.WriteStartElement("Encabezado");
            doc.WriteElementString("ClaseDato", encabezado.clase);
            doc.WriteElementString("VersionClaseDato", encabezado.versionClase);
            doc.WriteElementString("Archivo", encabezado.archivo);
            doc.WriteElementString("VersionArchivo", encabezado.versionArchivo);
            doc.WriteElementString("Periodo", encabezado.Periodo);
            doc.WriteElementString("IdEntidad", encabezado.entidad);
            doc.WriteElementString("TipoCarga", encabezado.tipoCarga);
            doc.WriteElementString("TipoMoneda", encabezado.tipoMoneda);
            doc.WriteEndElement();

            //Creación de la pestaña Datos del XML

            doc.WriteStartElement("Datos");

            foreach (DatosXMLLegitimacion datos in listaDatos)
            {

                contador++;
                doc.WriteStartElement("Registro");
                doc.WriteAttributeString("id", contador.ToString());
                doc.WriteAttributeString("accion", "insertar");
                doc.WriteElementString("TipoPersona", datos.tipo_persona);
                doc.WriteElementString("IdPersona", datos.id_persona);
                doc.WriteElementString("TipoOperacion", datos.tipo_operacion);
                doc.WriteElementString("TipoEntradaSalidaFondos", datos.tipo_entrada_salida);
                doc.WriteElementString("TipoMonedaTransaccion", datos.tipo_moneda);
                doc.WriteElementString("Monto", (datos.monto).ToString());
                doc.WriteElementString("FechaTransaccion", datos.fecha);
                doc.WriteElementString("TipoTransaccion", datos.tipo_transaccion);
                doc.WriteElementString("TipoActividadEconomica", datos.tipo_actividad);
                doc.WriteElementString("OrigenFondos", datos.origen_fondos);

                doc.WriteEndElement();

            }

            doc.WriteEndElement();
            doc.WriteEndElement();
            doc.Close();
        }

        public static void PrintXMLCambioClimatico(string ruta, Encabezado encabezado, List<DatosXMLCambioClimatico> listaDatos) {

            //Creación del encabezado del XML
            
            int contador = 0;
            string NomArchivo = "DatosXMLCambioClimatico.xml";
            string rutaXML = ruta;

            Encoding utf8noBOM = new UTF8Encoding(false);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = utf8noBOM;

            settings.Indent = true;

            XmlWriter doc = XmlWriter.Create(rutaXML + "\\" + NomArchivo, settings);
            
            doc.WriteStartElement("ArchivoSICVECA");
            doc.WriteStartElement("Encabezado");
            doc.WriteElementString("ClaseDato", encabezado.clase);
            doc.WriteElementString("VersionClaseDato", encabezado.versionClase);
            doc.WriteElementString("Archivo", encabezado.archivo);
            doc.WriteElementString("VersionArchivo", encabezado.versionArchivo);
            doc.WriteElementString("Periodo", encabezado.Periodo);
            doc.WriteElementString("IdEntidad", encabezado.entidad);
            doc.WriteElementString("TipoCarga", encabezado.tipoCarga);
            doc.WriteElementString("TipoMoneda", encabezado.tipoMoneda);
            doc.WriteEndElement();

            //Creación de la pestaña Datos del XML

            doc.WriteStartElement("Datos");

            foreach (DatosXMLCambioClimatico datos in listaDatos) {

                contador++;
                doc.WriteStartElement("Registro");
                doc.WriteAttributeString("id", contador.ToString());
                doc.WriteAttributeString("accion", "insertar");
                doc.WriteElementString("Operacion", datos.operacion);
                doc.WriteElementString("Monto", datos.monto);
                doc.WriteElementString("Ambito", datos.ambito);
                doc.WriteElementString("Tema", datos.tema);
                doc.WriteElementString("SubTema", datos.subtema);
                doc.WriteElementString("Actividad", datos.actividad);
                doc.WriteElementString("Fuente", datos.fuente);
                doc.WriteElementString("TipoFuente", datos.tipofuente);
                doc.WriteElementString("Modalidad", datos.modalidad);
                
                doc.WriteEndElement();
                
            }
            
            doc.WriteEndElement();
            doc.WriteEndElement();
            doc.Close();
        }

        public static void PrintXMLProrroga(string ruta, EncabezadoXMLProrroga Encabezado, List<Prorroga> listaprorrogas)
        {
            //Se dibujan la sección de Enbacezado del XML

            int contador = 1;
            string NomArchivo = "ModificacionesCreditoCOVID19.xml";
            string rutaXML = ruta;

            Encoding utf8noBOM = new UTF8Encoding(false);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = utf8noBOM;

            settings.Indent = true;

            //XmlTextWriter doc = new XmlTextWriter(rutaXML + "\\" + NomArchivo, Encoding.UTF8);
            XmlWriter doc = XmlWriter.Create(rutaXML + "\\" + NomArchivo, settings);
            //doc.Formatting = Formatting.Indented;
            doc.WriteStartElement("ArchivoSICVECA");
            doc.WriteStartElement("Encabezado");
            doc.WriteElementString("ClaseDato", Encabezado.clase);
            doc.WriteElementString("VersionClaseDato", Encabezado.versionClase);
            doc.WriteElementString("Archivo", Encabezado.archivo);
            doc.WriteElementString("VersionArchivo", Encabezado.versionArchivo);
            doc.WriteElementString("Periodo", Encabezado.Periodo);
            doc.WriteElementString("IdEntidad", Encabezado.entidad);
            doc.WriteElementString("TipoCarga", Encabezado.tipoCarga);
            doc.WriteElementString("TipoMoneda", Encabezado.tipoMoneda);
            doc.WriteEndElement();

            //Se dibujan la sesión de Datos del XML

            doc.WriteStartElement("Datos");

            foreach (Prorroga prorroga in listaprorrogas)
            {
                //doc.WriteStartElement("Registro id=\"1\" accion=\"insertar\"");
                doc.WriteStartElement("Registro");
                doc.WriteAttributeString("id", contador.ToString());
                doc.WriteAttributeString("accion", "insertar");
                doc.WriteElementString("TipoPersonaDeudor", prorroga.tipoPersona);
                doc.WriteElementString("IdDeudor", prorroga.cedula);
                doc.WriteElementString("IdOperacion", prorroga.operacion);
                doc.WriteElementString("FechaModificacion", prorroga.fecha);
                doc.WriteElementString("TipoModificacion", prorroga.tipo);
                doc.WriteEndElement();
                contador++;
            }
            doc.WriteEndElement();
            doc.WriteEndElement();
            doc.Close();



        }


        //El Metodo IsPINEntity se encarga de retornar para una cuenta IBAN si la misma accepta PIN o no (true/false)
        public static async Task<bool> IsPINEntity(string pAccountNumber = "")
        {
            bool permitePIN = false;

            try
            {
                var Parametros = ConfigurationManager.AppSettings;
                string rutaXML = Parametros["BaseUriCGP"];

                if (pAccountNumber.Equals(string.Empty) || pAccountNumber == null)
                {
                    return false;
                }

                Cliente = new HttpClient();
                Cliente.BaseAddress = new Uri(Parametros["BaseUriCGP"]);
                Cliente.DefaultRequestHeaders.Accept.Clear();
                Cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                ReqPinEntity oReqPinEntity = new ReqPinEntity();
                oReqPinEntity.AccountNumber = pAccountNumber;
                HttpResponseMessage Respuesta = await Cliente.PostAsJsonAsync(Parametros["API_isPINEntity"], oReqPinEntity);
                var contenido = await Respuesta.Content.ReadAsStringAsync();
                ResPINEntity oResPINEntity = JsonConvert.DeserializeObject<ResPINEntity>(contenido);
                permitePIN = oResPINEntity.PINEntity;              
            }
            catch (Exception)
            {
                permitePIN = false;
            }

            return permitePIN;


        }

        //Generación de archivo formato PIN
        public static void PrintXMLPIN(string rutaArchivo, List<DestinationCustomer> ListadoDestino, string pCanal)
        {
            string directorio = Path.GetDirectoryName(rutaArchivo);
   
            XmlTextWriter doc = new XmlTextWriter(directorio.Trim()+"\\LoteTransfPIN.datos", Encoding.UTF8);
            doc.Formatting = System.Xml.Formatting.Indented;
            doc.WriteStartElement("PSXMLDOCUMENT");
            doc.WriteStartElement("HEADER");

           
            

            doc.WriteAttributeString("ChannelBatchNumber", ConsecutivoPIN("ChannelBatchNumber", pCanal));
            doc.WriteAttributeString("BatchDescription", pCanal == "PagoNomina" ? "Nomina Coopecaja" : "Pago de Proveedores");
            doc.WriteAttributeString("CoreIntegrationPoint", "");
            doc.WriteEndElement(); //HEADER
            doc.WriteStartElement("TRANSFERS");
            objLogica = new CapaLogica();
            foreach (DestinationCustomer item in ListadoDestino)
            {
                doc.WriteStartElement("TRANSFER");
                doc.WriteAttributeString("ChannelRefNumber", ConsecutivoPIN("ChannelRefNumber", pCanal));
                doc.WriteAttributeString("SinpeRefNumber", "");
                doc.WriteAttributeString("OriginEntityIBAN", "");
                doc.WriteAttributeString("Amount", String.Format("{0:N2}", item.MontoTran));
                //doc.WriteAttributeString("Amount", String.Format("{0:N2}", item.MontoTran).Replace(",", string.Empty));
                //doc.WriteAttributeString("Amount", Convert.ToDecimal(item.MontoTran));
                //Convert.ToDecimal(Monto)
                // dato.Monto = ((string)row.Cells["Monto"].Value.ToString()).Trim();


                doc.WriteAttributeString("CurrencyCode", item.CurrencyCode);
                doc.WriteAttributeString("Description", pCanal == "PagoNomina" ? "Pago de Nomina Coopecaja" : "Pago de Proveedores");
                doc.WriteAttributeString("CustomData", "");

                //El bloque <ORIGINCUSTOMER> se habla con Christian Hernandez y como el origen es Coopecaja estos datos se ponen en duro
                //importante el dato DebitIBAN el cual siempre debe estar en false
                doc.WriteStartElement("ORIGINCUSTOMER");
                doc.WriteAttributeString("Id", "3-004-045110");
                doc.WriteAttributeString("IdType", "3");
                doc.WriteAttributeString("Name", "Coopecaja R.L");
                doc.WriteAttributeString("IBAN", "CR03082001011004582682");
                doc.WriteAttributeString("DebitIBAN", "False");
                doc.WriteAttributeString("Email", "info@coopecaja.fi.cr");
                doc.WriteEndElement(); //ORIGINCUSTOMER

                //Esta ya es la información de la persona a la que se le realizará la transaferencia
                doc.WriteStartElement("DESTINATIONCUSTOMER");
                doc.WriteAttributeString("Id", item.Id);

                
                if (item.Id.ToString().Substring(0, 1) != "0" & item.Id.Replace("-", "").Trim().Length == 10)
                    //Si el largo de el id = 10 y el primer digito es > 0 se trata de una cedula juridica y el IdType debe ser = 3
                    doc.WriteAttributeString("IdType","3");
                else if (item.Id.ToString().Substring(0, 1) != "0" & item.Id.Replace("-", "").Trim().Length == 12)
                    //Si el largo de el id = 12 y el primer digito es > 0 se trata de una cedula persona fisica residente y el IdType debe ser = 1
                    doc.WriteAttributeString("IdType", "1");
                else
                    //Se deja trabajando de la misma forma que venía
                    doc.WriteAttributeString("IdType", objLogica.ObtenerAsociado(item.Id).TipoPersona == 1 ? "0" : "1");

                doc.WriteAttributeString("Name", item.Name);
                doc.WriteAttributeString("IBAN", item.IBAN);                
                doc.WriteAttributeString("Email", "");
                doc.WriteEndElement(); //DESTINATIONCUSTOMER

                doc.WriteEndElement(); //TRANSFER
            }
          
            doc.WriteEndElement(); //TRANSFERS
            doc.WriteEndElement(); //PSXMLDOCUMENT
            doc.Close();



        }

        static string ConsecutivoPIN(string IdKey, string pCanal)
        {
            objLogica = new CapaLogica();
            //Se obtiene el consecutivo de Lote
            int ConsecutivoLote = Convert.ToInt32(objLogica.ObtenerParametrosPIN().Where(x => x.IdKey == IdKey).FirstOrDefault().Valor) + 1;
            string Canal = objLogica.ObtenerParametrosPIN().Where(x => x.IdKey == pCanal).FirstOrDefault().Valor;
            objLogica.ActualizarConsecutivosPIN(IdKey, ConsecutivoLote);

            string Consecutivo = DateTime.Now.Year.ToString() +
                                 DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                 DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                 Canal +
                                 ConsecutivoLote.ToString().PadLeft(12, '0');

            return Consecutivo;

        }


      

    }

}
