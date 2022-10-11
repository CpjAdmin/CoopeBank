using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmBuscarVendedor2 : Form
    {
        string connectionStringO = "";
        List<estructuras.Usuario> listaUsuario;
        public FrmBuscarVendedor2(string ConnectionString)
        {
            InitializeComponent();
            connectionStringO = ConnectionString;
            listaUsuario = ListaUsuarios("", "");
            dtgUsuarios.DataSource = listaUsuario;
        }

        private List<estructuras.Usuario> ListaUsuarios(string cod_usuario, string nom_usuario)
        {
            List<estructuras.Usuario> listau = new List<estructuras.Usuario>();
            estructuras.Usuario usuario = null;
            string sentencia = "SELECT A.COD_USUARIO,A.DES_NOMBRE,NVL(B.COD_VENDEDOR,0) COD_VENDEDOR FROM GENERAL.GL_USUARIOS A LEFT JOIN FVENTAS.FV_VENDEDORES B ON A.COD_USUARIO = B.COD_USUARIO AND B.COD_COMPANIA = '01001001' WHERE ESTADO = 'A' ";

            if (cod_usuario.Trim() != "")
            {
                sentencia = sentencia + " AND upper(A.COD_USUARIO) like '" + cod_usuario.ToUpper().Trim() + "'";
            }
            if (nom_usuario.Trim() != "")
            {
                sentencia = sentencia + " AND upper(A.DES_NOMBRE) LIKE '" + nom_usuario.ToUpper().Trim() + "'";
            }
            sentencia = sentencia + " ORDER BY A.COD_USUARIO";

            try
            {
                using (OracleConnection connORA = new OracleConnection(connectionStringO))
                {
                    connORA.Open();
                    OracleCommand Query = new OracleCommand(sentencia, connORA);
                    Query.CommandType = CommandType.Text;
                    Query.CommandTimeout = 10000;

                    OracleDataReader SqlDR = Query.ExecuteReader();

                    if (SqlDR.HasRows)
                    {
                        while (SqlDR.Read())
                        {
                            usuario = new estructuras.Usuario();
                            usuario.cod_vendedor = int.Parse(SqlDR["COD_VENDEDOR"].ToString());
                            usuario.des_nombre = (String)SqlDR["DES_NOMBRE"].ToString();
                            usuario.cod_usuario = (String)SqlDR["COD_USUARIO"].ToString();
                            listau.Add(usuario);
                        }

                    }
                    else
                    {


                    }
                    SqlDR.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Busqueda de vendedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listau;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Colocaciones.FrmVendedores.Cod_vendedor = 0;
            Colocaciones.FrmVendedores.Des_nombre = "";
            Colocaciones.FrmVendedores.Cod_Usuario = "";
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                Colocaciones.FrmVendedores.Cod_vendedor = listaUsuario[dtgUsuarios.CurrentCell.RowIndex].cod_vendedor;
                Colocaciones.FrmVendedores.Des_nombre = listaUsuario[dtgUsuarios.CurrentCell.RowIndex].des_nombre;
                Colocaciones.FrmVendedores.Cod_Usuario = listaUsuario[dtgUsuarios.CurrentCell.RowIndex].cod_usuario;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se seleccionó ningún vendedor", "VENDEDORES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaUsuario = ListaUsuarios(this.txtCodigo.Text.Trim(), this.txtNombre.Text.Trim());
            dtgUsuarios.DataSource = listaUsuario;
        }
    }
}
