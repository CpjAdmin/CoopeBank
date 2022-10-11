using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.EntidadesAux;
using System.Threading;
using Logica;


namespace AppEscritorio.Cobros
{
    public partial class FrmCancCreditos : Form
    {
        
        List<OpeIncob> ListadoOpeIncob;
        List<OpeIncCance> ListadoOpeIncoCance;
        CapaLogica objCapaLogica;
        
        public FrmCancCreditos()
        {
            InitializeComponent();
        }


        private void ConsultarCreditosIncoCancelados()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                DgCredIncoCanc.DataSource = ListadoOpeIncoCance;
                ListadoOpeIncoCance = objCapaLogica.ConsultCredIncoCancelados();
                DgCredIncoCanc.DataSource = ListadoOpeIncoCance.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }


        private void ConsultarCreditosIncobrables()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                DgCreditosInco.DataSource = ListadoOpeIncob;
                ListadoOpeIncob = objCapaLogica.ConsultarCreditosIncobrables();
                
                DgCreditosInco.DataSource = ListadoOpeIncob.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CancelarOperacion()
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCancCreditos_Load(object sender, EventArgs e)
        {
            ConsultarCreditosIncobrables();
            ConsultarCreditosIncoCancelados();
            DtCancelacion.Value = DateTime.Now;
            LblCantOpeCance.Text = string.Empty;
        }

        private void HabilitarControles(bool habilitar){

            TxtBusqueda.Enabled = habilitar;
            BtnTodas.Enabled = habilitar;
            DgCreditosInco.Enabled = habilitar;
            BtnConsultar.Enabled = habilitar;
            //BtnCanSaldo.Enabled = habilitar;
            
        
        }

        private void BtnCanSaldo_Click(object sender, EventArgs e)
        {
           
            try
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro de realizar la cancelación de saldo de las operaciones seleccionadas?", "Confirmación", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    ConsultarCreditosIncobrables();
                    EstadisticaConteo();
                    return;
                }

                HabilitarControles(false);
                BtnCanSaldo.Click -= BtnCanSaldo_Click;
                BtnCanSaldo.Image = AppEscritorio.Properties.Resources.Cargando;                          
                objCapaLogica = new CapaLogica();
                objCapaLogica.RegistrarCancelacionCredito(ListadoOpeIncob,FrmMain.Usuario.Usuario);                
                ConsultarCreditosIncobrables();
                ConsultarCreditosIncoCancelados();
                HabilitarControles(true);
                BtnCanSaldo.Image = AppEscritorio.Properties.Resources.procesar;                          
                MessageBox.Show("El proceso finalizó con exito, ver bitacora para determinar que operaciones se lograrón cancelar", "Proceso finalizó", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EstadisticaConteo();
                BtnCanSaldo.Click += BtnCanSaldo_Click;
            }
            catch (Exception ex)
            {                
                 MessageBox.Show("Error con una de las operaciones, favor revisar."+Environment.NewLine+ ex.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void TxtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtBusqueda.Text.Length > 0 || (TxtBusqueda.Text.Length > 0 && (e.KeyChar == (char)Keys.Back)))
            {
                DgCreditosInco.DataSource = ListadoOpeIncob.Where(x => (x.COD_CLIENTE+x.DES_IDENTIFICACION+x.NOM_CLIENTE+x.NUM_OPERACION).Trim().ToUpper().Contains(TxtBusqueda.Text.ToUpper().Trim())).ToList();
                
            }
            else
            {
                DgCreditosInco.DataSource = ListadoOpeIncob.ToList();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCreditosIncobrables();
            EstadisticaConteo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtOpeCancelada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TxtOpeCancelada.Text.Length > 0 || (TxtOpeCancelada.Text.Length > 0 && (e.KeyChar == (char)Keys.Back)))
            {

                DtCancelacion.Visible = false;
                DgCredIncoCanc.DataSource = ListadoOpeIncoCance.Where(x => (x.pOperacion + x.pUsuarioCancelo).Trim().ToUpper().Contains(TxtOpeCancelada.Text.ToUpper().Trim())).ToList();
                

            }
            else
            {
                
                DgCredIncoCanc.DataSource = ListadoOpeIncoCance.ToList();
                DtCancelacion.Visible = Visible;
                DtCancelacion.Value = DateTime.Now;

                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TxtOpeCancelada.Text = string.Empty;
            //MessageBox.Show(DtCancelacion.Value.ToShortDateString());
            if (ListadoOpeIncoCance == null || ListadoOpeIncoCance.Count <= 0)
            {
                return;
            }
            DgCredIncoCanc.DataSource = ListadoOpeIncoCance.Where(x => (x.pFechaCancela.ToShortDateString()).Trim().ToUpper().Contains(DtCancelacion.Value.ToShortDateString().ToUpper().Trim())).ToList();
            
        }

        private int CantidadOpeACancelar()
        {
            int retornar = 0;
            if (ListadoOpeIncob != null)
            {
                retornar = ListadoOpeIncob.Where(x => x.CancelarSaldo == 1).Count();
            }
            return retornar;
        }

        private void EstadisticaConteo()
        {
            if (ListadoOpeIncob != null && ListadoOpeIncob.Count > 0)
            {
                LblCantOpeCance.Text = CantidadOpeACancelar() <= 0 ? "" : "Operaciones a cancelar: [" + CantidadOpeACancelar().ToString() + "]";
                LblCantOpeCance.Visible = CantidadOpeACancelar() <= 0 ? false : true;
                LblTotalCancelar.Text = CantidadOpeACancelar() <= 0 ? "" : ListadoOpeIncob.Where(y => y.CancelarSaldo == 1).Sum(x => x.Saldo).ToString("C2");
                LblTotalCancelar.Visible = CantidadOpeACancelar() <= 0 ? false : true;
            }
            
        }

        private void BtnTodas_Click(object sender, EventArgs e)
        {
            int Marcar = 0;
            if (BtnTodas.Text == "Todas")
            {
                Marcar = 1;
                BtnTodas.Text = "Desmarcar";
            }
            else
            {
                Marcar = 0;
                BtnTodas.Text = "Todas";
            }


            foreach (OpeIncob item in ListadoOpeIncob)
            {
                item.CancelarSaldo = Marcar;

            }
            DgCreditosInco.DataSource = ListadoOpeIncob.ToList();
            EstadisticaConteo();
            

            
            
        }

        private void DgCreditosInco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DgCreditosInco_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            EstadisticaConteo();
        }

        private void DgCreditosInco_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgCreditosInco_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DgCreditosInco_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
          

            
        }

        private void DgCreditosInco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           

      
      }

        private void DgCreditosInco_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DgCreditosInco_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgCreditosInco_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
           
        }

        private void DgCreditosInco_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            if (DgCreditosInco.IsCurrentCellDirty)
            {
                DgCreditosInco.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            {
                DtCancelacion.Value = DateTime.Now;

            }
        }
        }
}
