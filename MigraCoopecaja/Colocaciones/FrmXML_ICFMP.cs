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
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmXML_ICFMP : Form
    {
        CapaLogica oLogica;
        MedioPago oMedioPago;
        List<MedioPago> ListadoMediosPago;
        List<Cargo> ListadoCargosMedio;
        EncabezadoXML oEncabezadoXML;
        private int n = 0;
        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;


        public FrmXML_ICFMP()
        {
            InitializeComponent();
        }

        void CargaListaDatos()
        {
            oLogica = new CapaLogica();
            ListadoMediosPago = (List<MedioPago>)oLogica.Obtener_DatosMediosPago()[1];
            ListadoCargosMedio = (List<Cargo>)oLogica.Obtener_DatosMediosPago()[2];

        }

        void CargarGridMedioPago()
        {
            DgMedios.DataSource = ListadoMediosPago;
        }

        void Cargar_GridCargMedios()
        {

            if (oMedioPago != null)
            {
                DgCargos.DataSource = (from n in ListadoCargosMedio
                                       where n.CodigoProducto == Convert.ToInt32(oMedioPago.CodigoProducto)
                                       orderby n.TipoCargo descending
                                       select new
                                       {
                                           pObsCargo = n.ObsCargo,                                           
                                           pTipoCargo = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TCM" && x.Codigo == n.TipoCargo).FirstOrDefault().Campo1,
                                           pTipoValorCargo = n.TipoValorCargo == 1 ? "Porcentaje" : "Monto",
                                           pValorCargo = n.ValorCargo
                                       }).ToList();
            }

        }

        void Cargar_Combos()
        {
            
            CmbTipoMedio.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TME").ToList();
            CmbTipoMedio.ValueMember = "Codigo";
            CmbTipoMedio.DisplayMember = "Campo1";
            CmbTipoMedio.SelectedIndex = 0;

            CmbTipoMoneda.DataSource = ConstantesSistema.K_TipoCateCredi.Where(x => x.NomCatalogo == "TM").ToList();
            CmbTipoMoneda.ValueMember = "Codigo";
            CmbTipoMoneda.DisplayMember = "Campo1";
            CmbTipoMoneda.SelectedIndex = 0;
        }

        void Seleccion_DatosCombos()
        {
            CmbTipoMedio.SelectedValue = Convert.ToInt32(DgMedios.CurrentRow.Cells["dgCol_TipoMedio"].Value);
            CmbTipoMoneda.SelectedValue = Convert.ToInt32(DgMedios.CurrentRow.Cells["dgCol_TipoMoneda"].Value);                       
            TxtObsMedio.Text = Convert.ToString(DgMedios.CurrentRow.Cells["dgCol_Observaciones"].Value);
            TxtBeneficios.Text = Convert.ToString(DgMedios.CurrentRow.Cells["dgCol_Beneficios"].Value);
            TxtLineaCredito.Text = Convert.ToString(DgMedios.CurrentRow.Cells["dgCol_LineaCredito"].Value);
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


        object[] ObtenerEncabezado()
        {
            oEncabezadoXML = new EncabezadoXML();
            oEncabezadoXML.NombreContacto = TxtContacto.Text.Trim();
            oEncabezadoXML.CorreoContacto = TxtCorreo.Text.Trim();
            oEncabezadoXML.NombreArchivo = TxtArchivo.Text.Trim();
            oEncabezadoXML.TipoPersona = ComboTipoPersona.SelectedIndex == 0 ? enum_TipoPersona.Fisica : enum_TipoPersona.Juridica;
            oEncabezadoXML.TelContacto = TxtTelefono.Text.Trim();
            oEncabezadoXML.Periodo = DtPeriodo.Value.ToString("dd/MM/yyyy");
            oEncabezadoXML.CodArchivo = enum_TipoArchivo.ICFMP;
            oEncabezadoXML.IdOferente = "3004045110";

            object[] DatosEncabezado =
                  {
                        TxtContacto.Text.Trim(),
                        TxtCorreo.Text.Trim(),
                        TxtArchivo.Text.Trim(),
                        ComboTipoPersona.SelectedIndex + 1,
                        TxtTelefono.Text.Trim(),
                        DtPeriodo.Value.ToString("dd/MM/yyyy"),
                        "ICFMP",
                        "3004045110"
                    };
            return DatosEncabezado;
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

        void CargaInicialDatos()
        {
            CargaListaDatos();
            CargarGridMedioPago();
            if (DgMedios.RowCount > 0)
            {
                DgMedios.Rows[0].Selected = true;
            }
            Cargar_Combos();
            ComboTipoPersona.SelectedIndex = 0;

        }

        private void BtnNuevoMedio_Click(object sender, EventArgs e)
        {
            Colocaciones.FrmMedioElectronico objMedioElectro = new FrmMedioElectronico();
            objMedioElectro.ShowDialog();
            CargaInicialDatos();

        }

        private void FrmXML_ICFMP_Load(object sender, EventArgs e)
        {
            CargaInicialDatos();
        }

        private void DgMedios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string pCod = Convert.ToString(DgMedios.CurrentRow.Cells["dgCol_CodigoProducto"].Value);
            oMedioPago = ListadoMediosPago.Where(x => x.CodigoProducto == pCod).FirstOrDefault();
            Seleccion_DatosCombos();
            Cargar_GridCargMedios();
        }

        private void BtnGenerarXML_Click(object sender, EventArgs e)
        {
            if (!ValidarEncabezado())
            {
                MessageBox.Show("Debe completar todos los datos del encabezado", "VALIDACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            object[] DatosEncabezado = ObtenerEncabezado();

            

            oLogica = new CapaLogica();
            object[] Respuesta = oLogica.Gen_XML_ICFMP_BCCR(DatosEncabezado);
            if (Convert.ToInt32(Respuesta[0]) == -1)
            {
                MessageBox.Show(Convert.ToString(Respuesta[1]), "ERRROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Array.Resize(ref Respuesta, 5);

            Respuesta[2] = oEncabezadoXML;
            Respuesta[3] = ListadoMediosPago;
            Respuesta[4] = ListadoCargosMedio;

            ToolSistema.PrintXML_ICFMP(Respuesta);
            MessageBox.Show("XML ID= " + Respuesta[0].ToString() + " generado con exito!!", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


          
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

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            oMedioPago.ListadoCargosMedio = ListadoCargosMedio.Where(x => x.CodigoProducto == Convert.ToInt32(oMedioPago.CodigoProducto)).ToList();
            Colocaciones.FrmMedioElectronico objMedioElectro = new FrmMedioElectronico(oMedioPago);
            objMedioElectro.ShowDialog();
            CargaInicialDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Colocaciones.FrmEliminarMedio_ICFMP ObjEliminarMedio_ICFMP = new FrmEliminarMedio_ICFMP();
            ObjEliminarMedio_ICFMP.ShowDialog();
        }

        private void DgMedios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
