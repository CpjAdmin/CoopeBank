using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.EntidadesAux.ComparabilidadFinanciera;
using Logica;

namespace AppEscritorio.Colocaciones
{
   
    public partial class FrmMedioElectronico : Form
    {
        
        List<Cargo> ListaCargosMedio { get; set; }
        MedioPago objMedioPago { get; set; }
        CapaLogica objLogica;

        bool ModificarCargo = false;

        public FrmMedioElectronico()
        {
            InitializeComponent();
            ListaCargosMedio = new List<Cargo>();
            Cargar_Combos();



        }

        public FrmMedioElectronico(MedioPago oMedioPago)
        {
            InitializeComponent();
            objMedioPago = oMedioPago;
            Cargar_Combos();
            CargarControles();
            BtnNuevoMedio.Text = "Modificar";
            HabilitarCtrlCargo(false);
            HabilitarCtrlMed(true);
            if (objMedioPago.ListadoCargosMedio.Count <= 0)
            {
                BtnEliminarCargo.Enabled = false;
                BntModificarCargo.Enabled = false;
                
            }
        }

        void CargarControles()
        {
            CmbTipoMedio.SelectedValue = objMedioPago.TipoMedio;
            CmbMarcaMedio.Text = objMedioPago.MarcaMedio;
            TxtNombreMedio.Text = objMedioPago.NombreMedio;
            CmbTipoMoneda.SelectedValue = objMedioPago.TipoMoneda;
            TxtLineaCredito.Text = /*"₡" +*/ String.Format("{0:N2}", objMedioPago.LineaCredito);
            TxtPlazo.Text = objMedioPago.Plazo.ToString();
            TxtPlazoMaximo.Text = objMedioPago.PlazoMaximo.ToString();
            TxtLugares.Text = objMedioPago.Lugares.ToString();
            //TxtCobertura.Text = objMedioPago.Cobertura.ToString();
            CmbCobertura.SelectedValue = objMedioPago.Cobertura;
            TxtObs.Text = objMedioPago.Observaciones;
            TxtBeneficios.Text = objMedioPago.Beneficios;
            ListaCargosMedio = objMedioPago.ListadoCargosMedio;            
            CargaGridCargosMedio();
            HabilitarCtrlMed(true);
            HabilitarCtrlCargo(true);
        }

        void Cargar_Combos()
        {
            //Catalogo Tipo Cargo
            CmbTipoCargo.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TCM").ToList();
            CmbTipoCargo.ValueMember = "Codigo";
            CmbTipoCargo.DisplayMember = "Campo1";
            CmbTipoCargo.SelectedIndex = 0;

            //Catalogo Tipos Valor Cargo
            CmbTipoValorCargo.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TVC").ToList();
            CmbTipoValorCargo.ValueMember = "Codigo";
            CmbTipoValorCargo.DisplayMember = "Campo1";
            CmbTipoValorCargo.SelectedIndex = 0;


            //Catalogo Tipos Moneda Cargo
            CmbTipoMonedaCargo.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TM").ToList();
            CmbTipoMonedaCargo.ValueMember = "Codigo";
            CmbTipoMonedaCargo.DisplayMember = "Campo1";
            CmbTipoMonedaCargo.SelectedIndex = 0;

            //Catalogo Tipo Medio electronico
            CmbTipoMedio.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TME").ToList();
            CmbTipoMedio.ValueMember = "Codigo";
            CmbTipoMedio.DisplayMember = "Campo1";
            CmbTipoMedio.SelectedIndex = 0;


            //Catalogo Tipo Medio electronico
            CmbMarcaMedio.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TTE").ToList();
            CmbMarcaMedio.ValueMember = "Codigo";
            CmbMarcaMedio.DisplayMember = "Campo1";
            CmbMarcaMedio.SelectedIndex = 0;


            //Catalogo Tipos Moneda Cargo
            CmbTipoMoneda.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TM").ToList();
            CmbTipoMoneda.ValueMember = "Codigo";
            CmbTipoMoneda.DisplayMember = "Campo1";
            CmbTipoMoneda.SelectedIndex = 0;

            //Catalogo de Cobertura
            CmbCobertura.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TCO").ToList();
            CmbCobertura.ValueMember = "Codigo";
            CmbCobertura.DisplayMember = "Campo1";
            CmbCobertura.SelectedIndex = 0;







        }

        void CrearMedioPago(char tipo)
        {

            
            if (tipo == 'N')
            {
                objMedioPago = new MedioPago();
                objMedioPago.CodigoProducto = "M";
            }
            else
            {
                objMedioPago.CodigoProducto = "M"+ objMedioPago.CodigoProducto;
            }
            
            
            objMedioPago.TipoMedio = Convert.ToInt32(CmbTipoMedio.SelectedValue);
            if (objMedioPago.TipoMedio <= 2)
            {
                objMedioPago.MarcaMedio = CmbMarcaMedio.Text;
            }
            else
            {
                objMedioPago.MarcaMedio = "NA";
            }
            objMedioPago.NombreMedio = TxtNombreMedio.Text;
            objMedioPago.TipoMoneda = Convert.ToInt32(CmbTipoMoneda.SelectedValue);
            objMedioPago.LineaCredito = Convert.ToDouble(TxtLineaCredito.Text/*.Substring(1)*/);
            objMedioPago.Plazo = Convert.ToInt32(TxtPlazo.Text);
            objMedioPago.PlazoMaximo = Convert.ToInt32(TxtPlazoMaximo.Text);
            objMedioPago.Lugares = Convert.ToInt32(TxtLugares.Text);
            objMedioPago.Cobertura = Convert.ToInt32(CmbCobertura.SelectedValue);
            objMedioPago.Observaciones = TxtObs.Text;
            objMedioPago.Beneficios = TxtBeneficios.Text;

            if (ListaCargosMedio.Count > 0)
            {
                foreach (var item in ListaCargosMedio)
                {
                    if (item.CodTipoCobro.Trim().Length <= 0)
                    {
                        item.CodTipoCobro = "ZZ";
                    }
                }
                objMedioPago.ListadoCargosMedio = ListaCargosMedio;

                objMedioPago.pXML_ListaCargos = ToolSistema.CreateXmlDocumentToDB<Cargo>(ListaCargosMedio, ToolSistema.listadoEtiquetasCargos_ICFMP);
            }
            else
            {
                Cargo oCargo = new Cargo();
                oCargo.CodigoProducto = -99;
                oCargo.CodTipoCobro = string.Empty;
                oCargo.TipoCargo = -1;
                oCargo.TipoValorCargo = -1;
                oCargo.ValorCargo = 0.00;
                oCargo.TipoMonedaCargo = -1;
                oCargo.ObsCargo = string.Empty;
                ListaCargosMedio.Add(oCargo);
                objMedioPago.pXML_ListaCargos = ToolSistema.CreateXmlDocumentToDB<Cargo>(ListaCargosMedio, ToolSistema.listadoEtiquetasCargos_ICFMP);
            }
           

            //string xmlListaCargos = ToolSistema.CreateXmlDocumentToDB<Cargo>(ListadoCargosProducto, ToolSistema.listadoEtiquetasCargos);



        }

        void InicializarControlesMedio()
        {
            CmbTipoMedio.SelectedIndex = 0;
            CmbMarcaMedio.SelectedIndex = 0;
            TxtNombreMedio.Text = string.Empty;
            CmbTipoMoneda.SelectedIndex = 0;
            TxtLineaCredito.Text = "0.00";
            TxtPlazo.Text = "0";
            TxtPlazoMaximo.Text = "0";
            TxtLugares.Text = "0";
            CmbCobertura.SelectedIndex = 0;
            TxtObs.Text = string.Empty;
            TxtBeneficios.Text = string.Empty;
        }

        void InicializarControlesCargo()
        {
            CmbTipoCargo.SelectedIndex = 0;
            TxtValorCargo.Text = "0.00";
            CmbTipoValorCargo.SelectedIndex = 0;
            CmbTipoMonedaCargo.SelectedIndex = 0;
            TxtObsCargos.Text = string.Empty;  
        }

        void HabilitarCtrlMed(bool vHabilitar)
        {
            CmbTipoMedio.Enabled = vHabilitar;
            CmbMarcaMedio.Enabled = vHabilitar;
            TxtNombreMedio.Enabled = vHabilitar;
            CmbTipoMoneda.Enabled = vHabilitar;
            TxtLineaCredito.Enabled = vHabilitar;
            TxtPlazo.Enabled = vHabilitar;
            TxtPlazoMaximo.Enabled = vHabilitar;
            TxtLugares.Enabled = vHabilitar;
            CmbCobertura.Enabled = vHabilitar;
            TxtObs.Enabled = vHabilitar;
            TxtBeneficios.Enabled = vHabilitar;
        }

        void HabilitarCtrlCargo(bool vHabilitar)
        {
            CmbTipoCargo.Enabled = vHabilitar;
            TxtValorCargo.Enabled = vHabilitar;
            CmbTipoValorCargo.Enabled = vHabilitar;
            CmbTipoMonedaCargo.Enabled = vHabilitar;
            TxtObsCargos.Enabled = vHabilitar;
            BtnRegCargoMedio.Enabled = vHabilitar;
            BtnEliminarCargo.Enabled = vHabilitar;
            BntModificarCargo.Enabled = vHabilitar;
            //DgCargosMedio.Enabled = vHabilitar;

        }

        private void BtnNuevoMedio_Click(object sender, EventArgs e)
        {


            //string dato = ((List<CatalogoBCCR>)CmbTipoCargo.DataSource).Where(x => x.Codigo == 3).FirstOrDefault().Campo1;
            //MessageBox.Show(dato);

            if (BtnNuevoMedio.Text == "Modificar")
            {
                if (!ValidarEncabezado(this.Controls, this.groupBox3.Controls))
                {
                    MessageBox.Show("Debe completar todos los datos del nuevo medio", "VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (ListaCargosMedio.Count <= 0)
                {

                    DialogResult dr2 = MessageBox.Show(null, "El medio no tiene cargos registrados, desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.No)
                    {
                        return;
                    }

                }

                DialogResult dr = MessageBox.Show(null, "Confirmación de modificación de Medio de Pago", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CrearMedioPago('M');                    
                    objLogica = new CapaLogica();
                    object[] Respuesta = objLogica.Modificar_MedioPago(objMedioPago);
                    MessageBox.Show(Convert.ToString(Respuesta[1]));
                    BtnNuevoMedio.Text = "Nuevo";
                    InicializarControlesMedio();
                    InicializarControlesCargo();
                    HabilitarCtrlMed(false);
                    HabilitarCtrlCargo(false);
                    ListaCargosMedio = new List<Cargo>();
                    CargaGridCargosMedio();
                }

                return;
            }

            if (BtnNuevoMedio.Text == "Nuevo")
            {
                //Si se va a crear un medio nuevo, debe inicializar la lista donde se agregaran los nuevos cargos
                ListaCargosMedio = new List<Cargo>();
                CargaGridCargosMedio();
                HabilitarCtrlMed(true);
                BtnRegCargoMedio.Enabled = true;
                BtnEliminarCargo.Enabled = true;
                InicializarControlesMedio();
                InicializarControlesCargo();
                BtnNuevoMedio.Text = "Guardar";
                CmbTipoMedio.Focus();
            }
            else
            {

                if (!ValidarEncabezado(this.Controls, this.groupBox3.Controls))
                {
                    MessageBox.Show("Debe completar todos los datos del nuevo medio", "VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                if (ListaCargosMedio.Count <= 0) { 

                    DialogResult dr2 = MessageBox.Show(null, "El medio no tiene cargos registrados, desea continuar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr2 == DialogResult.No)
                    {
                        return;
                    }                

                }


                DialogResult dr = MessageBox.Show(null, "Confirmación de registro de Medio de Pago", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    CrearMedioPago('N');
                    objLogica = new CapaLogica();
                    object[] Respuesta = objLogica.Registrar_MedioPago(objMedioPago);
                    MessageBox.Show(Convert.ToString(Respuesta[1]));
                    BtnNuevoMedio.Text = "Nuevo";
                    InicializarControlesMedio();
                    InicializarControlesCargo();
                    HabilitarCtrlMed(false);
                    HabilitarCtrlCargo(false);
                    ListaCargosMedio = new List<Cargo>();
                }

            }
        }

        

        void CargaGridCargosMedio()
        {
            //foreach (Cargo item in ListaCargosMedio)
            //{
            //    Console.WriteLine(item.CodigoProducto + item.CodTipoCobro + item.ObsCargo + item.TipoCargo + item.TipoMonedaCargo + item.TipoValorCargo + item.ValorCargo);
            //}

            DgCargosMedio.DataSource = (from n in ListaCargosMedio
                                        select new
                                        {
                                            pCodigoProducto = n.CodigoProducto,
                                            pCodTipoCobro = n.CodTipoCobro,
                                            pTipoCargo = n.TipoCargo,
                                            pValorCargo = n.ValorCargo,
                                            pTipoValorCargo = n.TipoValorCargo,
                                            pObsCargo = n.ObsCargo,
                                            pDesTipoCargo = ((List<CatalogoBCCR>)CmbTipoCargo.DataSource).Where(x => x.Codigo == n.TipoCargo).FirstOrDefault().Campo1,
                                            pDesTipoValor = ((List<CatalogoBCCR>)CmbTipoValorCargo.DataSource).Where(x => x.Codigo == n.TipoValorCargo).FirstOrDefault().Campo1,
                                            pTipoMonedaCargo = n.TipoMonedaCargo
                                        }).ToList();


        }

        void CargarDatosCtrlCargos()
        {
            if (DgCargosMedio.Rows.Count <= 0)
            {
                return;
            }

            CmbTipoCargo.SelectedValue = Convert.ToInt32(DgCargosMedio.CurrentRow.Cells["dgCol_TipoCargo"].Value);
            TxtValorCargo.Text = DgCargosMedio.CurrentRow.Cells["dgCol_ValorCargo"].Value.ToString();
            CmbTipoValorCargo.SelectedValue = Convert.ToInt32(DgCargosMedio.CurrentRow.Cells["dgCol_TipoValorCargo"].Value);
            CmbTipoMonedaCargo.SelectedValue = Convert.ToInt32(DgCargosMedio.CurrentRow.Cells["dgCol_TipoMonedaCargo"].Value);
            TxtObsCargos.Text = DgCargosMedio.CurrentRow.Cells["dgCol_ObsCargo"].Value.ToString();
        }

        void CajasTexto_Enter(object sender, EventArgs e)
        {
            TextBox CajaTexto = sender as TextBox;
            CajaTexto.Text = string.Empty;


        }

        private void BtnRegCargoMedio_Click(object sender, EventArgs e)
        {

            

            //foreach (var item in ListaCargosMedio)
            //{
            //    Console.WriteLine(item.CodigoProducto + " " + item.CodTipoCobro + " " + item.ObsCargo + " " + item.TipoCargo + " " + item.TipoMonedaCargo +
            //                       item.TipoValorCargo + " " + item.ValorCargo);
            //}



            if (BtnRegCargoMedio.Text == "Nuevo")
            {
                HabilitarCtrlCargo(true);
                InicializarControlesCargo();
                BtnRegCargoMedio.Text = "Guardar";
                CmbTipoCargo.Focus();
                BntModificarCargo.Enabled = false;
                BtnEliminarCargo.Enabled = false;
            }
            else
            {
                if (ModificarCargo)
                {
                    var auxCargo = ListaCargosMedio.Where(x => x.CodTipoCobro == DgCargosMedio.CurrentRow.Cells["dgCol_CodTipoCobro"].Value.ToString()).FirstOrDefault();
                    if (auxCargo != null)
                    {
                        auxCargo.TipoCargo = Convert.ToInt32(CmbTipoCargo.SelectedValue);
                        auxCargo.TipoValorCargo = Convert.ToInt32(CmbTipoValorCargo.SelectedValue);
                        auxCargo.ValorCargo = Convert.ToDouble(TxtValorCargo.Text);
                        //auxCargo.ValorCargo = Convert.ToDouble(TxtValorCargo.Text);
                        auxCargo.TipoMonedaCargo = Convert.ToInt32(CmbTipoMonedaCargo.SelectedValue);
                        auxCargo.ObsCargo = TxtObsCargos.Text;
                        //CargaGridCargosMedio();
                    }
                    ModificarCargo = false;
                }
                else
                {
                    Cargo oCargo = new Cargo();
                    oCargo.CodigoProducto = 0;
                    oCargo.CodTipoCobro = string.Empty;
                    oCargo.TipoCargo = Convert.ToInt32(CmbTipoCargo.SelectedValue);
                    oCargo.TipoValorCargo = Convert.ToInt32(CmbTipoValorCargo.SelectedValue);
                    oCargo.ValorCargo = Convert.ToDouble(TxtValorCargo.Text);
                    oCargo.TipoMonedaCargo = Convert.ToInt32(CmbTipoMonedaCargo.SelectedValue);
                    oCargo.ObsCargo = TxtObsCargos.Text;
                    ListaCargosMedio.Add(oCargo);
                }
              
                CargaGridCargosMedio();
                //CmbTipoCargo.SelectedIndex = 0;
                //TxtValorCargo.Text = "";
                //CmbTipoValorCargo.SelectedIndex = 0;
                //CmbTipoMonedaCargo.SelectedIndex = 0;
                //TxtObsCargos.Text = string.Empty;
                BtnRegCargoMedio.Text = "Nuevo";
                HabilitarCtrlCargo(false);
                BtnRegCargoMedio.Enabled = true;
                BtnEliminarCargo.Enabled = true;
                BntModificarCargo.Enabled = true;
                BtnRegCargoMedio.Focus();

                DgCargosMedio.Rows[0].Selected = true;
                CargarDatosCtrlCargos();
            }
        }

        bool ValidarEncabezado(Control.ControlCollection ListaControles, GroupBox.ControlCollection GrpControls)
        {
            bool valido = true;
            foreach (Control item in ListaControles)
            {

                if (item is GroupBox)
                {
                    foreach (Control itGrop in GrpControls)
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

        void AnexarEventoEnter(Control.ControlCollection ListaControles, GroupBox.ControlCollection GrpControls)
         {           
            foreach (Control item in ListaControles)
            {
                if (item is GroupBox)
                {
                    foreach (Control itGrop in GrpControls)
                    {

                        if (itGrop is TextBox)
                        {
                            itGrop.Enter += CajasTexto_Enter;
                        }
                    }

                }         

            }

        }

       

        private void FrmMedioElectronico_Load(object sender, EventArgs e)
        {
            
            AnexarEventoEnter(this.Controls, this.groupBox3.Controls);
            AnexarEventoEnter(this.Controls, this.groupBox1.Controls);
            if (ListaCargosMedio.Count > 0)
            {
                DgCargosMedio.Rows[0].Selected = true;
                CargarDatosCtrlCargos();
                BtnEliminarCargo.Enabled = true;
                BntModificarCargo.Enabled = true;
                BtnRegCargoMedio.Enabled = true;
                //HabilitarCtrlCargo(true);
            }
            else
            {
                InicializarControlesCargo();
                BtnEliminarCargo.Enabled = false;
                BntModificarCargo.Enabled = false;
                HabilitarCtrlCargo(false);
                BtnRegCargoMedio.Enabled = true;

            }
            


        }

        private void CmbTipoMedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(CmbTipoMedio.ValueMember) == 3)
            //{
            //    CmbMarcaMedio.SelectedValue = "NA";
            //}
        }

        private void TxtLineaCredito_Leave(object sender, EventArgs e)
        {
            if (TxtLineaCredito.Text.Length > 0) { 
                TxtLineaCredito.Text = /*"₡" +*/ String.Format("{0:N2}", Convert.ToDouble(TxtLineaCredito.Text));
            }
            //Double value;
            //if (Double.TryParse(TxtLineaCredito.Text, out value))
            //    TxtLineaCredito.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    TxtLineaCredito.Text = String.Empty;
        }

        private void DgCargosMedio_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            CargarDatosCtrlCargos();


        }

        private void BntModificarCargo_Click(object sender, EventArgs e)
        {
           
            //BtnRegCargoMedio.Enabled = true;
            BtnRegCargoMedio.Text = "Guardar";
            ModificarCargo = true;
            HabilitarCtrlCargo(true);
            BntModificarCargo.Enabled = false;
            BtnEliminarCargo.Enabled = false;
        }

        private void BtnEliminarCargo_Click(object sender, EventArgs e)
        {
            var auxCargo = ListaCargosMedio.Where(x => x.CodTipoCobro == DgCargosMedio.CurrentRow.Cells["dgCol_CodTipoCobro"].Value.ToString()).FirstOrDefault();
            if (auxCargo != null)
            {
                DialogResult dr = MessageBox.Show(null, "Desea eliminar el cargo seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ListaCargosMedio.Remove(auxCargo);
                    CargaGridCargosMedio();
                }
                
            }

            if (ListaCargosMedio.Count <= 0)
            {
                InicializarControlesCargo();
                BtnEliminarCargo.Enabled = false;
                BntModificarCargo.Enabled = false;
            }
            else
            {
                DgCargosMedio.Rows[0].Selected = true;
                CargarDatosCtrlCargos();
            }
        }

        private void DgCargosMedio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
