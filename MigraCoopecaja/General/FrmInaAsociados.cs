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
    public partial class FrmInaAsociados : Form
    {

        List<Asociado> ListadoAsoActivos;
        List<Asociado> ListadoAsoInactivos;
        CapaLogica objCapaLogica;
        List<UsuarioPS> ListaUsuReingreso;
        public FrmInaAsociados()
        {
            InitializeComponent();
        }


        #region "Metodos"
        

       

        void PROC_INAASOCIADO()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                Asociado auxAsociado = new Asociado();
                auxAsociado.DES_IDENTIFICACION = txtIdentificacion.Text.Trim();
                auxAsociado.FEC_INACTIVO = DateTime.Now;
                auxAsociado.USU_REGISTRO = FrmMain.Usuario.Usuario;                
                int resultado = objCapaLogica.PROC_INAASOCIADO(auxAsociado);
                if (resultado == 1)
                {
                    MessageBox.Show("Asociado pasa a estado inactivo", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConsultarAsoActivos();
                }
                else
                {
                    MessageBox.Show("No se logro cambiar el estado del asociado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro cambiar el estado del asociado" + e.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        private void ConsultarAsoInactivos()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                dgInactivados.DataSource = ListadoAsoInactivos;
                ListadoAsoInactivos = objCapaLogica.OBTENER_ASOINACTIVOS();
                dgInactivados.DataSource = ListadoAsoInactivos.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ConsultarAsoActivos()
        {
            try
            {
                objCapaLogica = new CapaLogica();
                dgAsoActivos.DataSource = ListadoAsoActivos;
                ListadoAsoActivos = objCapaLogica.OBTENER_ASOACTIVOS();
                dgAsoActivos.DataSource = ListadoAsoActivos.ToList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        void cargaDatos(TextBox aux)
        {
            ConsultarAsoActivos();
            ConsultarAsoInactivos();          
            aux.Text = string.Empty;
            aux.Focus();
        }

        #endregion

        private void FrmInaAsociados_Load(object sender, EventArgs e)
        {
            cargaDatos(txtBuscarAsoActivo);
        }

        private void DgAsoActivos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtIdentificacion.Text = dgAsoActivos.CurrentRow.Cells["colDesIdentificacion"].Value.ToString();
            txtAsociado.Text = dgAsoActivos.CurrentRow.Cells["colNomCliente"].Value.ToString();
            txtFechaAfiliacion.Text = dgAsoActivos.CurrentRow.Cells["colFecAfiliacion"].Value.ToString();
        }

        private void TxtBuscarAsoActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Asociado> query = (from asociado in ListadoAsoActivos
                                       where (asociado.DES_IDENTIFICACION.Trim() + asociado.NOM_CLIENTE.Trim()).ToUpper().Contains(txtBuscarAsoActivo.Text.Trim().ToUpper())
                                       select asociado).ToList();

            this.BeginInvoke(new MethodInvoker(() =>
            {
                dgAsoActivos.DataSource = query;
            }));
        }

        private void BtnInactivar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(null, "Esta seguro que desea inactivar a " + txtAsociado.Text + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                PROC_INAASOCIADO();
            }
            {
                
                ConsultarAsoActivos();
            }

            txtBuscarAsoActivo.Text = string.Empty;
            txtBuscarAsoActivo.Focus();
        }

        private void TbParte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TbParte.SelectedIndex == 0)
            {
                cargaDatos(txtBuscarAsoActivo);
            }

            if (TbParte.SelectedIndex == 1)
            {
                cargaDatos(TxtBuscarInactivo);
            }

           
        }

        private void TxtBuscarInactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Asociado> query = (from asociado in ListadoAsoInactivos
                                        where (asociado.DES_IDENTIFICACION.Trim() + asociado.NOM_CLIENTE.Trim()).ToUpper().Contains(TxtBuscarInactivo.Text.Trim().ToUpper())
                                        select asociado).ToList();

            this.BeginInvoke(new MethodInvoker(() =>
            {
                dgInactivados.DataSource = query;
            }));
        }
    }
}
