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
using Datos.EntidadesAux.ComparabilidadFinanciera;
using System.Configuration;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmXML_ICFPC : Form
    {
        CapaLogica objLogica;
        ProductoFinanciero objAuxProductoFinanciero;
        List<ProductoFinanciero> ListadoProductosFinancieros;
        List<Cargo> ListadoCargosProducto;

        public FrmXML_ICFPC()
        {
            InitializeComponent();
            Obtener_ProductosFinancieros();
            Obtener_CargosProductos();
        }

        #region "Metodos de formulario"

        void Obtener_CargosProductos()
        {
            objLogica = new CapaLogica();
            ListadoCargosProducto = objLogica.Obtener_CargosProducto();
        }

        void Obtener_ProductosFinancieros()
        {
            objLogica = new CapaLogica();
            ListadoProductosFinancieros = objLogica.Obtener_ProductosFinancieros();            
            
        }

        void Cargar_CmbTipoProducto()
        {
            //Catalogo Tipo Cetegoria crediticia
            Cmb_TipoProducto.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x=>x.NomCatalogo == "TCC").ToList();
            Cmb_TipoProducto.ValueMember = "Codigo";
            Cmb_TipoProducto.DisplayMember = "Campo1";
            Cmb_TipoProducto.SelectedIndex = 0;

            //Catalogo Tipos Uso
            Cmb_TipoUso.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TU").ToList();
            Cmb_TipoUso.ValueMember = "Codigo";
            Cmb_TipoUso.DisplayMember = "Campo1";
            Cmb_TipoUso.SelectedIndex = 0;

            //Catalogo Tipos Generador
            Cmb_TipoGenerador.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TG").ToList();
            Cmb_TipoGenerador.ValueMember = "Codigo";
            Cmb_TipoGenerador.DisplayMember = "Campo1";
            Cmb_TipoGenerador.SelectedIndex = 0;

            //Catalogo Tipos Cliente
            Cmb_TipoCliente.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TC").ToList();
            Cmb_TipoCliente.ValueMember = "Codigo";
            Cmb_TipoCliente.DisplayMember = "Campo1";
            Cmb_TipoCliente.SelectedIndex = 0;

            //Catalogo Tipos Moneda
            Cmb_TipoMoneda.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TM").ToList();
            Cmb_TipoMoneda.ValueMember = "Codigo";
            Cmb_TipoMoneda.DisplayMember = "Campo1";
            Cmb_TipoMoneda.SelectedIndex = 0;

            //Catalogo Tipos Tasa
            Cmb_TipoTasa.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TT").ToList();
            Cmb_TipoTasa.ValueMember = "Codigo";
            Cmb_TipoTasa.DisplayMember = "Campo1";
            Cmb_TipoTasa.SelectedIndex = 0;
        }

        void Cargar_GridProdFinancieros()
        {
            DgProductos.DataSource = ListadoProductosFinancieros;
        }

        void Cargar_GridCargProductos()
        {

            if (objAuxProductoFinanciero != null)
            {
                DgCargos.DataSource = (from n in ListadoCargosProducto
                                       where n.CodigoProducto == objAuxProductoFinanciero.CodigoProducto
                                       orderby n.TipoCargo descending
                                       select new
                                       {
                                           pObsCargo = n.ObsCargo,
                                           pTipoCargo = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TCP" && x.Codigo == n.TipoCargo).FirstOrDefault().Campo1,
                                           pTipoValorCargo = n.TipoValorCargo == 1 ? "Porcentaje" : "Monto",
                                           pValorCargo = n.ValorCargo
                                       }).ToList();
            }
           
        }

        void Carga_DatosCombos()
        {
            Cmb_TipoProducto.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoProducto"].Value);
            Cmb_TipoUso.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoUso"].Value);
            Cmb_TipoGenerador.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoGenerador"].Value);
            Cmb_TipoCliente.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoCliente"].Value);
            Cmb_TipoMoneda.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoMoneda"].Value);
            Cmb_TipoTasa.SelectedValue = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_TipoTasa"].Value);
            TxtObsTasa.Text = Convert.ToString(DgProductos.CurrentRow.Cells["dgCol_ObsTasa"].Value);
        }

        #endregion

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmXML_ICFPC_Load(object sender, EventArgs e)
        {
            //EstablecerUltEncabezado();
            Cargar_GridProdFinancieros();
            Cargar_CmbTipoProducto();
            DgProductos.Rows[0].Selected = true;
            Carga_DatosCombos();
            ComboTipoPersona.SelectedIndex = 0;
            Cargar_GridCargProductos();

            //Se carga el grido de cargos

        }        

        private void DgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int pCod = Convert.ToInt32(DgProductos.CurrentRow.Cells["dgCol_Codigo"].Value);
            objAuxProductoFinanciero = ListadoProductosFinancieros.Where(x => x.CodigoProducto == pCod).FirstOrDefault();
            Carga_DatosCombos();
            Cargar_GridCargProductos();
        }



        void EstablecerUltEncabezado()
        {
            objLogica = new CapaLogica();
            EncabezadoXML oEnca = objLogica.Obtener_EncabezadoXML().FirstOrDefault();
            if (oEnca != null)
            {
                TxtContacto.Text = oEnca.NombreContacto.ToUpper();
                TxtCorreo.Text = oEnca.CorreoContacto.ToUpper();
                //TxtArchivo.Text = oEnca.NombreArchivo.ToUpper();
                ComboTipoPersona.SelectedIndex = oEnca.TipoPersona == enum_TipoPersona.Juridica ? 0 : 2;
                TxtTelefono.Text = oEnca.TelContacto;
                DtPeriodo.Value = Convert.ToDateTime(oEnca.Periodo);
            }
        }

        object[] ObtenerEncabezado()
        {
            object[] DatosEncabezado =
                  {
                        TxtContacto.Text.Trim(),
                        TxtCorreo.Text.Trim(),
                        TxtArchivo.Text.Trim(),
                        ComboTipoPersona.SelectedIndex,
                        TxtTelefono.Text.Trim(),
                        DtPeriodo.Value.ToString("dd/MM/yyyy"),
                        "ICFPC",
                        "3004045110"
                    };
            return DatosEncabezado;
        }

        private void BtnGenerarXML_Click(object sender, EventArgs e)
        {

          


            if (!ValidarEncabezado())
            {
                MessageBox.Show("Debe completar todos los datos del encabezado", "VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            
            object[] DatosEncabezado = ObtenerEncabezado();

            //Crear XML ListaProductos
            string xmlListaProductos = ToolSistema.CreateXmlDocumentToDB<ProductoFinanciero>(ListadoProductosFinancieros, ToolSistema.listadoEtiquetasProductos);
            string xmlListaCargos = ToolSistema.CreateXmlDocumentToDB<Cargo>(ListadoCargosProducto, ToolSistema.listadoEtiquetasCargos);
            
            objLogica = new CapaLogica();
            object [] Respuesta = objLogica.Gen_XML_Comparabilidad_BCCR(DatosEncabezado, xmlListaProductos, xmlListaCargos);
           
            
            if (Convert.ToInt32(Respuesta[0]) == -1)
            {
                MessageBox.Show(Convert.ToString(Respuesta[1]), "ERRROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ToolSistema.PrintXML(Respuesta);
                MessageBox.Show("XML ID= " + Respuesta[0].ToString() + " generado con exito!!", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool ValidarEncabezado()
        {
            bool valido = true;
            foreach (Control item in this.Controls)
            {

                if (item is GroupBox)
                {
                    foreach (Control itGrop in this.groupBox1.Controls)
                    {

                        if (itGrop is TextBox)
                        {
                            valido = itGrop.Text == string.Empty ? false : true;
                            if (!valido)
                            {
                                break;
                            }
                        }
                    }

                }

                if (!valido)
                {
                    break;
                }

                
            }

            return valido;


        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        void HabilitarCtrlEnca(bool vHabilitar)
        {
            //TxtArchivo.Enabled = vHabilitar;
            TxtContacto.Enabled = vHabilitar;
            TxtCorreo.Enabled = vHabilitar;
            TxtTelefono.Enabled = vHabilitar;
            ComboTipoPersona.Enabled = vHabilitar;
            DtPeriodo.Enabled = vHabilitar;
        }

        void HabilitarCtrlDeta(bool vHabilitar)
        {
            Cmb_TipoProducto.Enabled = vHabilitar;
            Cmb_TipoUso.Enabled = vHabilitar;
            //Cmb_TipoTasa.Enabled = vHabilitar;
            Cmb_TipoCliente.Enabled = vHabilitar;
            Cmb_TipoGenerador.Enabled = vHabilitar;
            //Cmb_TipoMoneda.Enabled = vHabilitar;
            TxtObsTasa.Enabled = vHabilitar;
        }

        private void BtnModiEnca_Click(object sender, EventArgs e)
        {
            if (BtnModiEnca.Text == "Modificar")
            {
                BtnModiEnca.Text = "Guardar";
                HabilitarCtrlEnca(true);               
                return;
            }

            if (BtnModiEnca.Text == "Guardar")
            {
                BtnModiEnca.Text = "Modificar";
                HabilitarCtrlEnca(false);
                return;
            }


            }

        private void BtnGuardarDetProd_Click(object sender, EventArgs e)
        {
            

            if (BtnGuardarDetProd.Text == "Modificar")
            {
                BtnGuardarDetProd.Text = "Guardar";
                HabilitarCtrlDeta(true);
                return;
            }

            if (BtnGuardarDetProd.Text == "Guardar")
            {
                BtnGuardarDetProd.Text = "Modificar";
                HabilitarCtrlDeta(false);
                objAuxProductoFinanciero.TipoProducto = Convert.ToInt32(Cmb_TipoProducto.SelectedValue);
                objAuxProductoFinanciero.TipoUso = Convert.ToInt32(Cmb_TipoUso.SelectedValue);
                objAuxProductoFinanciero.TipoTasa = Convert.ToInt32(Cmb_TipoTasa.SelectedValue);
                objAuxProductoFinanciero.TipoCliente = Convert.ToInt32(Cmb_TipoCliente.SelectedValue);
                objAuxProductoFinanciero.TipoGenerador = Convert.ToInt32(Cmb_TipoGenerador.SelectedValue);
                objAuxProductoFinanciero.TipoMoneda = Convert.ToInt32(Cmb_TipoMoneda.SelectedValue);
                objAuxProductoFinanciero.ObsTasa = TxtObsTasa.Text.Trim().ToUpper();
                return;
            }
        }
    }
}
