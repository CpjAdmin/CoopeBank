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
using Logica;

namespace AppEscritorio.General
{
    public partial class FrmReingresos : Form
    {

        List<AsoRenuncia> ListadoAsoRenuncia;
        List<AsoReingreso> ListadoAsoReingresos;
        CapaLogica objCapaLogica;
        List<UsuarioPS> ListaUsuReingreso;
        

        public FrmReingresos()
        {
            InitializeComponent();
        }

       
        void CargaUsuariosReingreso()
        {
            objCapaLogica = new CapaLogica();
            ListaUsuReingreso = new List<UsuarioPS>();
            ListaUsuReingreso = objCapaLogica.ConsultarUsuarioPS().OrderBy(x=>x.COD_USUARIO).ToList();
            cmbUsuReingreso.DisplayMember = "DES_NOMBRE";
            cmbUsuReingreso.ValueMember = "COD_USUARIO";
            cmbUsuReingreso.DataSource = ListaUsuReingreso;
                
        }

        void PROC_REINASOCIADO()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                AsoReingreso auxAsoReingreso = new AsoReingreso();
                auxAsoReingreso.PDES_IDENTIFICACION = txtIdentificacion.Text.Trim();
                auxAsoReingreso.PFEC_REINGRESO = dtReingreso.Value;
                auxAsoReingreso.USU_REGISTRO = FrmMain.Usuario.Usuario;
                auxAsoReingreso.USU_AFILIA = cmbUsuReingreso.SelectedValue.ToString();
                int resultado = objCapaLogica.PROC_REINASOCIADO(auxAsoReingreso);
                if (resultado == 1)
                {
                    MessageBox.Show("Reingreso correcto del asociado","CONFIRMACIÓN",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ConsultarAsoRenuncia();
                }
                else
                {
                    MessageBox.Show("No se logro realizar el regintreso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro realizar el regintreso. "+e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            
            
        }


        private void ConsultarAsoReingresos()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                dgReingresados.DataSource = ListadoAsoReingresos;
                ListadoAsoReingresos = objCapaLogica.OBTENERREINGRESOS();
                dgReingresados.DataSource = ListadoAsoReingresos.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ConsultarAsoRenuncia()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                dgRenuncias.DataSource = ListadoAsoRenuncia;
                ListadoAsoRenuncia = objCapaLogica.OBTENERASOCIADOSRENUNCIA();
                dgRenuncias.DataSource = ListadoAsoRenuncia.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        void cargaDatos(TextBox aux)
        {
            ConsultarAsoRenuncia();
            ConsultarAsoReingresos();
            CargaUsuariosReingreso();
            aux.Text = string.Empty;
            aux.Focus();
        }

        private void FrmReingresos_Load(object sender, EventArgs e)
        {
            cargaDatos(txtBuscarRenunciado);
        }

        private void DgRenuncias_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
                txtIdentificacion.Text = dgRenuncias.CurrentRow.Cells["colDesIdentificacion"].Value.ToString();
                txtAsociado.Text = dgRenuncias.CurrentRow.Cells["colNomCliente"].Value.ToString();
                txtFechaRenuncia.Text = dgRenuncias.CurrentRow.Cells["colFecRenuncia"].Value.ToString();
                
        
        }

        private void TxtIdentificacion_TextChanged(object sender, EventArgs e)
        {
                       
            

            
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

                   

           
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            List<AsoRenuncia> query = (from asociado in ListadoAsoRenuncia
                                       where (asociado.DES_IDENTIFICACION.Trim() + asociado.NOM_CLIENTE.Trim()).ToUpper().Contains(txtBuscarRenunciado.Text.Trim().ToUpper())
                                       select asociado).ToList();                                       

            this.BeginInvoke(new MethodInvoker(() =>
            {
                dgRenuncias.DataSource = query;
            }));
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            DialogResult result;            
            result = MessageBox.Show(null, "Esta seguro que desea reingresar a "+txtAsociado.Text +", con fecha de reingreso "+dtReingreso.Value.ToString("dd/MM/yyyy")+"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                PROC_REINASOCIADO();
            }
            {
                ConsultarAsoRenuncia();
            }
               
            txtBuscarRenunciado.Text = string.Empty;
            txtBuscarRenunciado.Focus();
        }

        private void TbParte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbParte.SelectedIndex == 1)
            {
                cargaDatos(TxtBuscarReingrso);
            }

            if (TbParte.SelectedIndex == 0)
            {
                cargaDatos(txtBuscarRenunciado);
            }
        }

        private void TxtBuscarReingrso_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<AsoReingreso> query = (from asociado in ListadoAsoReingresos
                                       where (asociado.PDES_IDENTIFICACION.Trim() + asociado.NOM_CLIENTE.Trim()).ToUpper().Contains(TxtBuscarReingrso.Text.Trim().ToUpper())
                                       select asociado).ToList();

            this.BeginInvoke(new MethodInvoker(() =>
            {
                dgReingresados.DataSource = query;
            }));
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
