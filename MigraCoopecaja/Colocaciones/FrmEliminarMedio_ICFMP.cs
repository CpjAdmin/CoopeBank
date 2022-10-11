using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;
using Datos.EntidadesAux.ComparabilidadFinanciera;

/*
	Metodo Eliminar Medios y cargos asociado AGREGADO POR Diego Arguedas Ticket I-014839
*/

namespace AppEscritorio.Colocaciones
{
    public partial class FrmEliminarMedio_ICFMP : Form
    {
        public FrmEliminarMedio_ICFMP()
        {
            InitializeComponent();
        }



        private void FrmEliminarMedio_ICFMP_Load(object sender, EventArgs e)
        {
            seleccionaMedio();
        }

        private int n = 0;
        public string cadenaConnOracle = System.Configuration.ConfigurationManager.ConnectionStrings["OracleString"].ConnectionString;



        private void seleccionaMedio()
        {
            string tipomoneda = "";
            string marca = "";
            string nombre = "";
            string plazo = "";
            string plazoMaximo = "";
            string lugares = "";
            string cobertura = "";
            string codigo = "";
            string comando = "SELECT NOMBREMEDIO, CODIGOPRODUCTO, MARCAMEDIO,  TIPOMONEDA, PLAZO, PLAZOMAXIMO, LUGARES, COBERTURA FROM DB_UTILIDADES.XML_DETA_BCCR_ICFMP";

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
                            nombre = (String)sqlDR["NOMBREMEDIO"].ToString();
                            codigo = (String)sqlDR["CODIGOPRODUCTO"].ToString();
                            marca = (String)sqlDR["MARCAMEDIO"].ToString();
                            tipomoneda = (String)sqlDR["TIPOMONEDA"].ToString();
                            plazo = (String)sqlDR["PLAZO"].ToString();
                            plazoMaximo = (String)sqlDR["PLAZOMAXIMO"].ToString();
                            lugares = (String)sqlDR["LUGARES"].ToString();
                            cobertura = (String)sqlDR["COBERTURA"].ToString();

                            int n = dgMediosElect.Rows.Add();

                            dgMediosElect.Rows[n].Cells[0].Value = nombre;
                            dgMediosElect.Rows[n].Cells[1].Value = codigo;
                            dgMediosElect.Rows[n].Cells[2].Value = marca;
                            dgMediosElect.Rows[n].Cells[3].Value = tipomoneda;
                            dgMediosElect.Rows[n].Cells[4].Value = plazo;
                            dgMediosElect.Rows[n].Cells[5].Value = plazoMaximo;
                            dgMediosElect.Rows[n].Cells[6].Value = lugares;
                            dgMediosElect.Rows[n].Cells[7].Value = cobertura;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("Desea eliminar el registro del medio con el nombre: " + this.lblMedio.Text, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                    {
                        connOra.Open();
                        OracleCommand comando = new OracleCommand("DB_UTILIDADES.PKG_COOPEBANK.ELIMINARMEDIOELECTRONICO", connOra);
                        comando.CommandType = System.Data.CommandType.StoredProcedure;
                        comando.Parameters.Add("pNOMBREMEDIO", OracleDbType.Varchar2).Value = this.lblMedio.Text.ToString();
                        comando.Parameters.Add("pCODIGOPRODUCTO", OracleDbType.Varchar2).Value = this.lblCodigo.Text.ToString();
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Se ha eliminado el registro del medio electrónico con el nombre: " + this.lblMedio.Text + " y los cargos asociados correctamente",
                        "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        dgMediosElect.Rows.Clear();
                        seleccionaMedio();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("No se eliminó el registro seleccionado)" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (resultado == DialogResult.No)
            {
                return;
            }
        }

        private void dgMediosElect_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.lblMedio.Text = (string)dgMediosElect.Rows[n].Cells[0].Value;
                this.lblCodigo.Text = (string)dgMediosElect.Rows[n].Cells[1].Value;
            }
        }
    }
}
