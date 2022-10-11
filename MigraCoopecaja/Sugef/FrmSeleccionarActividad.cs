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

namespace AppEscritorio.Sugef
{
    /**
              * 
              * Pantalla de selección de actividad económica para las transacciones superiores a $10 000
              * - R-017284 - Requerimiento XML SUGEF - Por Diego Arguedas Rojas
              * 
                Modificación de la estructura del xml clase de datos 6 a clase de datos 50 -Legitimación de Capitales.
              * 
              * 
     * */
    public partial class FrmSeleccionarActividad : Form
    {

        public delegate void delegado (string codigo, string descripcion);
        public event delegado evento;
        public FrmSeleccionarActividad()
        {
            InitializeComponent();
        }

        private void consultarActividad()
        {
            string codigo_subclase = "";
            string titulo = "";
            string comando = "SELECT CODIGO_SUBCLASE, TITULO FROM SUGEF.ACTIVIDAD_ECONOMICA ORDER BY CODIGO_SUBCLASE ASC";

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
                            codigo_subclase = (String)sqlDR["CODIGO_SUBCLASE"].ToString();
                            titulo = (String)sqlDR["TITULO"].ToString();

                            int n = dgActividad.Rows.Add();

                            dgActividad.Rows[n].Cells[0].Value = codigo_subclase;
                            dgActividad.Rows[n].Cells[1].Value = titulo;
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
        private int n = 0;

        private void FrmSeleccionarActividad_Load(object sender, EventArgs e)
        {
            consultarActividad();
            this.txtCodigo1.Enabled = false;
            this.txtDescripcion1.Enabled = false;
        }

        private void filtraCodigo(string codigo)
        {
            string codigo_subclase = "";
            string titulo = "";
            string comando = "SELECT * " +
                "FROM SUGEF.ACTIVIDAD_ECONOMICA WHERE CODIGO_SUBCLASE LIKE ('" + codigo + "') ORDER BY CODIGO_SUBCLASE ASC";

            try
            {

                if (codigo.Trim() == "")
                {
                    return;
                }
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("CODIGO_SUBCLASE", codigo));

                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            codigo_subclase = (String)sqlDR["CODIGO_SUBCLASE"].ToString();
                            titulo = (String)sqlDR["TITULO"].ToString();

                            int n = dgActividad.Rows.Add();

                            dgActividad.Rows[n].Cells[0].Value = codigo_subclase;
                            dgActividad.Rows[n].Cells[1].Value = titulo; 
                        }
                    }
                    else if (!(sqlDR.HasRows))
                    {

                        MessageBox.Show("No existen registros para el código ingresado, valide el código nuevamente", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        consultarActividad();
                    }

                    sqlDR.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void filtraDescripcion(string descripcion)
        {
            string codigo_subclase = "";
            string titulo = "";
            string comando = "SELECT * " +
                "FROM SUGEF.ACTIVIDAD_ECONOMICA WHERE TITULO LIKE ('%" + descripcion + "%') ORDER BY CODIGO_SUBCLASE ASC";

            try
            {
                if (descripcion.Trim() == "")
                {
                    return;
                }
                using (OracleConnection connOra = new OracleConnection(cadenaConnOracle))
                {

                    connOra.Open();
                    OracleCommand Query = new OracleCommand(comando, connOra);
                    Query.CommandType = CommandType.Text;
                    Query.Parameters.Add(new OracleParameter("TITULO", descripcion));

                    Query.CommandTimeout = 0;

                    OracleDataReader sqlDR = Query.ExecuteReader();

                    if (sqlDR.HasRows)
                    {
                        while (sqlDR.Read())
                        {
                            codigo_subclase = (String)sqlDR["CODIGO_SUBCLASE"].ToString();
                            titulo = (String)sqlDR["TITULO"].ToString();

                            int n = dgActividad.Rows.Add();

                            dgActividad.Rows[n].Cells[0].Value = codigo_subclase;
                            dgActividad.Rows[n].Cells[1].Value = titulo;

                        }
                    }
                    else if (!(sqlDR.HasRows))
                    {

                        MessageBox.Show("No existen registros para la descripción ingresada, valide la descripción nuevamente", "No se encontraron registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        consultarActividad();
                    }

                    sqlDR.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pbCodigo_Click(object sender, EventArgs e)
        {
            dgActividad.Rows.Clear();
            this.txtDescripcion.Text = "";

            if (this.txtCodigo.Text == "")
            {
                MessageBox.Show("No ha digitado un código para realizar la búsqueda",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultarActividad();
            }
            else
            {
                string codigo = this.txtCodigo.Text;
                filtraCodigo(codigo);
            }
        }

        private void pbDescripcion_Click(object sender, EventArgs e)
        {
            dgActividad.Rows.Clear();
            this.txtCodigo.Text = "";

            if (this.txtDescripcion.Text == "")
            {
                MessageBox.Show("No ha digitado una descripción para realizar la búsqueda",
                    "Favor Valide Nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                consultarActividad();
            }
            else
            {
                string descripcion = this.txtDescripcion.Text;
                filtraDescripcion(descripcion);
            }
        }

        private void dgActividad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                this.txtCodigo1.Text = (string)dgActividad.Rows[n].Cells[0].Value;
                this.txtDescripcion1.Text = (string)dgActividad.Rows[n].Cells[1].Value;
            }
        }

        private void pbRefrescar_Click(object sender, EventArgs e)
        {
            this.txtCodigo.Text = "";
            this.txtDescripcion.Text = "";
            this.txtCodigo1.Text = "";
            this.txtDescripcion1.Text = "";
            dgActividad.Rows.Clear();
            consultarActividad();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            evento(this.txtCodigo1.Text, this.txtDescripcion1.Text);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {  
            this.Close();
        }   
    }
}
