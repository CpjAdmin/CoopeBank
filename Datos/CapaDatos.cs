using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Types;
using Datos.EntidadesAux;
using System.IO;
using System.Globalization;
using Datos.EntidadesAux.ComparabilidadFinanciera;
using Datos.EntidadesAux.XMLCambioClimatico;
using Datos.EntidadesAux.CategoriaComercial;

namespace Datos
{
    public class CapaDatos
    {

        OracleCommand cmd;
        OracleConnection conn;
        string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;
        

        //OracleTransaction transaction;

        #region "MetodosOracle"


        #region "XML Competencia Financiera"

        public void MetodoA(string pxml)
        {
            using (OracleConnection conn = new OracleConnection(cadena))
            {
                using (OracleCommand cmd = new OracleCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.METODOA";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new OracleParameter("cargos", OracleDbType.Clob, pxml, ParameterDirection.Input));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }


        public object [] Gen_XML_Comparabilidad_BCCR(object [] DatosEncabezado,string pXML_ListaProductos,string pXML_ListaCargos)
        {

            int pID_XML = -1; //XML no generado
            string PDESERROR = string.Empty;
            OracleDataReader dr;
            List<EncabezadoXML> ListadoEncabezado = new List<EncabezadoXML>();
            List<ProductoFinanciero> ListadoProductos = new List<ProductoFinanciero>();
            List<Cargo> ListadoCargos = new List<Cargo>();

            try
            {
                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.GEN_XML_COMPARABILIDAD_BCCR";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("pPERIODO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[5]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pCODARCHIVO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[6]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pNOMBRECONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[0]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pCORREOCONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[1]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pNOMBREARCHIVO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[2]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pTIPOPERSONA", OracleDbType.Int32, Convert.ToInt32(DatosEncabezado[3]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pTELCONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[4]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pIDOFERENTE", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[7]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pLISTAPRODUCTOS", OracleDbType.Clob, pXML_ListaProductos, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pLISTACARGOS", OracleDbType.Clob, pXML_ListaCargos, ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pID_XML", OracleDbType.Int32, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("PDESERROR", OracleDbType.Varchar2, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("REF_CURENCA", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("REF_CURDETA", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("REF_CURCARGOS", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));



                        conn.Open();
                        dr = cmd.ExecuteReader();
                        Console.WriteLine("--ENCABEZADO");
                        
                        while (dr.Read())
                        {
                            EncabezadoXML objEnca = new EncabezadoXML();
                            objEnca.IdEncabezado = dr.GetInt32(0);
                            objEnca.Periodo = dr.GetDateTime(1).ToString("dd/MM/yyyy");
                            objEnca.CodArchivo = dr.GetString(2) == "ICFPC" ? enum_TipoArchivo.ICFPC : enum_TipoArchivo.ICFMP;
                            objEnca.NombreContacto = dr.GetString(3);
                            objEnca.CorreoContacto = dr.GetString(4);
                            objEnca.TelContacto = dr.GetString(5);
                            objEnca.NombreArchivo = dr.GetString(6);
                            objEnca.TipoPersona = dr.GetInt32(7) == 1 ? enum_TipoPersona.Fisica : enum_TipoPersona.Juridica;
                            objEnca.IdOferente = dr.GetString(8);
                            ListadoEncabezado.Add(objEnca);


                        }

                        dr.NextResult();

                        Console.WriteLine("--PRODUCTOS");
                        
                        while (dr.Read())
                        {
                            ProductoFinanciero objProducto = new ProductoFinanciero();
                            objProducto.CodigoProducto = Convert.ToInt32(dr.GetString(1));
                            objProducto.TipoProducto = dr.GetInt32(2);
                            objProducto.TipoUso = dr.GetInt32(3);
                            objProducto.TipoGenerador = dr.GetInt32(4);
                            objProducto.TipoCliente = dr.GetInt32(5);
                            objProducto.NombreProducto = dr.GetString(6);
                            objProducto.TipoMoneda = dr.GetInt32(7);
                            objProducto.Plazo = dr.GetInt32(8);
                            objProducto.Prima = dr.GetDouble(9);
                            objProducto.TipoTasa = dr.GetInt32(10);
                            objProducto.MontoMaximo = dr.GetDouble(11);
                            objProducto.TasaNominal = dr.GetDouble(12);
                            objProducto.TasaMoratoria = dr.GetDouble(13);
                            objProducto.ObsTasa = dr.GetString(14);
                            objProducto.Beneficios = dr.GetString(15);
                            objProducto.ListadoCargos = null;
                            ListadoProductos.Add(objProducto);
                        }

                        dr.NextResult();
                        Console.WriteLine("--CARGOS");
                        
                        while (dr.Read())
                        {
                            Cargo objCargo = new Cargo();
                            objCargo.CodigoProducto = Convert.ToInt32(dr.GetString(1));
                            objCargo.TipoCargo = dr.GetInt32(2);
                            objCargo.ValorCargo = dr.GetDouble(3);
                            objCargo.TipoValorCargo = dr.GetInt32(4);
                            objCargo.ObsCargo = dr.GetString(5);
                            ListadoCargos.Add(objCargo);
                        }

                        pID_XML = Convert.ToInt32(cmd.Parameters["pID_XML"].Value.ToString());
                        PDESERROR = cmd.Parameters["PDESERROR"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                PDESERROR += " " + ex.Message;

            }

            object[] Respuesta =
            {
                pID_XML,
                PDESERROR,
                ListadoEncabezado,
                ListadoProductos,
                ListadoCargos
            };

            return Respuesta;
        }


        public object[] Gen_XML_ICFMP_BCCR(object[] DatosEncabezado)
        {

            int pID_XML = -1; //XML no generado
            string PDESERROR = string.Empty;           
           
            try
            {
                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.GEN_XML_ICFMP_BCCR";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("pPERIODO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[5]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pCODARCHIVO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[6]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pNOMBRECONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[0]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pCORREOCONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[1]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pNOMBREARCHIVO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[2]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pTIPOPERSONA", OracleDbType.Int32, Convert.ToInt32(DatosEncabezado[3]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pTELCONTACTO", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[4]), ParameterDirection.Input));
                        cmd.Parameters.Add(new OracleParameter("pIDOFERENTE", OracleDbType.Varchar2, Convert.ToString(DatosEncabezado[7]), ParameterDirection.Input));                        
                        cmd.Parameters.Add(new OracleParameter("pID_XML", OracleDbType.Int32, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("PDESERROR", OracleDbType.Varchar2, ParameterDirection.Output));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        
                        pID_XML = Convert.ToInt32(cmd.Parameters["pID_XML"].Value.ToString());
                        PDESERROR = cmd.Parameters["PDESERROR"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                PDESERROR += " " + ex.Message;

            }

            object[] Respuesta =
            {
                pID_XML,
                PDESERROR               
            };

            return Respuesta;
        }
        //Consultar tipos de creditos
        public List<ProductoFinanciero> Obtener_ProductosFinancieros()
        {
            try
            {
                
                OracleDataReader dr;
                List<ProductoFinanciero> ListadoProductosFinancieros;

                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERTIPOSPRESTAMO";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("ref_tiposp", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));                        
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        ListadoProductosFinancieros = new List<ProductoFinanciero>();
                        while (dr.Read())
                        {
                            ProductoFinanciero obProductoFina = new ProductoFinanciero();
                            obProductoFina.CodigoProducto = dr.GetInt32(0);
                            obProductoFina.TipoProducto = dr.GetInt32(1);
                            obProductoFina.TipoUso = dr.GetInt32(2);
                            obProductoFina.TipoGenerador = dr.GetInt32(3);
                            obProductoFina.TipoCliente = dr.GetInt32(4);
                            obProductoFina.NombreProducto = dr.GetString(5);
                            obProductoFina.TipoMoneda = dr.GetInt32(6);
                            obProductoFina.Plazo = dr.GetInt32(7);
                            obProductoFina.Prima = dr.GetDouble(8);
                            obProductoFina.TipoTasa = dr.GetInt32(9);
                            obProductoFina.MontoMaximo = dr.GetDouble(10);
                            obProductoFina.TasaNominal = dr.GetDouble(11);
                            obProductoFina.TasaMoratoria = dr.GetDouble(12);
                            obProductoFina.ObsTasa = dr.GetString(13);
                            obProductoFina.Beneficios = dr.GetString(14);
                            ListadoProductosFinancieros.Add(obProductoFina);
                        }
                        dr.Close();
                    }
                    conn.Close();                    
                }

                return ListadoProductosFinancieros;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<Cargo> Obtener_CargosProductos()
        {
            try
            {

                OracleDataReader dr;
                List<Cargo> ListadoCargosProducto;

                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERCARGOSPRESTAMO";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("ref_tiposp", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        ListadoCargosProducto = new List<Cargo>();
                        while (dr.Read())
                        {
                            Cargo obCargo = new Cargo();
                            obCargo.TipoCargo = dr.GetInt32(0);
                            obCargo.ValorCargo = dr.GetDouble(1);
                            obCargo.TipoValorCargo = dr.GetInt32(2);
                            obCargo.ObsCargo = dr.GetString(3);
                            obCargo.CodigoProducto = dr.GetInt32(4);
                            obCargo.CodTipoCobro = dr.GetString(5);
                            ListadoCargosProducto.Add(obCargo);
                        }
                        dr.Close();
                    }
                    conn.Close();
                }

                return ListadoCargosProducto;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<EncabezadoXML> Obtener_EncabezadoXML()
        {
            try
            {

                OracleDataReader dr;
                List<EncabezadoXML> ListaEncabezadoXML;

                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERENCABEZADOXML";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("ref_Enca", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        ListaEncabezadoXML = new List<EncabezadoXML>();
                        while (dr.Read())
                        {
                            EncabezadoXML obEnca = new EncabezadoXML();
                            obEnca.IdEncabezado = dr.GetInt32(0);
                            obEnca.Periodo = Convert.ToString(dr.GetDateTime(1));
                            obEnca.CodArchivo = dr.GetString(2) == "ICFPC" ? enum_TipoArchivo.ICFPC : enum_TipoArchivo.ICFMP;
                            obEnca.NombreContacto = dr.GetString(3);
                            obEnca.CorreoContacto = dr.GetString(4);
                            obEnca.TelContacto = dr.GetString(5);
                            obEnca.NombreArchivo = dr.GetString(6);
                            obEnca.TipoPersona = dr.GetInt32(7) == 1 ? enum_TipoPersona.Fisica : enum_TipoPersona.Juridica;
                            obEnca.IdOferente = dr.GetString(8);
                            ListaEncabezadoXML.Add(obEnca);
                        }
                        dr.Close();
                    }
                    conn.Close();
                }

                return ListaEncabezadoXML;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public object[] Obtener_DatosMediosPago()
        {

            string PDESERROR = string.Empty;
            OracleDataReader dr;
            List<MedioPago> ListadoMediosPago = new List<MedioPago>();
            List<Cargo> ListadoCargosMedio = new List<Cargo>();

            try
            {
                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERDATOSMEDIOS";
                        cmd.CommandType = CommandType.StoredProcedure;                        
                        cmd.Parameters.Add(new OracleParameter("REF_CURMEDIO", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        cmd.Parameters.Add(new OracleParameter("REF_CURCARGOS", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        cmd.Parameters.Add("PDESERROR", OracleDbType.Varchar2, 1000, "E", ParameterDirection.InputOutput);
                        conn.Open();
                        dr = cmd.ExecuteReader();

                        //SE OBTINE LA LISTA DE MEDIOS COMPLETA
                        ListadoMediosPago = new List<MedioPago>();
                        while (dr.Read())
                        {
                            MedioPago oMedioPago = new MedioPago();
                            oMedioPago.CodigoProducto = dr.GetString(0).Substring(1);   //Por ejemplo el codigo es M10, solo nos llevamos el 10
                            oMedioPago.TipoMedio = dr.GetInt32(1);
                            oMedioPago.MarcaMedio = dr.GetString(2);
                            oMedioPago.NombreMedio = dr.GetString(3);
                            oMedioPago.TipoMoneda = dr.GetInt32(4);
                            oMedioPago.LineaCredito = dr.GetDouble(5);
                            oMedioPago.Plazo = dr.GetInt32(6);
                            oMedioPago.PlazoMaximo = dr.GetInt32(7);
                            oMedioPago.Lugares = dr.GetInt32(8);
                            oMedioPago.Cobertura = dr.GetInt32(9);
                            oMedioPago.Observaciones = dr.GetString(10);
                            oMedioPago.Beneficios = dr.GetString(11);
                            ListadoMediosPago.Add(oMedioPago);
                        }


                        //SE OBTIENE LA LISTA DE CARGOS COMPLETA
                        dr.NextResult();
                        ListadoCargosMedio = new List<Cargo>();
                        while (dr.Read())
                        {
                            Cargo objCargo = new Cargo();
                            objCargo.CodigoProducto = Convert.ToInt32(dr.GetString(0).Substring(1)); //Por ejemplo el codigo es M10, solo nos llevamos el 10
                            objCargo.CodTipoCobro = dr.GetString(1);
                            objCargo.TipoCargo = dr.GetInt32(2);
                            objCargo.ValorCargo = dr.GetDouble(3);
                            objCargo.TipoValorCargo = dr.GetInt32(4);
                            objCargo.ObsCargo = dr.GetString(5);
                            objCargo.TipoMonedaCargo = dr.GetInt32(6);
                            ListadoCargosMedio.Add(objCargo);
                        }
                        
                        PDESERROR = cmd.Parameters["PDESERROR"].Value.ToString();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                PDESERROR += " " + ex.Message;

            }

            object[] Respuesta =
            {               
                PDESERROR,
                ListadoMediosPago,
                ListadoCargosMedio                
            };

            return Respuesta;
        }

        public object[] Registrar_MedioPago(MedioPago oMedioPago)
        {

            int pID_XML = -1; //Registro de nuevo medio
            string PDESERROR = string.Empty;

            try
            {
                               

                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.REGISTRARMEDIOELECTRONICO";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("pPERIODO", OracleDbType.Varchar2, "01/01/1900", ParameterDirection.Input));
                        cmd.Parameters.Add("pCODIGOPRODUCTO", OracleDbType.Varchar2).Value = oMedioPago.CodigoProducto;
                        cmd.Parameters.Add("pTIPOMEDIO", OracleDbType.Int32).Value = oMedioPago.TipoMedio;
                        cmd.Parameters.Add("pMARCAMEDIO", OracleDbType.Varchar2).Value = oMedioPago.MarcaMedio;
                        cmd.Parameters.Add("pNOMBREMEDIO", OracleDbType.Varchar2).Value = oMedioPago.NombreMedio;
                        cmd.Parameters.Add("pTIPOMONEDA", OracleDbType.Int32).Value = oMedioPago.TipoMoneda;
                        cmd.Parameters.Add("pLINEACREDITO", OracleDbType.Double).Value = oMedioPago.LineaCredito;
                        cmd.Parameters.Add("pPLAZO", OracleDbType.Int32).Value = oMedioPago.Plazo;
                        cmd.Parameters.Add("pPLAZOMAXIMO", OracleDbType.Int32).Value = oMedioPago.PlazoMaximo;
                        cmd.Parameters.Add("pLUGARES", OracleDbType.Int32).Value = oMedioPago.Lugares;
                        cmd.Parameters.Add("pCOBERTURA", OracleDbType.Int32).Value = oMedioPago.Cobertura;
                        cmd.Parameters.Add("pOBSERVACIONES", OracleDbType.Varchar2).Value = oMedioPago.Observaciones;
                        cmd.Parameters.Add("pBENEFICIOS", OracleDbType.Varchar2).Value = oMedioPago.Beneficios;
                        cmd.Parameters.Add(new OracleParameter("pLISTACARGOS", OracleDbType.Clob, oMedioPago.pXML_ListaCargos, ParameterDirection.Input));
                        cmd.Parameters.Add("pID_XML", OracleDbType.Int32,ParameterDirection.InputOutput).Value = pID_XML;
                        cmd.Parameters.Add("pDESERROR", OracleDbType.Varchar2, 1000, "E", ParameterDirection.InputOutput);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        pID_XML = Convert.ToInt32(cmd.Parameters["pID_XML"].Value.ToString());
                        PDESERROR = cmd.Parameters["PDESERROR"].Value.ToString();
                    }
                    conn.Close();
                }

                
            }
            catch (Exception ex)
            {

                PDESERROR += " " + ex.Message;

            }

            object[] Respuesta =
            {
                pID_XML,
                PDESERROR               
            };

            return Respuesta;

        }


        public object[] Modificar_MedioPago(MedioPago oMedioPago)
        {

            int pID_XML = -1; //Registro de nuevo medio
            string PDESERROR = string.Empty;

            try
            {


                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.MODIFICARMEDIOELECTRONICO";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new OracleParameter("pPERIODO", OracleDbType.Varchar2, "01/01/1900", ParameterDirection.Input));
                        cmd.Parameters.Add("pCODIGOPRODUCTO", OracleDbType.Varchar2).Value = oMedioPago.CodigoProducto;
                        cmd.Parameters.Add("pTIPOMEDIO", OracleDbType.Int32).Value = oMedioPago.TipoMedio;
                        cmd.Parameters.Add("pMARCAMEDIO", OracleDbType.Varchar2).Value = oMedioPago.MarcaMedio;
                        cmd.Parameters.Add("pNOMBREMEDIO", OracleDbType.Varchar2).Value = oMedioPago.NombreMedio;
                        cmd.Parameters.Add("pTIPOMONEDA", OracleDbType.Int32).Value = oMedioPago.TipoMoneda;
                        cmd.Parameters.Add("pLINEACREDITO", OracleDbType.Double).Value = oMedioPago.LineaCredito;
                        cmd.Parameters.Add("pPLAZO", OracleDbType.Int32).Value = oMedioPago.Plazo;
                        cmd.Parameters.Add("pPLAZOMAXIMO", OracleDbType.Int32).Value = oMedioPago.PlazoMaximo;
                        cmd.Parameters.Add("pLUGARES", OracleDbType.Int32).Value = oMedioPago.Lugares;
                        cmd.Parameters.Add("pCOBERTURA", OracleDbType.Int32).Value = oMedioPago.Cobertura;
                        cmd.Parameters.Add("pOBSERVACIONES", OracleDbType.Varchar2).Value = oMedioPago.Observaciones;
                        cmd.Parameters.Add("pBENEFICIOS", OracleDbType.Varchar2).Value = oMedioPago.Beneficios;
                        cmd.Parameters.Add(new OracleParameter("pLISTACARGOS", OracleDbType.Clob, oMedioPago.pXML_ListaCargos, ParameterDirection.Input));
                        cmd.Parameters.Add("pID_XML", OracleDbType.Int32, ParameterDirection.InputOutput).Value = pID_XML;
                        cmd.Parameters.Add("pDESERROR", OracleDbType.Varchar2, 1000, "E", ParameterDirection.InputOutput);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        pID_XML = Convert.ToInt32(cmd.Parameters["pID_XML"].Value.ToString());
                        PDESERROR = cmd.Parameters["PDESERROR"].Value.ToString();
                    }
                    conn.Close();
                }


            }
            catch (Exception ex)
            {

                PDESERROR += " " + ex.Message;

            }

            object[] Respuesta =
            {
                pID_XML,
                PDESERROR
            };

            return Respuesta;

        }

        #endregion

        #region "Pantalla cancelacion creditos incobrables"


        public List<OpeIncCance> ConsultCredIncoCancelados()
        {
            try
            {

                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select NUM_OPERACION,MON_SALDO,USR_CANCELA,FEC_CANCELA from DB_UTILIDADES.UT_INCOBRABLES_CANCELADAS";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<OpeIncCance> ListaOpeIncobCanc = new List<OpeIncCance>();
                while (dr.Read())
                {
                    //dr.GetDouble(1).ToString("C", CultureInfo.CurrentCulture);
                    OpeIncCance objOpe = new OpeIncCance();
                    objOpe.pOperacion = dr.GetString(0);
                    objOpe.pSaldoCancelado = dr.GetDouble(1);
                    objOpe.pUsuarioCancelo = dr.GetString(2);
                    objOpe.pFechaCancela = dr.GetDateTime(3);
                    ListaOpeIncobCanc.Add(objOpe);
                }

                conn.Close();
                conn.Dispose();
                return ListaOpeIncobCanc;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<OpeIncob> ConsultarCreditosIncobrables()
        {
            try
            {

                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select A.COD_COMPANIA,B.DES_IDENTIFICACION,B.COD_CLIENTE,B.NOM_CLIENTE,A.NUM_OPERACION,A.FEC_ULTPINT,ABS(C.MON_CREDITO - C.MON_DEBITO) SALDO,A.FEC_VENCIMIENTO, " + 
                                  " (TRUNC(ABS(MONTHS_BETWEEN(FEC_COBRO,FEC_ULTPINT))) + 1) CUOTA_CANCELA,B.COD_CENTRO,A.POR_TASA" +
                                  " from CREDITO.CR_OPERACIONES A " +
                                  " INNER JOIN CLIENTES.CL_CLIENTES B " +
                                  "     ON A.COD_CLIENTE = B.COD_CLIENTE " +
                                  " INNER JOIN CREDITO.CR_SALDOS C " +
                                  "     ON A.NUM_OPERACION = C.NUM_OPERACION " +
                                  "WHERE A.IND_INCOBRABLE = 'S' AND C.COD_TIPOSALDO = 1 AND ABS(C.MON_CREDITO - C.MON_DEBITO)>0 AND IND_ESTADO NOT IN (5,6) " +
                                  "ORDER BY A.FEC_ULTPINT ASC ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<OpeIncob> ListaOpeIncob = new List<OpeIncob>();
                while (dr.Read())
                {
                    OpeIncob objOpeIncob = new OpeIncob();
                    objOpeIncob.COD_COMPANIA = dr.GetString(0);
                    objOpeIncob.DES_IDENTIFICACION = dr.GetString(1);
                    objOpeIncob.COD_CLIENTE = dr.GetInt32(2);
                    objOpeIncob.NOM_CLIENTE = dr.GetString(3);
                    objOpeIncob.NUM_OPERACION = dr.GetString(4);
                    objOpeIncob.FEC_ULTPINT = dr.GetDateTime(5);
                    objOpeIncob.Saldo = dr.GetDecimal(6);
                    objOpeIncob.FEC_VENCIMIENTO = dr.GetDateTime(7);                    
                    objOpeIncob.CuotaCancela = Convert.ToInt32(dr.GetDecimal(8));
                    objOpeIncob.COD_CENTRO = dr.GetString(9);
                    objOpeIncob.POR_TASA = dr.GetDecimal(10);
                    objOpeIncob.CancelarSaldo = 0; //La encontradas estarian en cero
                    ListaOpeIncob.Add(objOpeIncob);
                }

                conn.Close();
                conn.Dispose();
                return ListaOpeIncob;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Func_ConseReciboCredito() 
        {

            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.Connection = conn;              
                cmd.CommandText = "CREDITO.Cr_pagos02.consecutivo_recibo";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.Parameters.Add(new OracleParameter("p_compania", OracleDbType.Varchar2, 32767, "01001001", ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("p_compania_orig", OracleDbType.Varchar2, 32767, "01001001", ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("p_ind_todo_deposito", OracleDbType.Varchar2, 2, "SI", ParameterDirection.Input));
                cmd.Parameters.Add(new OracleParameter("SalidaNula", OracleDbType.Int64, DBNull.Value, ParameterDirection.Output)); //al paracer ejecutar una funcion de oracle con mas de dos parametros tipo output no es valido, maximo dos
                cmd.Parameters.Add(new OracleParameter("p_consecutivo", OracleDbType.Int64, DBNull.Value, ParameterDirection.Output));
                cmd.Parameters.Add(new OracleParameter("p_recibo_control", OracleDbType.Varchar2, 32767, DBNull.Value, ParameterDirection.Output));
                cmd.Parameters.Add(new OracleParameter("retVal", OracleDbType.Int64, DBNull.Value, ParameterDirection.ReturnValue));   
                conn.Open();
                cmd.ExecuteNonQuery();
                int Recibo = -1;
                Recibo = Convert.ToInt32(cmd.Parameters["p_consecutivo"].Value.ToString());               
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return Recibo;


            }
            catch (Exception)
            {
                
                throw;
            }

        }



        public void RegistrarCancelacionCredito(List<OpeIncob> ListadoIncobrables, string Usuario)
        {

            foreach (OpeIncob item in ListadoIncobrables)
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();

                cmd.Connection = conn;

                cmd.CommandText = "DB_UTILIDADES.CR_CANCELACION_INCOBRABLES";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("p_operacion", OracleDbType.Varchar2).Value = item.NUM_OPERACION;
                cmd.Parameters.Add("p_codCompania", OracleDbType.Varchar2).Value = item.COD_COMPANIA;
                cmd.Parameters.Add("p_usuario", OracleDbType.Varchar2).Value = Usuario;

                conn.Open();

                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }

        }


        #endregion
        #region "Pantalla reingreso de asociados"

        public int PROC_REINASOCIADO(AsoReingreso auxReingreso)
        {
            int Respuesta = -1;
            conn = new OracleConnection(cadena);
            cmd = new OracleCommand();
            try
            {
                
                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.PROC_REINASOCIADO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("PDES_IDENTIFICACION", OracleDbType.Varchar2).Value = auxReingreso.PDES_IDENTIFICACION;
                string Fecha = auxReingreso.PFEC_REINGRESO.Day.ToString() + "/" + auxReingreso.PFEC_REINGRESO.Month.ToString() + "/" + auxReingreso.PFEC_REINGRESO.Year.ToString();
                cmd.Parameters.Add("PFEC_REINGRESO", OracleDbType.Varchar2).Value = Fecha.Trim();
                cmd.Parameters.Add("USU_AFILIA", OracleDbType.Varchar2).Value = auxReingreso.USU_AFILIA;
                cmd.Parameters.Add("USU_REGISTRO", OracleDbType.Varchar2).Value = auxReingreso.USU_REGISTRO;
                cmd.Parameters.Add("RESPUESTA", OracleDbType.Int32,1, ParameterDirection.Output);
                cmd.Parameters.Add("v_des_error", OracleDbType.Varchar2, ParameterDirection.Output);                
                conn.Open();
                cmd.ExecuteNonQuery();
                Respuesta = Convert.ToInt32(cmd.Parameters["RESPUESTA"].Value.ToString());                
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return Respuesta;
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
                string error = cmd.Parameters["v_des_error"].Value.ToString();
                return -1;
            }
            

        }

        


        public List<AsoReingreso> OBTENERREINGRESOS()
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                OracleDataReader dr;
                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERREINGRESOS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter("REF_REINGRESOS", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                //cmd.Parameters.Add("p_operacion", OracleDbType.Varchar2).Value = item.NUM_OPERACION;            
                conn.Open();
                dr = cmd.ExecuteReader();                
                List<AsoReingreso> ListadoReingresos = new List<AsoReingreso>();
                while (dr.Read())
                {
                    AsoReingreso aux = new AsoReingreso();
                    aux.PDES_IDENTIFICACION = dr.GetString(0);
                    aux.NOM_CLIENTE = dr.GetString(1);
                    aux.PFEC_REINGRESO = dr.GetDateTime(2);
                    aux.USU_AFILIA = dr.GetString(3);
                    aux.PFEC_REGISTRO = dr.GetDateTime(4);
                    aux.USU_REGISTRO = dr.GetString(5);
                    ListadoReingresos.Add(aux);
                    
                }
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return ListadoReingresos;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<AsoRenuncia> OBTENERASOCIADOSRENUNCIA()
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                OracleDataReader dr;
                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERASOCIADOSRENUNCIA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter("REF_ASOCIADOSRENUNCIA", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                //cmd.Parameters.Add("p_operacion", OracleDbType.Varchar2).Value = item.NUM_OPERACION;            
                conn.Open();
                dr = cmd.ExecuteReader();
                List<AsoRenuncia> ListadoRenuncia = new List<AsoRenuncia>();
                while (dr.Read())
                {
                    AsoRenuncia aux = new AsoRenuncia();
                    aux.COD_CLIENTE = dr.GetInt32(0);
                    aux.DES_IDENTIFICACION = dr.GetString(1);
                    aux.NOM_CLIENTE = dr.GetString(2);
                    aux.FEC_AFILIACION = dr.GetDateTime(3);
                    aux.FEC_RENUNCIA = dr.GetDateTime(4);
                    aux.COD_USUARIO_REN = dr.GetString(5);
                    aux.UBI_RENUNCIA = dr.GetString(6);
                    ListadoRenuncia.Add(aux);
                }
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return ListadoRenuncia;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Asociado> OBTENER_ASOACTIVOS()
        {
            try
            {            
            conn = new OracleConnection(cadena);
            cmd = new OracleCommand();
            OracleDataReader dr;
            cmd.Connection = conn;
            cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENER_ASOACTIVOS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new OracleParameter("ref_AsociadosActivos", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                //cmd.Parameters.Add("p_operacion", OracleDbType.Varchar2).Value = item.NUM_OPERACION;            
            conn.Open();
            dr = cmd.ExecuteReader();
            List<Asociado> ListadoAsoActivos = new List<Asociado>();           

            while (dr.Read())
            {
                Asociado aux = new Asociado();
                aux.COD_CLIENTE = dr.GetInt32(0);
                aux.DES_IDENTIFICACION = dr.GetString(1);
                aux.NOM_CLIENTE = dr.GetString(2);
                aux.FEC_AFILIACION = dr.GetDateTime(3);
                ListadoAsoActivos.Add(aux);
            }            
            conn.Close();
            conn.Dispose();
            cmd.Dispose();

            return ListadoAsoActivos;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<Asociado> OBTENER_ASOINACTIVOS()
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                OracleDataReader dr;
                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENER_ASOINACTIVOS";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new OracleParameter("ref_asoinactivos", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                //cmd.Parameters.Add("p_operacion", OracleDbType.Varchar2).Value = item.NUM_OPERACION;            
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Asociado> ListadoAsoInactivo = new List<Asociado>();
      
                while (dr.Read())
                {
                    Asociado aux = new Asociado();
                    aux.DES_IDENTIFICACION = dr.GetString(0);
                    aux.NOM_CLIENTE = dr.GetString(1);
                    aux.FEC_INACTIVO = dr.GetDateTime(2);
                    aux.FEC_REGISTRO = dr.GetDateTime(3);
                    aux.USU_REGISTRO = dr.GetString(4);                    
                    ListadoAsoInactivo.Add(aux);

                }
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return ListadoAsoInactivo;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int PROC_INAASOCIADO(Asociado auxAsociado)
        {
            int Respuesta = -1;
            conn = new OracleConnection(cadena);
            cmd = new OracleCommand();
            try
            {

                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.INACTIVAR_ASOCIADO";
                cmd.CommandType = CommandType.StoredProcedure;
                string Fecha = auxAsociado.FEC_INACTIVO.Day.ToString() + "/" + auxAsociado.FEC_INACTIVO.Month.ToString() + "/" + auxAsociado.FEC_INACTIVO.Year.ToString();

                cmd.Parameters.Add("PDES_IDENTIFICACION", OracleDbType.Varchar2).Value = auxAsociado.DES_IDENTIFICACION;                
                cmd.Parameters.Add("PFEC_INACTIVO", OracleDbType.Varchar2).Value = Fecha.Trim();
                cmd.Parameters.Add("USU_GESTION", OracleDbType.Varchar2).Value = auxAsociado.USU_REGISTRO.ToUpper().Trim();
                cmd.Parameters.Add("RESPUESTA", OracleDbType.Int32, 1, ParameterDirection.Output);
                cmd.Parameters.Add("v_des_error", OracleDbType.Varchar2, ParameterDirection.Output);
                conn.Open();
                cmd.ExecuteNonQuery();
                Respuesta = Convert.ToInt32(cmd.Parameters["RESPUESTA"].Value.ToString());
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                //cmd.Connection = conn;
                //cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.INACTIVAR_ASOCIADO";
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("PDES_IDENTIFICACION", OracleDbType.Varchar2,1000).Value = "105630967";
                //string Fecha = auxAsociado.FEC_INACTIVO.Day.ToString() + "/" + auxAsociado.FEC_INACTIVO.Month.ToString() + "/" + auxAsociado.FEC_INACTIVO.Year.ToString();
                //cmd.Parameters.Add("PFEC_INACTIVO", OracleDbType.Varchar2,1000).Value = "7/7/2020";
                //cmd.Parameters.Add("USU_GESTION", OracleDbType.Varchar2,1000).Value = "cgonzalez";
                //cmd.Parameters.Add("RESPUESTA", OracleDbType.Int32, 1, ParameterDirection.Output);
                //cmd.Parameters.Add("v_des_error", OracleDbType.Varchar2,1000,"", ParameterDirection.Output);
                //conn.Open();
                //cmd.ExecuteNonQuery();
                //Respuesta = Convert.ToInt32(cmd.Parameters["RESPUESTA"].Value.ToString());
                //conn.Close();
                //conn.Dispose();
                //cmd.Dispose();


                return Respuesta;
            }
            catch (Exception ex)
            {
                string err = ex.ToString();
                string error = cmd.Parameters["v_des_error"].Value.ToString();
                return -1;
            }


        }
      
        #endregion
        #region "Pantalla Agregar vendedor"

        public ResVendedor PROC_INSERTAVENDEDOR(string cod_usuario)
        {
            ResVendedor respuesta = new ResVendedor();
            conn = new OracleConnection(cadena);
            cmd = new OracleCommand();
            try
            {

                cmd.Connection = conn;
                cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.INSERTAVENDEDOR";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("PCOD_USUARIO", OracleDbType.Varchar2).Value = cod_usuario;

                cmd.Parameters.Add("VCODIGO", OracleDbType.Int32, 1, ParameterDirection.Output);
                cmd.Parameters.Add("v_cod_error", OracleDbType.Int32, 1, ParameterDirection.Output);
                cmd.Parameters.Add("v_des_error", OracleDbType.Varchar2, ParameterDirection.Output);
                conn.Open();
                cmd.ExecuteNonQuery();
                respuesta.cod_vendedor = Convert.ToInt32(cmd.Parameters["VCODIGO"].Value.ToString());
                respuesta.des_error = cmd.Parameters["v_des_error"].Value.ToString();
                respuesta.cod_error = Convert.ToInt32(cmd.Parameters["v_cod_error"].Value.ToString());
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return respuesta;
            }
            catch (Exception ex)
            {
                respuesta.cod_vendedor = 0;
                respuesta.des_error = ex.Message;
                respuesta.cod_error = 1;
                return respuesta;
            }


        }
        #endregion
        #region Pantalla xml Prorrogas
        public List<Prorroga> obtenerProrrgasMes(int mes, int anno)
        {
            try
            {

                OracleDataReader dr;
                List<Prorroga> ListadoProrrogas;

                using (OracleConnection conn = new OracleConnection(cadena))
                {
                    using (OracleCommand cmd = new OracleCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "DB_UTILIDADES.PKG_COOPEBANK.OBTENERPRORROGA";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("pMes", OracleDbType.Int32).Value = mes;
                        cmd.Parameters.Add("pAnno", OracleDbType.Int32).Value = anno;
                        cmd.Parameters.Add(new OracleParameter("ref_tiposp", OracleDbType.RefCursor, DBNull.Value, ParameterDirection.Output));
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        ListadoProrrogas = new List<Prorroga>();
                        while (dr.Read())
                        {
                            Prorroga objProrroga = new Prorroga();

                            objProrroga.tipoPersona = dr.GetString(0);
                            objProrroga.cedula = dr.GetString(1);
                            objProrroga.operacion = dr.GetString(2);
                            objProrroga.fecha = dr.GetString(3);
                            objProrroga.tipo = dr.GetString(4);

                            ListadoProrrogas.Add(objProrroga);
                        }
                        dr.Close();
                    }
                    conn.Close();
                }

                return ListadoProrrogas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


        public Asociado ObtenerAsociado (string cedula)
        {
            try
            {

                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select NOM_CLIENTE, DES_IDENTIFICACION, IND_EMPRESA From CLIENTES.CL_CLIENTES WHERE DES_IDENTIFICACION = :DES_IDENTIFICACION and ROWNUM = 1";                                  
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new OracleParameter("DES_IDENTIFICACION", cedula.Substring(0,1).Equals("0") ? cedula.Substring(1).Replace("-","") : cedula.Replace("-","")));
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                Asociado oAsociado = new Asociado();
                while (dr.Read())
                {
                    oAsociado.NOM_CLIENTE = dr.GetString(0);
                    oAsociado.DES_IDENTIFICACION = dr.GetString(1);
                    oAsociado.TipoPersona = Convert.ToInt32(dr.GetString(2));
                }

                conn.Close();
                conn.Dispose();
                return oAsociado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ModificarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "UPDATE CREDITO.CR_AVALUOS_MAD "+
                                  "SET FEC_AVALUO = :FEC_AVALUO, "+
                                  "    NUM_PERITO = :NUM_PERITO, "+
                                  "    MON_AVALUO = :MON_AVALUO, "+
                                  "    MON_TERRENO = :MON_TERRENO,"+
                                  "    MON_CONSTRUCCION = :MON_CONSTRUCCION, "+
                                  "    MON_VEHICULO = :MON_VEHICULO, "+
                                  "    ESTADO = :ESTADO, "+
                                  "    GENREG = :GENREG, "+
                                  "    COD_TIPOBIEN = :COD_TIPOBIEN, "+
                                  "    IND_BIENADJUDICADO = :IND_BIENADJUDICADO "+
                                  "Where NUM_GARANTIA_MADRE = :NUM_GARANTIA_MADRE";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;                
                cmd.Parameters.Add(new OracleParameter("FEC_AVALUO", objAv.FEC_AVALUO));
                cmd.Parameters.Add(new OracleParameter("NUM_PERITO", objAv.NUM_PERITO));
                cmd.Parameters.Add(new OracleParameter("MON_AVALUO", objAv.MON_AVALUO));
                cmd.Parameters.Add(new OracleParameter("MON_TERRENO", objAv.MON_TERRENO));
                cmd.Parameters.Add(new OracleParameter("MON_CONSTRUCCION", objAv.MON_CONSTRUCCION));
                cmd.Parameters.Add(new OracleParameter("MON_VEHICULO", objAv.MON_VEHICULO));
                cmd.Parameters.Add(new OracleParameter("ESTADO", objAv.ESTADO));
                cmd.Parameters.Add(new OracleParameter("GENREG", objAv.GENREG));
                cmd.Parameters.Add(new OracleParameter("COD_TIPOBIEN", objAv.COD_TIPOBIEN));
                cmd.Parameters.Add(new OracleParameter("IND_BIENADJUDICADO", objAv.IND_BIENADJUDICADO));
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));               
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Delete from CREDITO.CR_AVALUOS_MAD WHERE NUM_GARANTIA_MADRE = :NUM_GARANTIA_MADRE";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void RegistrarAvaluo(Avaluo objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Insert into CREDITO.CR_AVALUOS_MAD (COD_COMPANIA, NUM_GARANTIA_MADRE, FEC_AVALUO, NUM_PERITO, MON_AVALUO, "+
                    "MON_TERRENO, MON_CONSTRUCCION, MON_VEHICULO, ESTADO, GENREG, COD_TIPOBIEN, IND_BIENADJUDICADO) "+
                    "Values (:COD_COMPANIA, :NUM_GARANTIA_MADRE,:FEC_AVALUO, :NUM_PERITO, :MON_AVALUO, " +
                    ":MON_TERRENO, :MON_CONSTRUCCION, :MON_VEHICULO, :ESTADO, :GENREG, :COD_TIPOBIEN, :IND_BIENADJUDICADO)";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objAv.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_GARANTIA_MADRE", objAv.NUM_GARANTIA_MADRE));
                cmd.Parameters.Add(new OracleParameter("FEC_AVALUO", objAv.FEC_AVALUO));
                cmd.Parameters.Add(new OracleParameter("NUM_PERITO", objAv.NUM_PERITO));
                cmd.Parameters.Add(new OracleParameter("MON_AVALUO", objAv.MON_AVALUO));
                cmd.Parameters.Add(new OracleParameter("MON_TERRENO", objAv.MON_TERRENO));
                cmd.Parameters.Add(new OracleParameter("MON_CONSTRUCCION", objAv.MON_CONSTRUCCION));
                cmd.Parameters.Add(new OracleParameter("MON_VEHICULO", objAv.MON_VEHICULO));
                cmd.Parameters.Add(new OracleParameter("ESTADO", objAv.ESTADO));
                cmd.Parameters.Add(new OracleParameter("GENREG", objAv.GENREG));
                cmd.Parameters.Add(new OracleParameter("COD_TIPOBIEN", objAv.COD_TIPOBIEN));
                cmd.Parameters.Add(new OracleParameter("IND_BIENADJUDICADO", objAv.IND_BIENADJUDICADO));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public List<MoviBanco> ConsultarMovimientosBancos()
        {
            try
            {      

                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT COD_COMPANIA, NUM_CUENTA, TIP_MOVIM, NUM_MOVIM,  FEC_MOVIM, COD_ESTADO, " +
                                  "NVL(COD_AJUSTE,' '), NVL(NUM_MOVIM_AJU,' '), NVL(IND_DIFERENCIA,' '), NVL(NOM_BENEFICIARIO,' '), NVL(DOC_CONCILIAR,' '), NVL(DESCRIPCION,' '), NVL(IND_ENVIO_NOTA,' '),NVL(MON_MOVIM,0) FROM CONCILIACION.BC_CONCI_MOVIM_BANCOS";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<MoviBanco> ListadoMovimientos = new List<MoviBanco>();
                while (dr.Read())
                {
                    MoviBanco objMoviBanco = new MoviBanco();
                    objMoviBanco.COD_COMPANIA = dr.GetString(0);
                    objMoviBanco.NUM_CUENTA = dr.GetString(1);
                    objMoviBanco.TIP_MOVIM = dr.GetString(2);
                    objMoviBanco.NUM_MOVIM = dr.GetString(3);
                    objMoviBanco.FEC_MOVIM = dr.GetDateTime(4);
                    objMoviBanco.COD_ESTADO = dr.GetString(5);
                    objMoviBanco.COD_AJUSTE = dr.GetString(6);
                    objMoviBanco.NUM_MOVIM_AJU = dr.GetString(7);
                    objMoviBanco.IND_DIFERENCIA = dr.GetString(8);
                    objMoviBanco.NOM_BENEFICIARIO = dr.GetString(9);
                    objMoviBanco.DOC_CONCILIAR = dr.GetString(10);
                    objMoviBanco.DESCRIPCION = dr.GetString(11);
                    objMoviBanco.IND_ENVIO_NOTA = dr.GetString(12);
                    objMoviBanco.MON_MOVIM = dr.GetDecimal(13);
                    ListadoMovimientos.Add(objMoviBanco);
                }

                conn.Close();
                conn.Dispose();
                return ListadoMovimientos;
            }
            catch (Exception)
            {

                throw;
            }
        }
       
        public List<TipMoviBanco> ConsultarMoviBanco()
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT COD_COMPANIA,COD_TPMOV,DES_TPMOV FROM BANCOS.BC_TIPO_MOV WHERE GENERA_ASIENTO = 'S'";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<TipMoviBanco> ListadoTipMoviBanco = new List<TipMoviBanco>();
                while (dr.Read())
                {
                    TipMoviBanco objTipMoviBanco = new TipMoviBanco();
                    objTipMoviBanco.COD_COMPANIA = dr.GetString(0);
                    objTipMoviBanco.COD_TPMOV = dr.GetString(1);
                    objTipMoviBanco.DES_TPMOV = dr.GetString(2);
                    ListadoTipMoviBanco.Add(objTipMoviBanco);
                }

                conn.Close();
                conn.Dispose();
                return ListadoTipMoviBanco;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public List<BcEstados> ConsultarEstadosMovimientos()
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select DISTINCT B.* from CONCILIACION.BC_CONCI_MOVIM_BANCOS A " +
                                  " INNER JOIN BANCOS.BC_ESTADO B ON A.COD_ESTADO = B.COD_ESTADO Order by B.COD_ESTADO ASC";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<BcEstados> ListadoBcEstados = new List<BcEstados>();
                while (dr.Read())
                {
                    BcEstados objBcEstados = new BcEstados();
                    objBcEstados.COD_ESTADO = dr.GetString(0);
                    objBcEstados.ESTADO = dr.GetString(1);
                    ListadoBcEstados.Add(objBcEstados);
                }

                conn.Close();
                conn.Dispose();
                return ListadoBcEstados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarEstadoTipoAhorro(string pIND_INVERSION,bool Habilitar)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                   "set COD_ESTADO = :COD_ESTADO " +
                                   "Where IND_INVERSION = :PRODUCTO";

                cmd.Parameters.Clear();
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", Habilitar ? "01" : "02"));
                cmd.Parameters.Add(new OracleParameter("PRODUCTO", pIND_INVERSION));
                int RegistrosAfectados = 0;
                RegistrosAfectados = cmd.ExecuteNonQuery();
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
                return RegistrosAfectados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ContratoGestionPendi> ConsultarPendientesProd()
        {
            try
            {

                List<ContratoGestionPendi> ListadoRetornar;
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = 

                    "Select  "+
                    "    A.DES_IDENTIFICACION,A.NOM_CLIENTE,A.COD_CLIENTE, F.DES_CENTRO, " +
                    "    (NVL((SELECT SUM(MONTO_PENDIENTE_X_COBRAR) FROM DEDUCCIONES.DE_CUOTA_PENDIENTES D WHERE D.COD_CLIENTE = A.COD_CLIENTE AND D.IND_ESTADO = 'P'),0.00)) MONTO_PENDIENTE_CAPITAL_SOCIAL, "+
                    "    (NVL((SELECT SUM(MON_SALDO_REAL) FROM INVERSIONES.IN_CINVERSION D WHERE D.COD_CLIENTE = A.COD_CLIENTE AND D.IND_INVERSION = '010'),0.00)) MONTO_EXCEDENTES "+
                    " From "  +
                    "    CLIENTES.CL_CLIENTES A "+
                    "    LEFT JOIN GENERAL.GL_CENTROS F ON A.COD_CENTRO = F.COD_CENTRO "+
                    "WHERE "+
                    "    A.COD_TIPOCLIENTE IN ('CL') "+
                    "    AND ( "+
                    "    (A.COD_CENTRO != '99' "+
                    "    AND A.COD_CLIENTE IN ( "+
                    "        SELECT  "+
                    "            B.COD_CLIENTE " +
                    "        FROM "+
                    "            CREDITO.CR_OPERACIONES B " +
                    "            INNER JOIN CREDITO.CR_SALDOS C ON B.NUM_OPERACION = C.NUM_OPERACION AND C.COD_TIPOSALDO = 1 " +
                    "        where " +
                    "            B.COD_CLIENTE = A.COD_CLIENTE "+
                    "            AND C.MON_DEBITO-C.MON_CREDITO > 0 "+
                    "            AND  (B.FEC_ULTPINT < TO_DATE('30/04/2019','DD/MM/YYYY') or B.IND_ESTADO = 5) "+
                    "    )) "+
                    "    OR  "+
                    "        (A.COD_CENTRO = '99' "+
                    "    AND A.COD_CLIENTE IN ( "+
                    "        SELECT "+
                    "            B.COD_CLIENTE "+
                    "        FROM  "+
                    "            CREDITO.CR_OPERACIONES B "+
                    "            INNER JOIN CREDITO.CR_SALDOS C ON B.NUM_OPERACION = C.NUM_OPERACION AND C.COD_TIPOSALDO = 1 "+
                    "        where "+
                    "            B.COD_CLIENTE = A.COD_CLIENTE "+
                    "            AND C.MON_DEBITO-C.MON_CREDITO > 0 "+
                    "            AND  (B.FEC_ULTPINT < TO_DATE('30/05/2019','DD/MM/YYYY') or B.IND_ESTADO = 5) "+
                    "    )) "+
                    "    OR "+
                    "    (A.COD_CLIENTE IN (SELECT COD_CLIENTE FROM DEDUCCIONES.DE_CUOTA_PENDIENTES D WHERE D.COD_CLIENTE = A.COD_CLIENTE AND D.IND_ESTADO = 'P')) "+
                    "    ) "+
                    "    and "+
                    "    ( "+
                    "        NVL((SELECT SUM(D.MON_SALDO_REAL) FROM INVERSIONES.IN_CINVERSION D WHERE D.COD_CLIENTE = A.COD_CLIENTE AND D.IND_INVERSION = '010'),0.00) "+
                    "    ) > 0 ";

                dr = cmd.ExecuteReader();
                ListadoRetornar = new List<ContratoGestionPendi>();
                while (dr.Read())
                {
                    ContratoGestionPendi obj = new ContratoGestionPendi();
                    obj.Cedula = dr.GetString(0);
                    obj.Nombre = dr.GetString(1);
                    string DatosContrato = ConsultarDatosContratoAhorro(Convert.ToString(dr.GetDecimal(2)), "010");
                    obj.Contrato = DatosContrato.Split('>')[0].ToString();
                    obj.MONTO_REAL = Convert.ToDecimal(DatosContrato.Split('>')[2]);
                    obj.MONTO_DISPONIBLE = Convert.ToDecimal(DatosContrato.Split('>')[3]);
                    obj.MONTO_BLOQUEADO = Convert.ToDecimal(DatosContrato.Split('>')[4]);
                    obj.habilitar = true;
                    ListadoRetornar.Add(obj);
                    
                }

                return ListadoRetornar;     
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int BloquearMontoContrato(string pIND_INVERSION, string NUM_CONTRATO,bool Bloquear)
        {
            try
            {



                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();

                if (Bloquear)
                {
                    cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                   "set MON_BLOQUEADO = MON_SALDO, " +
                                   "    MON_SALDO = 0 " +
                                   "Where IND_INVERSION = :PRODUCTO and NUM_CONTRATO = :NUM_CONTRATO";
                }
                else
                {
                    cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                   "set MON_SALDO = MON_BLOQUEADO, " +
                                   "    MON_BLOQUEADO = 0 " +
                                   "Where IND_INVERSION = :PRODUCTO and NUM_CONTRATO = :NUM_CONTRATO";
                }

                

                cmd.Parameters.Clear();
               
                cmd.Parameters.Add(new OracleParameter("PRODUCTO", pIND_INVERSION));
                cmd.Parameters.Add(new OracleParameter("NUM_CONTRATO", NUM_CONTRATO));
                int RegistrosAfectados = 0;
                RegistrosAfectados = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return RegistrosAfectados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarEstadoContratoAhorro(string pIND_INVERSION,string NUM_CONTRATO, bool Habilitar)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                   "set COD_ESTADO = :COD_ESTADO " +
                                   "Where IND_INVERSION = :PRODUCTO and NUM_CONTRATO = :NUM_CONTRATO";

                cmd.Parameters.Clear();
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", Habilitar ? "01" : "02"));
                cmd.Parameters.Add(new OracleParameter("PRODUCTO", pIND_INVERSION));
                cmd.Parameters.Add(new OracleParameter("NUM_CONTRATO", NUM_CONTRATO));
                int RegistrosAfectados = 0;
                RegistrosAfectados = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                return RegistrosAfectados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ActualizarProdCtaExternaSinpe(string pIND_INVERSION,char pIndicador)
        {
            try
            {
                    conn = new OracleConnection(cadena);
                    cmd = new OracleCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.Connection = conn;
                    conn.Open();                 
                    cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                       "set IND_CTA_EXTERNA = :INDICADOR " +                                      
                                       "Where IND_INVERSION = :PRODUCTO";

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("INDICADOR", pIndicador));
                    cmd.Parameters.Add(new OracleParameter("PRODUCTO", pIND_INVERSION));
                    int RegistrosAfectados = 0;
                    RegistrosAfectados = cmd.ExecuteNonQuery();
                    return RegistrosAfectados;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public string ConsultarDatosCliente(string pIdentificacion)
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select COD_CLIENTE||'>'||NOM_CLIENTE||'>'||COD_CENTRO from CLIENTES.CL_CLIENTES Where DES_IDENTIFICACION = '"+pIdentificacion+"'";                                                
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                string NombreCliente = Convert.ToString(cmd.ExecuteScalar());
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                NombreCliente = NombreCliente.Length <= 0 ? "-1>-1>-1" : NombreCliente;
                return NombreCliente;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ConsultarDatosContratoAhorro(string pCod_Cliente,string pInd_Inversion)
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select A.NUM_CONTRATO||'>'||A.COD_ESTADO||'>'||A.MON_SALDO_REAL||'>'||A.MON_SALDO||'>'||A.MON_BLOQUEADO||'>'||A.CUENTA_CLIENTE||'>'||A.COD_ESTADO DATO from INVERSIONES.IN_CINVERSION A" +
                                  " INNER JOIN CLIENTES.CL_CLIENTES B ON A.COD_CLIENTE = B.COD_CLIENTE " +
                                  "Where A.IND_INVERSION = '" + pInd_Inversion + "' and B.COD_CLIENTE = " + pCod_Cliente +
                                  " AND ROWNUM = 1 " +
                                  "Order by A.MON_SALDO_REAL desc";               
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                string DatoContrato = Convert.ToString(cmd.ExecuteScalar());
                DatoContrato = DatoContrato.Length <= 0 ? "-1>-1":DatoContrato;
                cmd.Dispose();
                conn.Close();
                conn.Dispose();
                return DatoContrato;
            }
            catch (Exception)
            {

                throw;
            }
        }


   public List<Banco> ConsultarBancos()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select COD_COMPANIA,COD_CUENTA,COD_MONEDA,NOM_CUENTA from BANCOS.BC_CUENTA_CORRIENTE order BY COD_COMPANIA ASC";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Banco> ListadoBancos = new List<Banco>();
                while (dr.Read())
                {
                    Banco objBanco = new Banco();
                    objBanco.COD_COMPANIA = dr.GetString(0);
                    objBanco.COD_CUENTA = dr.GetString(1);
                    objBanco.COD_MONEDA = dr.GetString(2);
                    objBanco.NOM_CUENTA = dr.GetString(3);
                    ListadoBancos.Add(objBanco);
                }

                conn.Close();
                conn.Dispose();
                return ListadoBancos;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //REGISTRO MOVIMIENTO CONCILIADO EN BANCOS
        public void RegistarMoviBanco(MoviBanco objMoviBanco)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "INSERT INTO CONCILIACION.BC_CONCI_MOVIM_BANCOS (COD_COMPANIA, NUM_CUENTA, TIP_MOVIM, " +
                              "NUM_MOVIM, MON_MOVIM, FEC_MOVIM, COD_ESTADO, COD_AJUSTE, NUM_MOVIM_AJU, IND_DIFERENCIA, NOM_BENEFICIARIO, DOC_CONCILIAR, " +
                              "DESCRIPCION, IND_ENVIO_NOTA) VALUES (:COD_COMPANIA, :NUM_CUENTA, :TIP_MOVIM, :NUM_MOVIM, :MON_MOVIM, :FEC_MOVIM, :COD_ESTADO, :COD_AJUSTE, " +
                              ":NUM_MOVIM_AJU, :IND_DIFERENCIA, :NOM_BENEFICIARIO, :DOC_CONCILIAR, :DESCRIPCION, :IND_ENVIO_NOTA)";                
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objMoviBanco.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", objMoviBanco.NUM_CUENTA));
                cmd.Parameters.Add(new OracleParameter("TIP_MOVIM", objMoviBanco.TIP_MOVIM));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM", objMoviBanco.NUM_MOVIM));
                cmd.Parameters.Add(new OracleParameter("MON_MOVIM", objMoviBanco.MON_MOVIM));
                cmd.Parameters.Add(new OracleParameter("FEC_MOVIM", objMoviBanco.FEC_MOVIM));
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", objMoviBanco.COD_ESTADO));
                cmd.Parameters.Add(new OracleParameter("COD_AJUSTE", objMoviBanco.COD_AJUSTE));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM_AJU", objMoviBanco.NUM_MOVIM_AJU));
                cmd.Parameters.Add(new OracleParameter("IND_DIFERENCIA", objMoviBanco.IND_DIFERENCIA));
                cmd.Parameters.Add(new OracleParameter("NOM_BENEFICIARIO", objMoviBanco.NOM_BENEFICIARIO));
                cmd.Parameters.Add(new OracleParameter("DOC_CONCILIAR", objMoviBanco.DOC_CONCILIAR));
                cmd.Parameters.Add(new OracleParameter("DESCRIPCION", objMoviBanco.DESCRIPCION));
                cmd.Parameters.Add(new OracleParameter("IND_ENVIO_NOTA", objMoviBanco.IND_ENVIO_NOTA));                
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "INSERT INTO CT.CT_CONCI_MOVIM_BANCOS (COD_COMPANIA, NUM_CUENTA, TIP_MOVIM, NUM_MOVIM, MON_MOVIM, FEC_MOVIM, COD_ESTADO, COD_AJUSTE, " +
                                  "NUM_MOVIM_AJU, IND_DIFERENCIA, NOM_BENEFICIARIO, DOC_CONCILIAR, TIPO_COONCILIACION, DETALLE) VALUES (:COD_COMPANIA, :NUM_CUENTA, :TIP_MOVIM, " +
                                  ":NUM_MOVIM, :MON_MOVIM, :FEC_MOVIM, :COD_ESTADO, :COD_AJUSTE, :NUM_MOVIM_AJU, :IND_DIFERENCIA, :NOM_BENEFICIARIO, :DOC_CONCILIAR, :TIPO_COONCILIACION, :DETALLE)";

                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objMoviBanco.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", objMoviBanco.NUM_CUENTA));
                cmd.Parameters.Add(new OracleParameter("TIP_MOVIM", objMoviBanco.TIP_MOVIM));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM", objMoviBanco.NUM_MOVIM));
                cmd.Parameters.Add(new OracleParameter("MON_MOVIM", objMoviBanco.MON_MOVIM));
                cmd.Parameters.Add(new OracleParameter("FEC_MOVIM", objMoviBanco.FEC_MOVIM));
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", objMoviBanco.COD_ESTADO));
                cmd.Parameters.Add(new OracleParameter("COD_AJUSTE", objMoviBanco.COD_AJUSTE));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM_AJU", objMoviBanco.NUM_MOVIM_AJU));
                cmd.Parameters.Add(new OracleParameter("IND_DIFERENCIA", objMoviBanco.IND_DIFERENCIA));
                cmd.Parameters.Add(new OracleParameter("NOM_BENEFICIARIO", objMoviBanco.NOM_BENEFICIARIO));
                cmd.Parameters.Add(new OracleParameter("DOC_CONCILIAR", objMoviBanco.DOC_CONCILIAR));
                cmd.Parameters.Add(new OracleParameter("TIPO_COONCILIACION", ""));
                cmd.Parameters.Add(new OracleParameter("DETALLE", objMoviBanco.DESCRIPCION));

                cmd.ExecuteNonQuery();        


                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //REGISTRO MOVIMIENTO CONCILIADO EN BANCOS
        public void ActualizarMoviBanco(MoviBanco objMoviBanco)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = " UPDATE CONCILIACION.BC_CONCI_MOVIM_BANCOS " +
                    " SET    COD_COMPANIA     = :COD_COMPANIA, " +
                    "       NUM_CUENTA       = :NUM_CUENTA, " +
                    "       TIP_MOVIM        = :TIP_MOVIM, " +
                    "       NUM_MOVIM        = :NUM_MOVIM, " +
                    "       MON_MOVIM        = :MON_MOVIM, " +
                    "       FEC_MOVIM        = TO_DATE('" + objMoviBanco.FEC_MOVIM.Date.ToString("dd/MM/yyyy") + "','DD/MM/YYYY'), " +
                    "       COD_ESTADO       = :COD_ESTADO, " +
                    "       COD_AJUSTE       = :COD_AJUSTE, " +
                    "       NUM_MOVIM_AJU    = :NUM_MOVIM_AJU, " +
                    "       IND_DIFERENCIA   = :IND_DIFERENCIA, " +
                    "       NOM_BENEFICIARIO = :NOM_BENEFICIARIO, " +
                    "       DOC_CONCILIAR    = :DOC_CONCILIAR, " +
                    "       DESCRIPCION      = :DESCRIPCION, " +
                    "       IND_ENVIO_NOTA   = :IND_ENVIO_NOTA " +
                    "WHERE  COD_COMPANIA     = :COD_COMPANIA " +
                    "AND    NUM_CUENTA       = :NUM_CUENTA " +
                    "AND    TIP_MOVIM        = :TIP_MOVIM " +
                    "AND    NUM_MOVIM        = :NUM_MOVIM ";
                  //  "AND    FEC_MOVIM        = TO_DATE('" + objMoviBanco.FEC_MOVIM.Date.ToString("dd/MM/yyyy") + "','DD/MM/YYYY') ";

                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objMoviBanco.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", objMoviBanco.NUM_CUENTA));
                cmd.Parameters.Add(new OracleParameter("TIP_MOVIM", objMoviBanco.TIP_MOVIM));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM", objMoviBanco.NUM_MOVIM));
                cmd.Parameters.Add(new OracleParameter("MON_MOVIM", objMoviBanco.MON_MOVIM));
                //cmd.Parameters.Add(new OracleParameter("FEC_MOVIM", objMoviBanco.FEC_MOVIM));
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", objMoviBanco.COD_ESTADO));
                cmd.Parameters.Add(new OracleParameter("COD_AJUSTE", objMoviBanco.COD_AJUSTE));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM_AJU", objMoviBanco.NUM_MOVIM_AJU));
                cmd.Parameters.Add(new OracleParameter("IND_DIFERENCIA", objMoviBanco.IND_DIFERENCIA));
                cmd.Parameters.Add(new OracleParameter("NOM_BENEFICIARIO", objMoviBanco.NOM_BENEFICIARIO));
                cmd.Parameters.Add(new OracleParameter("DOC_CONCILIAR", objMoviBanco.DOC_CONCILIAR));
                cmd.Parameters.Add(new OracleParameter("DESCRIPCION", objMoviBanco.DESCRIPCION));
                cmd.Parameters.Add(new OracleParameter("IND_ENVIO_NOTA", objMoviBanco.IND_ENVIO_NOTA));
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText =   " UPDATE CT.CT_CONCI_MOVIM_BANCOS " +           
                                    " SET   MON_MOVIM          = :MON_MOVIM, " +                                    
                                    "       COD_ESTADO         = :COD_ESTADO, " +
                                    "       COD_AJUSTE         = :COD_AJUSTE, " +
                                    "       NUM_MOVIM_AJU      = :NUM_MOVIM_AJU, " +
                                    "       IND_DIFERENCIA     = '', " +
                                    "       NOM_BENEFICIARIO   = :NOM_BENEFICIARIO, " +
                                    "       DOC_CONCILIAR      = :DOC_CONCILIAR, " +
                                    "       TIPO_COONCILIACION = '', " +
                                    "       DETALLE            = :DESCRIPCION "  +
                                    " WHERE  COD_COMPANIA       = :COD_COMPANIA " +
                                    " AND    NUM_CUENTA         = :NUM_CUENTA " +
                                    " AND    TIP_MOVIM          = :TIP_MOVIM " +
                                    " AND    NUM_MOVIM          = :NUM_MOVIM " +
                                    " AND    FEC_MOVIM        = :FEC_MOVIM ";
                                    

                //cmd.CommandType = CommandType.Text;
                //cmd.CommandTimeout = 0;
                //cmd.Connection = conn;
                


                cmd.Parameters.Add(new OracleParameter("MON_MOVIM", objMoviBanco.MON_MOVIM));
                cmd.Parameters.Add(new OracleParameter("COD_ESTADO", objMoviBanco.COD_ESTADO));
                cmd.Parameters.Add(new OracleParameter("COD_AJUSTE", objMoviBanco.COD_AJUSTE));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM_AJU", objMoviBanco.NUM_MOVIM_AJU));                
                cmd.Parameters.Add(new OracleParameter("NOM_BENEFICIARIO", objMoviBanco.NOM_BENEFICIARIO));
                cmd.Parameters.Add(new OracleParameter("DOC_CONCILIAR", objMoviBanco.DOC_CONCILIAR));
                cmd.Parameters.Add(new OracleParameter("DESCRIPCION", objMoviBanco.DESCRIPCION));                
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objMoviBanco.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", objMoviBanco.NUM_CUENTA));
                cmd.Parameters.Add(new OracleParameter("TIP_MOVIM", objMoviBanco.TIP_MOVIM));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM", objMoviBanco.NUM_MOVIM));              
                cmd.Parameters.Add(new OracleParameter("FEC_MOVIM", objMoviBanco.FEC_MOVIM));
                
               
               
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarMoviBanco(MoviBanco objMoviBanco)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Delete from CONCILIACION.BC_CONCI_MOVIM_BANCOS  WHERE  COD_COMPANIA = :COD_COMPANIA "+
                                  " AND    NUM_CUENTA         = :NUM_CUENTA "+
                                  " AND    TIP_MOVIM          = :TIP_MOVIM "+
                                  " AND    NUM_MOVIM          = :NUM_MOVIM "+
                                  " AND    FEC_MOVIM          = :FEC_MOVIM ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objMoviBanco.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", objMoviBanco.NUM_CUENTA));
                cmd.Parameters.Add(new OracleParameter("TIP_MOVIM", objMoviBanco.TIP_MOVIM));
                cmd.Parameters.Add(new OracleParameter("NUM_MOVIM", objMoviBanco.NUM_MOVIM));          
                cmd.Parameters.Add(new OracleParameter("FEC_MOVIM", objMoviBanco.FEC_MOVIM));
                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Delete from CT.CT_CONCI_MOVIM_BANCOS  WHERE  COD_COMPANIA = :COD_COMPANIA " +
                                  " AND    NUM_CUENTA         = :NUM_CUENTA " +
                                  " AND    TIP_MOVIM          = :TIP_MOVIM " +
                                  " AND    NUM_MOVIM          = :NUM_MOVIM " +
                                  " AND    FEC_MOVIM          = :FEC_MOVIM ";

                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



        public void RegistrarVendedor(Vendedor objAv)
        {
            try
            {
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Insert into FV_VENTAS.FV_VENDEDORES (COD_COMPANIA, COD_VENDEDOR, COD_USUARIO, IND_ESTADO, NOMBRE_VENDEDOR, " +
                                  "  MTO_META_CAPTACION, MTO_META_CREDITO, MTO_META_SEGURO, IND_ORIGEN, TELEFONO, FAX, IND_FORMA_PAGO) " +
                                  " Values (:COD_COMPANIA,:COD_VENDEDOR, :COD_USUARIO, :IND_ESTADO, :NOMBRE_VENDEDOR, :MTO_META_CAPTACION, "+
                                  " :MTO_META_CREDITO, :MTO_META_SEGURO, :IND_ORIGEN, :TELEFONO,  :FAX, :IND_FORMA_PAGO); ";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", objAv.COD_COMPANIA));
                cmd.Parameters.Add(new OracleParameter("COD_VENDEDOR", objAv.COD_VENDEDOR));
                cmd.Parameters.Add(new OracleParameter("COD_USUARIO", objAv.COD_USUARIO));
                cmd.Parameters.Add(new OracleParameter("IND_ESTADO", objAv.IND_ESTADO));
                cmd.Parameters.Add(new OracleParameter("NOMBRE_VENDEDOR", objAv.NOMBRE_VENDEDOR));
                cmd.Parameters.Add(new OracleParameter("MTO_META_CAPTACION", objAv.MTO_META_CAPTACION));
                cmd.Parameters.Add(new OracleParameter("MTO_META_CREDITO", objAv.MTO_META_CREDITO));
                cmd.Parameters.Add(new OracleParameter("MTO_META_SEGURO", objAv.MTO_META_SEGURO));
                cmd.Parameters.Add(new OracleParameter("IND_ORIGEN", objAv.IND_ORIGEN));
                cmd.Parameters.Add(new OracleParameter("TELEFONO", objAv.TELEFONO));
                cmd.Parameters.Add(new OracleParameter("FAX", objAv.FAX));
                cmd.Parameters.Add(new OracleParameter("IND_FORMA_PAGO", objAv.IND_FORMA_PAGO));
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public string ConsultarCuentaClienteProducto(string pIdentificacion)
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                string cedula = pIdentificacion.Trim().Substring(0,1) == "0" ? pIdentificacion.Trim().Substring(1) : pIdentificacion.Trim();
                cmd.CommandText = "Select A.CUENTA_CLIENTE from INVERSIONES.IN_CINVERSION	A " +
                                   "INNER JOIN CLIENTES.CL_CLIENTES B " +
                                   " ON A.COD_CLIENTE = B.COD_CLIENTE " +
                                   " Where " +
                                   " A.IND_INVERSION = '009' "+
                                   " AND A.COD_COMPANIA = '01001001' "+
                                   " AND B.DES_IDENTIFICACION = '" + cedula + "'" +
                                   " AND A.NUM_CONTRATO =  (SELECT Z.NUM_CONTRATO From INVERSIONES.IN_CINVERSION Z " +
                                                            " Where Z.IND_INVERSION = '009' " +
                                                            " AND Z.COD_CLIENTE = A.COD_CLIENTE " +
                                                            " AND A.COD_COMPANIA = '01001001' "+
                                                            "AND ROWNUM = 1)";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                string cuentacliente = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                cmd.Dispose();
                conn.Dispose();
                 return cuentacliente;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ConsultarSiguienteVendendedor()
        {
            try
            {
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select max(COD_VENDEDOR) from FVENTAS.FV_VENDEDORES";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());            


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Vendedor> ConsultarVendedores()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select distinct * from FVENTAS.FV_VENDEDORES where COD_COMPANIA = '01001001' ORDER BY COD_VENDEDOR ASC";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Vendedor> ListadoVendedores = new List<Vendedor>();
                while (dr.Read())
                {
                    Vendedor objVend = new Vendedor();
                    objVend.COD_COMPANIA = dr.GetString(0);
                    objVend.COD_VENDEDOR = dr.GetInt32(1);
                    objVend.COD_USUARIO = dr.GetString(2);
                    objVend.IND_ESTADO = dr.GetString(3)=="A"?"1":"0";
                    objVend.NOMBRE_VENDEDOR = dr.GetString(4);
                    objVend.MTO_META_CAPTACION = dr.GetDecimal(5);
                    objVend.MTO_META_CREDITO = dr.GetDecimal(6);
                    objVend.MTO_META_SEGURO = dr.GetDecimal(7);
                    objVend.IND_ORIGEN = dr.GetString(8);
                    objVend.TELEFONO = dr.IsDBNull(9) == true ? "" : dr.GetString(9);
                    objVend.FAX = dr.IsDBNull(10) == true ? "" : dr.GetString(10);
                    objVend.IND_FORMA_PAGO = dr.IsDBNull(11) == true ? "" : dr.GetString(11);
                    ListadoVendedores.Add(objVend);

                }

                conn.Close();
                conn.Dispose();
                return ListadoVendedores;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Operacion> ConsultarOperacionesPS()
        {
            try
            {
                OracleDataReader dr;
                
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText =
                 "Select " +
                 " B.COD_COMPANIA, " +
                 " (SELECT DES_IDENTIFICACION FROM CLIENTES.CL_CLIENTES WHERE COD_CLIENTE = B.COD_CLIENTE) DES_IDENTIFICACION, " +
                 " B.COD_CLIENTE, " +
                 "(SELECT NOM_CLIENTE FROM CLIENTES.CL_CLIENTES WHERE COD_CLIENTE = B.COD_CLIENTE) NOM_CLIENTE, " +
                 " B.NUM_OPERACION, " +
                 " B.FEC_CONSTITUCION," +
                 " B.FEC_VENCIMIENTO, " +
                 " B.MON_ORIGINAL, " +
                 " ABS(C.MON_CREDITO - C.MON_DEBITO) SALDO, " +
                 " A.NUM_GARANTIA, " +
                 " NVL((SELECT NUM_GARANTIA_ORIGINAL FROM CREDITO.CR_GARANTIA_MADRE WHERE NUM_GARANTIA_MADRE = A.NUM_GARANTIA),'NO REGISTRA') GARANTIASIC," +
                 "(SELECT C.DES_ESTADO FROM CREDITO.CR_ESTADOS_OPER C WHERE IND_ESTADO = B.IND_ESTADO) ESTADO " +
                 " From CREDITO.CR_GARANTIA_SOLICITUD A " +
                 "  INNER JOIN CREDITO.CR_OPERACIONES B " +
                 "       ON A.NUM_SOLICITUD = B.NUM_SOLICITUD " +
                 "   INNER JOIN CREDITO.CR_SALDOS C " +
                 "       ON B.NUM_OPERACION = C.NUM_OPERACION " +
                 " Where C.COD_TIPOSALDO = 1 AND A.NUM_GARANTIA NOT IN (SELECT NUM_GARANTIA_MADRE FROM CREDITO.CR_AVALUOS_MAD)" +
                 " ORDER BY B.FEC_CONSTITUCION DESC ";
               
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Operacion> ListadoOperaciones = new List<Operacion>();
                while (dr.Read())
                {
                    Operacion Ope = new Operacion();
                    Ope.COD_COMPANIA = dr.GetString(0);
                    Ope.DES_IDENTIFICACION = dr.GetString(1);
                    Ope.COD_CLIENTE = dr.GetInt32(2);
                    Ope.NOM_CLIENTE = dr.GetString(3);
                    Ope.NUM_OPERACION = dr.GetString(4);
                    Ope.FEC_CONSTITUCION = dr.GetDateTime(5);
                    Ope.FEC_VENCIMIENTO = dr.GetDateTime(6);
                    Ope.MON_ORIGINAL = dr.GetDecimal(7);
                    Ope.SALDO = dr.GetDecimal(8);
                    Ope.NUM_GARANTIA = dr.GetDecimal(9);
                    Ope.GARANTIASIC = dr.GetString(10);
                    Ope.ESTADO = dr.GetString(11);
                    ListadoOperaciones.Add(Ope);     
                }

                conn.Close();
                conn.Dispose();
                return ListadoOperaciones;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        /*
         Metodo tipos lista donde se consulta a la tabla de subtemas, actividades y tipo fuente financiamiento cambio climático. 
         Agregado por Diego Arguedas Rojas - R-012034 Oct-2021
     
         */
        public List<ListaFinanciamiento> ConsultarFinanciamiento()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM SUGEF.CC_XML_FINAN";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<ListaFinanciamiento> listaFinanciamiento = new List<ListaFinanciamiento>();

                while (dr.Read())
                {
                    ListaFinanciamiento LF = new ListaFinanciamiento();
                    LF.CODIGO = dr.GetInt32(0);
                    LF.FUENTE = dr.GetString(1);
                    listaFinanciamiento.Add(LF);
                }

                conn.Close();
                conn.Dispose();
                return listaFinanciamiento;

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<ListaActividades> ConsultarActividades()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM SUGEF.CC_XML_ACTIVIDADES";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<ListaActividades> listaActividades = new List<ListaActividades>();

                while (dr.Read())
                {
                    ListaActividades LA = new ListaActividades();
                    LA.CODIGO = dr.GetInt32(0);
                    LA.ACTIVIDAD = dr.GetString(1);
                    listaActividades.Add(LA);
                }

                conn.Close();
                conn.Dispose();
                return listaActividades;

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }

        public List<ListaSubTema> ConsultarSubTema()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT * FROM SUGEF.CC_XML_SUB";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<ListaSubTema> listaSubTemas = new List<ListaSubTema>();

                while (dr.Read())
                {
                    ListaSubTema LST = new ListaSubTema();
                    LST.CODIGO = dr.GetInt32(0);
                    LST.SUBTEMAS = dr.GetString(1);
                    listaSubTemas.Add(LST);
                }

                conn.Close();
                conn.Dispose();
                return listaSubTemas;

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<ListaInversiones> ConsultarInversiones()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "SELECT COD_INVERSION, DES_INVERSION FROM INVERSIONES.IN_TIPOS_INV";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<ListaInversiones> listaInversiones = new List<ListaInversiones>();

                while (dr.Read())
                {
                    ListaInversiones LST = new ListaInversiones();
                    LST.COD_INVERSION = dr.GetString(0);
                    LST.DES_INVERSION = dr.GetString(1);
                    listaInversiones.Add(LST);
                }

                conn.Close();
                conn.Dispose();
                return listaInversiones;

            }

            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<UsuarioPS> ConsultarUsuarioPS()
        {
            try
            {
                OracleDataReader dr;

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select COD_USUARIO,DES_NOMBRE from GENERAL.GL_USUARIOS WHERE ESTADO = 'A'";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<UsuarioPS> ListadoUsuariosPS = new List<UsuarioPS>();
                while (dr.Read())
                {
                    UsuarioPS UsPS = new UsuarioPS();
                    UsPS.COD_USUARIO = dr.GetString(0);
                    UsPS.DES_NOMBRE = dr.GetString(1);
                    ListadoUsuariosPS.Add(UsPS);
                }

                conn.Close();
                conn.Dispose();
                return ListadoUsuariosPS;


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Producto> ConsultarTipoProductos()
        {
            try
            {

                
                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select COD_INVERSION,DES_INVERSION from INVERSIONES.IN_TIPOS_INV WHERE IND_ALAVISTA = 'S' OR COD_INVERSION = '103' ORDER BY IN_TIPOS_INV.COD_INVERSION ASC";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<Producto> ListadoProductos = new List<Producto>();
                while (dr.Read())
                {
                    Producto objProducto = new Producto();
                    objProducto.COD_INVERSION = dr.GetString(0);
                    objProducto.DES_INVERSION = dr.GetString(1);
                    ListadoProductos.Add(objProducto);
                }
                conn.Close();
                conn.Dispose();
                return ListadoProductos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string ConsultarClienteContrato(string DES_IDENTIFICACION,string IND_INVERSION, string COD_COMPANIA)
        {
            try
            {


                
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandText = "Select ltrim(rtrim(B.COD_CLIENTE))||'>'||ltrim(rtrim(B.NUM_CONTRATO))||'>'||ltrim(rtrim(TO_CHAR(MON_SALDO_REAL,'999999999D99'))) CODIGO " +
                                   " from CLIENTES.CL_CLIENTES A INNER JOIN INVERSIONES.IN_CINVERSION B " +
                                   " on A.COD_CLIENTE = B.COD_CLIENTE  " +
                                   " WHERE A.DES_IDENTIFICACION = :DES_IDENTIFICACION AND B.IND_INVERSION = :IND_INVERSION AND COD_COMPANIA = :COD_COMPANIA AND ROWNUM = 1";
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter("DES_IDENTIFICACION", DES_IDENTIFICACION));
                cmd.Parameters.Add(new OracleParameter("IND_INVERSION", IND_INVERSION));
                cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", COD_COMPANIA));
                conn.Open();                
                string Resultado = string.Empty;
                object Resul = cmd.ExecuteScalar();
                if (Resul == null)
                {
                    Resultado = "-1>-1>-1";
                }
                else
                {
                    Resultado = Convert.ToString(Resul);
                }                
                conn.Close();
                conn.Dispose();
                return Resultado;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<LiqProduct> ConsultarProductosLiquidaciones(int tipo,DateTime Fec_Carga)
        {
            try
            {


                OracleDataReader dr;
                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                //cmd.CommandText = "Select * from DB_UTILIDADES.UT_LIQUIDACIONSOBRANTES order by FEC_CARGA desc";
                if (tipo == 1)
                {
                    cmd.CommandText = "Select DES_IDENTIFICACION, MON_APLICADO, COD_CUENTA,COD_INVERSION, COD_USUARIO_CARGA, FEC_CARGA, FEC_LIQUIDA, COD_USUARIO_LIQUIDA, COD_COMPANIA, NUM_CONTRATO from DB_UTILIDADES.UT_LIQUIDACIONSOBRANTES where FEC_LIQUIDA = to_date('01/01/1900','DD/MM/YYYY') order by FEC_CARGA desc";
                }
                else
                {
                    cmd.CommandText = "Select DES_IDENTIFICACION, MON_APLICADO, COD_CUENTA,COD_INVERSION, COD_USUARIO_CARGA, FEC_CARGA, FEC_LIQUIDA, COD_USUARIO_LIQUIDA, COD_COMPANIA, NUM_CONTRATO " +
                                      "from DB_UTILIDADES.UT_LIQUIDACIONSOBRANTES Where to_char(FEC_CARGA,'DD/MM/YYYY') = to_char(:FEC_CARGA,'DD/MM/YYYY') and FEC_LIQUIDA = to_date('01/01/1900','DD/MM/YYYY')";
                    cmd.Parameters.Add(new OracleParameter("FEC_CARGA", Convert.ToDateTime(Fec_Carga.ToString("dd/MM/yyyy"))));
                    
                    
                }
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                dr = cmd.ExecuteReader();
                List<LiqProduct> ListadoProductosLiq = new List<LiqProduct>();
                
                while (dr.Read())
                {
                    LiqProduct objLiqProduct = new LiqProduct();
                    objLiqProduct.DES_IDENTIFICACION = dr.GetString(0);
                    objLiqProduct.MON_APLICADO = dr.GetDecimal(1);
                    objLiqProduct.COD_CUENTA = dr.GetString(2);
                    objLiqProduct.COD_INVERSION = dr.GetString(3);
                    objLiqProduct.COD_USUARIO_CARGA = dr.GetString(4);
                    objLiqProduct.FEC_CARGA = dr.GetDateTime(5);
                    objLiqProduct.FEC_LIQUIDA = dr.GetDateTime(6);
                    objLiqProduct.COD_USUARIO_LIQUIDA = dr.GetString(7);
                    objLiqProduct.COD_COMPANIA = dr.GetString(8);
                    objLiqProduct.NUM_CONTRATO = dr.GetInt64(9);
                    objLiqProduct.COD_CLIENTE = Convert.ToInt32(ConsultarClienteContrato(objLiqProduct.DES_IDENTIFICACION, objLiqProduct.COD_INVERSION, objLiqProduct.COD_COMPANIA).Split('>')[0]);
                    
                    ListadoProductosLiq.Add(objLiqProduct);
                }
                conn.Close();
                conn.Dispose();
                return ListadoProductosLiq;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public object [] AplicarLiquidacion(List<LiqProduct> ListoAplicar)
        {
            
            string CadenaError = string.Empty;
            string ErrorBitacora = string.Empty;
            object[] ArregloRespuesta = new object[3]; 
            int Resultado = -1; //Para dar respuesta al proceso.
            List<string> ListadoNoLiquidados = new List<string>();
            try
            { 
                
                

                OracleTransaction transaction;


                foreach (LiqProduct item in ListoAplicar)
                {

                    //SE VALIDA QUE AUN EL MON_SALDO_REAL TENGA DINERO SINO SE CONTINUA CON EL SIGUIENTE REGISTRO

                   
                   
                    string MON_SALDO_ANT = "-1";
                    MON_SALDO_ANT = ConsultarClienteContrato(item.DES_IDENTIFICACION,item.COD_INVERSION,item.COD_COMPANIA).Split('>')[2];
                    Decimal MON_SALDO_ANTBD = -1;
                    MON_SALDO_ANTBD = Convert.ToDecimal(MON_SALDO_ANT);

                    CadenaError = "Contrato: "+item.NUM_CONTRATO.ToString()+" > Cliente: "+item.COD_CLIENTE.ToString()+" > MontoLiquidar: "+MON_SALDO_ANTBD.ToString();

                    if (MON_SALDO_ANTBD <= 0 || MON_SALDO_ANTBD < item.MON_APLICADO)
                    {
                        ListadoNoLiquidados.Add(item.DES_IDENTIFICACION + "-> Monto por liquidar: " + Convert.ToString(item.MON_APLICADO) + ", Monto actual saldo producto: " + Convert.ToString(MON_SALDO_ANTBD)); //Se guarda que personas no se lograron liquidar
                        continue;
                    }

                    DateTime FEC_MOVT = DateTime.Now;
                   

                    conn = new OracleConnection(cadena);
                    cmd = new OracleCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandTimeout = 0;
                    cmd.Connection = conn;
                    conn.Open();
                    //
                    transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);  //SE ABRE LA TRANSACCION

                    
                   
                    //SE RESTA EL SALDO AL PRODUCTO
                    cmd.Transaction = transaction;

                    //Tuve que agregar este alter ya que el dato TO_DATE(SYSDATE,'DD/MM/YYYY') lo estaba guardando en 
                    //base de datos como 13/08/0018 el año lo estaba mandando mal                    
                    cmd.CommandText = "alter session set nls_date_format = 'DD/MM/YYYY'";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "Update INVERSIONES.IN_CINVERSION " +
                                       "set MON_SALDO_REAL = MON_SALDO_REAL - :RESTAR, " +
                                       "    MON_SALDO = MON_SALDO - :RESTAR2  " +
                                       "Where NUM_CONTRATO = :NUM_CONTRATO AND COD_COMPANIA = :COD_COMPANIA AND COD_CLIENTE = :COD_CLIENTE";

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("RESTAR", item.MON_APLICADO));
                    cmd.Parameters.Add(new OracleParameter("RESTAR2", item.MON_APLICADO));
                    cmd.Parameters.Add(new OracleParameter("NUM_CONTRATO", item.NUM_CONTRATO));
                    cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", item.COD_COMPANIA));
                    cmd.Parameters.Add(new OracleParameter("COD_CLIENTE", item.COD_CLIENTE));
                    cmd.ExecuteNonQuery();

                    //SE OBTIENE EL CONSECUTIVO DE MOVIMIENTO
                    cmd.CommandText = "select IN_SEC_ND.NEXTVAL from dual";
                    int NumeroMovimiento = Convert.ToInt32(cmd.ExecuteScalar());

                    //SE REGISTRA LA NOTA DE DEBITO
                    cmd.CommandText = "INSERT INTO INVERSIONES.IN_NDBCR (COD_COMPANIA, NUM_CUENTA, NUM_MOVIMIENTO, " +
                                      " COD_TIPOMOV, NUM_DOCUMENTO, TIPO_DOCUM, COD_MONEDA, COD_CLIENTE, FEC_MOV, " +
                                      "  FEC_VALOR, MON_MOVIMIENTO, COD_ESTADO, "+
                                      "  MON_SALDO_ANT, MON_SALDO_ACT, COD_USR_SOLICITA, "+
                                      " COD_USR_APRUEBA, COD_USR_ANULA, OBSERVACIONES1, "+
                                      " OBSERVACIONES2, CTA_CONTABLE, CTA_CORRIENTE, "+
                                      " COD_COMPANIA_GENERA, COD_UBICACION_USR_SOLICITA, COD_UBICACION_USR_APRUEBA, " +
                                      " COD_UBICACION_USR_ANULA, COD_MODULO, IND_SENTINEL) "+
                                      " VALUES ( :COD_COMPANIA, :NUM_CUENTA, :NUM_MOVIMIENTO, :COD_TIPOMOV, :NUM_DOCUMENTO, :TIPO_DOCUM, " +
                                      " :COD_MONEDA, :COD_CLIENTE, :FEC_MOV, TO_DATE(SYSDATE,'DD/MM/YYYY'), :MON_MOVIMIENTO, :COD_ESTADO, :MON_SALDO_ANT, :MON_SALDO_ACT, " +
                                      " :COD_USR_SOLICITA, :COD_USR_APRUEBA, :COD_USR_ANULA, :OBSERVACIONES1, :OBSERVACIONES2, :CTA_CONTABLE, :CTA_CORRIENTE, "+
                                      " :COD_COMPANIA_GENERA, :COD_UBICACION_USR_SOLICITA, :COD_UBICACION_USR_APRUEBA, :COD_UBICACION_USR_ANULA, :COD_MODULO, :IND_SENTINEL)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", item.COD_COMPANIA));
                    cmd.Parameters.Add(new OracleParameter("NUM_CUENTA", Convert.ToInt32(item.NUM_CONTRATO)));
                    cmd.Parameters.Add(new OracleParameter("NUM_MOVIMIENTO", NumeroMovimiento)); 
                    cmd.Parameters.Add(new OracleParameter("COD_TIPOMOV", "ND"));
                    cmd.Parameters.Add(new OracleParameter("NUM_DOCUMENTO", NumeroMovimiento));
                    cmd.Parameters.Add(new OracleParameter("TIPO_DOCUM", "ND"));
                    cmd.Parameters.Add(new OracleParameter("COD_MONEDA", "COL"));
                    cmd.Parameters.Add(new OracleParameter("COD_CLIENTE", item.COD_CLIENTE));
                    cmd.Parameters.Add(new OracleParameter("FEC_MOV", FEC_MOVT));

                   // DateTime dtt = new DateTime(FEC_MOVT.Year, FEC_MOVT.Month, FEC_MOVT.Day);
                    //cmd.Parameters.Add(new OracleParameter("FEC_VALOR", dtt.ToString("dd/M/yyyy")));
                    //cmd.Parameters.Add(new OracleParameter("FEC_VALOR", FEC_MOVT.ToString("M/dd/yyyy", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"))));
                    //cmd.Parameters.Add(new OracleParameter("FEC_VALOR", "08-13-2018"));
                    //cmd.Parameters.Add(new OracleParameter("FEC_VALOR", FEC_MOVT));
                    cmd.Parameters.Add(new OracleParameter("MON_MOVIMIENTO", item.MON_APLICADO));
                    cmd.Parameters.Add(new OracleParameter("COD_ESTADO", "03"));
                    cmd.Parameters.Add(new OracleParameter("MON_SALDO_ANT", MON_SALDO_ANTBD));
                    cmd.Parameters.Add(new OracleParameter("MON_SALDO_ACT", MON_SALDO_ANTBD - item.MON_APLICADO));
                    cmd.Parameters.Add(new OracleParameter("COD_USR_SOLICITA", item.COD_USUARIO_LIQUIDA.ToUpper()));
                    cmd.Parameters.Add(new OracleParameter("COD_USR_APRUEBA", item.COD_USUARIO_LIQUIDA.ToUpper()));
                    cmd.Parameters.Add(new OracleParameter("COD_USR_ANULA", ""));
                    cmd.Parameters.Add(new OracleParameter("OBSERVACIONES1", "LIQUIDACION DE PRODUCTO "+item.COD_INVERSION+" para cliente"+item.DES_IDENTIFICACION+" desde COOPEBANK"));
                    cmd.Parameters.Add(new OracleParameter("OBSERVACIONES2", "LIQUIDACION DE PRODUCTO " + item.COD_INVERSION + " para cliente" + item.DES_IDENTIFICACION + " desde COOPEBANK"));
                    cmd.Parameters.Add(new OracleParameter("CTA_CONTABLE", ""));
                    cmd.Parameters.Add(new OracleParameter("CTA_CORRIENTE",""));
                    cmd.Parameters.Add(new OracleParameter("COD_COMPANIA_GENERA", item.COD_COMPANIA));
                    cmd.Parameters.Add(new OracleParameter("COD_UBICACION_USR_SOLICITA", "001"));
                    cmd.Parameters.Add(new OracleParameter("COD_UBICACION_USR_APRUEBA", "001"));
                    cmd.Parameters.Add(new OracleParameter("COD_UBICACION_USR_ANULA", ""));
                    cmd.Parameters.Add(new OracleParameter("COD_MODULO", "IN"));
                    cmd.Parameters.Add(new OracleParameter("IND_SENTINEL", "S"));

                    

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = " UPDATE DB_UTILIDADES.UT_LIQUIDACIONSOBRANTES " +
                                      " SET FEC_LIQUIDA = :FEC_LIQUIDA," +
                                      "     COD_USUARIO_LIQUIDA = :COD_USUARIO_LIQUIDA " +
                                      " Where NUM_CONTRATO = :NUM_CONTRATO AND FEC_CARGA = :FEC_CARGA AND COD_COMPANIA = :COD_COMPANIA AND DES_IDENTIFICACION = :DES_IDENTIFICACION";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("FEC_LIQUIDA", FEC_MOVT));
                    cmd.Parameters.Add(new OracleParameter("COD_USUARIO_LIQUIDA", item.COD_USUARIO_LIQUIDA.ToUpper()));
                    cmd.Parameters.Add(new OracleParameter("NUM_CONTRATO", item.NUM_CONTRATO));
                    cmd.Parameters.Add(new OracleParameter("FEC_CARGA", item.FEC_CARGA));
                    cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", item.COD_COMPANIA));                   
                    cmd.Parameters.Add(new OracleParameter("DES_IDENTIFICACION", item.DES_IDENTIFICACION));
                    cmd.ExecuteNonQuery();


                    transaction.Commit();
              }

                conn.Close();
                conn.Dispose();
                cmd.Dispose();
                Resultado = 1;

            }
            catch (Exception ex)
            {

                ErrorBitacora = DateTime.Now.ToString() + "->" + Environment.UserName + "->" + Environment.MachineName + Environment.NewLine + "[(CapaDatos)_AplicarLiquidacion]" + "->[" + ex.Message + "] ->[" + CadenaError + "]";
                using (System.IO.FileStream fs = new System.IO.FileStream(@"\\hefesto\CoopeBan\Bitacora.txt", FileMode.Append))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(Environment.NewLine+ErrorBitacora);
                    fs.Write(info, 0, info.Length);
                    
                }
                throw new Exception("[(CapaDatos)_AplicarLiquidacion]", ex);             
              
                
            }

            ArregloRespuesta[0] = Resultado;
            ArregloRespuesta[1] = ErrorBitacora;
            ArregloRespuesta[2] = ListadoNoLiquidados;
            return ArregloRespuesta;

        }

        public int RegistrarUT_LIQUIDACIONSOBRANTES(List<LiqProduct> ListadoProductosLiquidar)
        {
            try
            {

                //conn = new OracleConnection(cadena);
                //cmd = new OracleCommand();
                //cmd.CommandText = "Update INVERSIONES.IN_CINVERSION "+
                //                  "set MON_SALDO_REAL = :MON_SALDO_REAL, "+
                //                  "  MON_SALDO = :MON_SALDO_REAL,  "+
                //                  "Where "     

                conn = new OracleConnection(cadena);
                cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "Insert into DB_UTILIDADES.UT_LIQUIDACIONSOBRANTES (DES_IDENTIFICACION, MON_APLICADO, COD_CUENTA, COD_INVERSION, COD_USUARIO_CARGA, FEC_CARGA,FEC_LIQUIDA, COD_USUARIO_LIQUIDA, COD_COMPANIA, NUM_CONTRATO) " +
                                      "Values (:DES_IDENTIFICACION, :MON_APLICADO, :COD_CUENTA, :COD_INVERSION, :COD_USUARIO_CARGA, :FEC_CARGA, :FEC_LIQUIDA, :COD_USUARIO_LIQUIDA, :COD_COMPANIA, :NUM_CONTRATO)";                    
                foreach (LiqProduct item in ListadoProductosLiquidar)
                {

                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new OracleParameter("DES_IDENTIFICACION", item.DES_IDENTIFICACION));
                    cmd.Parameters.Add(new OracleParameter("MON_APLICADO", item.MON_APLICADO));
                    cmd.Parameters.Add(new OracleParameter("COD_CUENTA", item.COD_CUENTA));
                    cmd.Parameters.Add(new OracleParameter("COD_INVERSION", item.COD_INVERSION));
                    cmd.Parameters.Add(new OracleParameter("COD_USUARIO_CARGA", item.COD_USUARIO_CARGA));
                    cmd.Parameters.Add(new OracleParameter("FEC_CARGA", item.FEC_CARGA));
                    cmd.Parameters.Add(new OracleParameter("FEC_LIQUIDA", item.FEC_LIQUIDA));
                    cmd.Parameters.Add(new OracleParameter("COD_USUARIO_LIQUIDA", item.COD_USUARIO_LIQUIDA));
                    cmd.Parameters.Add(new OracleParameter("COD_COMPANIA", item.COD_COMPANIA));
                    cmd.Parameters.Add(new OracleParameter("NUM_CONTRATO", item.NUM_CONTRATO));                      
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
                conn.Dispose();
                cmd.Dispose();

                return 1;


            }
            catch (Exception ex)
            {
                return 0;
                throw ex;
            }
        }

        #endregion
        #region "Metodos"

        public List<Modulos> ConsultarModulos()
        {
         
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.Modulos.ToList();
            }
        }

        public List<SubOpciones> ConsultarSubOpciones()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.SubOpciones.ToList();
            }
        }

        public List<Permisos> ConsultarPermisos()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.Permisos.ToList();
            }
        }

        public List<Pantallas> ConsultarPantallas()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.Pantallas.ToList();
            }
        }

        public List<Usuarios> ConsultarUsuarios()
        {
            try
            {
                using (CoopeBankEntities bd = new CoopeBankEntities())
                {

                   
                    return bd.Usuarios.ToList();
                   
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
        }

        public void AgregarUsuario(Usuarios objUsuario)
        {


           
            string ErrorBitacora = string.Empty;
           
            try
            {

                using (CoopeBankEntities bd = new CoopeBankEntities())
                {
                    bd.Usuarios.Add(objUsuario);
                    bd.SaveChanges();
                }

              


            }
            catch (Exception ex)
            {

                //ErrorBitacora = DateTime.Now.ToString() + "->" + Environment.UserName + "->" + Environment.MachineName + Environment.NewLine + "[(CapaDatos)_AgregarUsuario]" + "->[" + ex.Message + "]";
                //using (System.IO.FileStream fs = new System.IO.FileStream(@"\\hefesto\CoopeBan\Bitacora.txt", FileMode.Append))
                //using (System.IO.FileStream fs = new System.IO.FileStream(@"C:\archvivo\Bitacora.txt", FileMode.Append))
                //{
                //    byte[] info = new UTF8Encoding(true).GetBytes(Environment.NewLine + ErrorBitacora);
                //    fs.Write(info, 0, info.Length);

                //}
                throw new Exception("[(CapaDatos)_AgregarUsuario]", ex);


            }
            
           

            

        }

        public void ModificarUsuario(Usuarios objUsuario)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                Usuarios aux = bd.Usuarios.SingleOrDefault(x => x.IdUsuario == objUsuario.IdUsuario);
                if (aux != null)
                {
                     //bd.Usuarios.Attach(objUsuario);
                    aux.Usuario = objUsuario.Usuario;
                    aux.Nombre = objUsuario.Nombre;
                    aux.Apellido1 = objUsuario.Apellido1;
                    aux.Apellido2 = objUsuario.Apellido2;
                    aux.CambiarClave = objUsuario.CambiarClave;
                    aux.Clave = objUsuario.Clave;
                    aux.Correo = objUsuario.Correo;
                    aux.Estado = objUsuario.Estado;
                    
                     
                    
                   // bd.Entry(objUsuario).State = System.Data.Entity.EntityState.Modified;
                    //bd.Usuarios.Add(objUsuario);
                    bd.Entry(aux).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
        }

        public void EliminarUsuario(Usuarios objUsuario)
        {
             using (CoopeBankEntities bd = new CoopeBankEntities())
             {
                Usuarios aux = bd.Usuarios.SingleOrDefault(x => x.IdUsuario == objUsuario.IdUsuario);
                if (aux != null)
                {
                    bd.Usuarios.Remove(aux);
                    bd.SaveChanges();
                }
             }
        }

        public void AgregarPermiso(Permisos objPermisos)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                bd.Permisos.Add(objPermisos);
                bd.SaveChanges();
            }
        }

        public void ModificarPermisos(Permisos objPermisos)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                Permisos aux = bd.Permisos.SingleOrDefault(x => x.IdUsuario == objPermisos.IdUsuario && x.IdObjeto == objPermisos.IdObjeto);
                if (aux != null)
                {
                    //bd.Usuarios.Attach(objUsuario);
                    aux.Visible = objPermisos.Visible;
                    aux.Lectura = objPermisos.Lectura;
                    aux.Borrado = objPermisos.Borrado;
                    aux.Escritura = objPermisos.Escritura;



                    // bd.Entry(objUsuario).State = System.Data.Entity.EntityState.Modified;
                    //bd.Usuarios.Add(objUsuario);
                    bd.Entry(aux).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
        }

        public void EliminarPermiso(Permisos objPermiso)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                Permisos aux = bd.Permisos.Where(x=>x.IdUsuario == objPermiso.IdUsuario && x.IdObjeto == objPermiso.IdObjeto).FirstOrDefault();
                bd.Permisos.Remove(aux);
                bd.SaveChanges();
            }
        }

        public void AgregarBitaAhorro(AHORROS_BIT_TRAS ahorroBit)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                bd.AHORROS_BIT_TRAS.Add(ahorroBit);
                bd.SaveChanges();
            }
        }

        //Mostrar los datos de la nomina seleccionada. Creado machaves
        public IEnumerable<consultarNominaPago_Result> listarNominaPorTipo(DateTime fecPago, string tipoNomina)
        {
            using (var context = new CoopeBankEntities())
            {
                IEnumerable<consultarNominaPago_Result> detalleNom = context.consultarNominaPago(fecPago, tipoNomina).ToArray();
                return detalleNom;
            }
        }
        //Listar el tipo de nominas que existen. Creado machaves
        public List<vTipoNomina> ConsultarTipoNomina()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.vTipoNomina.ToList();
            }
        }

        //Actualizar los consecutivos en la tabla parametros. Creado machaves
        public void ActualizarParametrosCGP(ParametrosArcCGP ObjModif)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                ParametrosArcCGP aux = bd.ParametrosArcCGP.SingleOrDefault(x => x.IdRegistro == 1);
                if (aux != null)
                {
                    aux.IdNumEnvio = ObjModif.IdNumEnvio;
                    aux.IdConsecutivo = ObjModif.IdConsecutivo;
                    aux.FecGeneracion = ObjModif.FecGeneracion;
                   // aux.CodServicio = ObjModif.CodServicio;
                    aux.FecModificacion = ObjModif.FecModificacion;
                    bd.Entry(aux).State = System.Data.Entity.EntityState.Modified;
                    bd.SaveChanges();
                }
            }
        }
        //Mostrar los parametros existentes. Creado machaves
        public List<ParametrosArcCGP> ConsultarParametrosArcCGP()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.ParametrosArcCGP.ToList();
            }
        }
        //Mostrar los servicios sinpe. Creado machaves
        public List<TipoServicioSinpe> ConsultarServiciosSinpe()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.TipoServicioSinpe.ToList();
            }
        }

        //guardar los registros del grid en la tabla cargaPagosCGP machaves
        public void RegistroTablaPago(CargaPagosCGP cargaPagosCGP)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                bd.CargaPagosCGP.Add(cargaPagosCGP);
                bd.SaveChanges();
            }
        }

        //Mostrar los datos de los pagos cgp. Creado machaves
        public IEnumerable<consultarPagosCGP_Result> listarPagosCGP(string tipoMoneda)
        {
            using (var context = new CoopeBankEntities())
            {
                IEnumerable<consultarPagosCGP_Result> detallePago = context.consultarPagosCGP(tipoMoneda).ToArray();
                return detallePago;
            }
        }

        //Eliminar datos tabla pagos cgp machaves
        public void EliminarDatosPagoCGP(CargaPagosCGP objPagos)
        {
            //Mejora para que elimine todos los registros cargados a la tabla de acuerdo al usuario fecCreacion 21/01/2018 
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                var rows = from o in bd.CargaPagosCGP
                           select o;
                foreach (var row in rows)
                {
                    bd.CargaPagosCGP.Remove(row);
                }
                bd.SaveChanges();

            }
        }

        public List<Parametros> ObtenerParametrosPIN()
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                return bd.Parametros.ToList();
            }
        }

        public void ActualizarConsecutivosPIN(string IdKey, int Consecutivo)
        {
            using (CoopeBankEntities bd = new CoopeBankEntities())
            {
                var aux = bd.Parametros.Where(x => x.IdKey == IdKey).FirstOrDefault();
                if (aux != null)
                {
                    aux.Valor = Consecutivo.ToString().PadLeft(12, '0');
                    bd.SaveChanges();
                }
            }
        }

        #endregion

    }
}
