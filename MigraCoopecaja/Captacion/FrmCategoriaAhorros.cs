using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.EntidadesAux.CategoriaComercial;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using Logica;

/*Mantenimiento de categorías comerciales y ahorros
 * Por Diego Arguedas Rojas Abril-2022
 * R-015304
 * 
 * Mantenimientos de la tablas CL_CAT_COMERCIAL &&& CL_PRODUCTOS_CAT_COMERCIAL
 * 
 * 
 */

namespace AppEscritorio.Captacion
{
    public partial class FrmCategoriaAhorros : Form
    {
        public FrmCategoriaAhorros()
        {
            InitializeComponent();
        }

        CapaLogica objCapaLogica;
        List<ListaInversiones> ListaInversiones;

        private void FrmCategoriaAhorros_Load(object sender, EventArgs e)
        {
            cargaInversiones();
            cmbAhorros.SelectedIndex = 0;
            consultarAhorro();
        }

        public void cargaInversiones()
        {
            objCapaLogica = new CapaLogica();
            ListaInversiones = new List<ListaInversiones>();
            ListaInversiones = objCapaLogica.ConsultarInversiones().OrderBy(x => x.COD_INVERSION).ToList();
            cmbAhorros.DisplayMember = "FULL_INVERSION";
            cmbAhorros.ValueMember = "COD_INVERSION";
            cmbAhorros.DataSource = ListaInversiones;
        }

        private void consultarAhorro()
        {
            string COD_PRODUCTO = "";
            string COD_SERVICIO = "";

            string comando = "SELECT * FROM CL_PRODUCTOS_CAT_COMERCIAL ORDER BY COD_PRODUCTO";

            try
            {
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {
                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            COD_PRODUCTO = (String)sqlDR["COD_PRODUCTO"].ToString();
                            COD_SERVICIO = (String)sqlDR["COD_SERVICIO"].ToString();

                            int n = dgAhorros.Rows.Add();
                            dgAhorros.Rows[n].Cells[0].Value = COD_SERVICIO;
                            dgAhorros.Rows[n].Cells[1].Value = COD_PRODUCTO;
                        }
                    }
                    sqlDR.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string codigo_producto = this.cmbAhorros.SelectedValue.ToString();
            string codigo_servicio = "IN";

            try
            {
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))

                {
                    connOra.Open();
                    OracleCommand comando = new OracleCommand("DB_UTILIDADES.PKG_COOPEBANK.INSERTAR_AHORRO", connOra);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.Add("pCOD_SERVICIO", OracleDbType.Varchar2).Value = codigo_servicio;
                    comando.Parameters.Add("pCOD_PRODUCTO", OracleDbType.Varchar2).Value = codigo_producto;

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.dgAhorros.Rows.Clear();
            consultarAhorro();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ahorros = this.cmbAhorros.SelectedValue.ToString();
                           
            try
            {
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {

                        connOra.Open();
                        OracleCommand comando = new OracleCommand("DB_UTILIDADES.PKG_COOPEBANK.ELIMINAR_AHORRO", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pCOD_PRODUCTO", OracleDbType.Varchar2).Value = ahorros;
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Puede consultar nuevamente para validar si se eliminó el registro correctamente!", "Eliminación de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connOra.Close();

                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("No se han eliminado los datos correctamente", "Datos No Eliminados", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    throw ex;
            }
        }
    }
}