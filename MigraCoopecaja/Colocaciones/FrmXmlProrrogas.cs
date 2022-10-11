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
using Datos.EntidadesAux;
using System.Configuration;
using System.IO;

namespace AppEscritorio.Colocaciones
{
    public partial class FrmXmlProrrogas : Form
    {
        CapaLogica objLogica;
        List<Prorroga> listaProrrogas;
        public FrmXmlProrrogas()
        {
            InitializeComponent();
            DtPeriodo.Format = DateTimePickerFormat.Custom;
            DtPeriodo.CustomFormat = "MMMM yyyy";
            //DtPeriodo.ShowUpDown = true;
        }



        private void btnGenerarXml_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        generaXML(fbd.SelectedPath);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar el proceso. Vuelva a intentarlo. " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generaXML(string ruta)
        {
            try
            {
                objLogica = new CapaLogica();
                DateTime fecha = DtPeriodo.Value;
                int mes = fecha.Month;
                int anno = fecha.Year;

                string periodo = "01/" + (mes.ToString().Length == 1 ? "0" + mes.ToString() : mes.ToString()) + "/" + anno.ToString();

                //crear datos del encabezado
                EncabezadoXMLProrroga encabezado = new EncabezadoXMLProrroga()
                {
                    clase = "39",
                    versionClase = "1.0",
                    archivo = "3901",
                    versionArchivo = "1.0",
                    Periodo = periodo,
                    entidad = "3004045110",
                    tipoCarga = "1",
                    tipoMoneda = "1"
                };


                //obtiene la informacion de las prorrogas por mes
                listaProrrogas = objLogica.obtenerProrrgasMes(mes, anno);

                ToolSistema.PrintXMLProrroga(ruta, encabezado, listaProrrogas);

                MessageBox.Show("El xml se generó correctamente en la ruta seleccionada.", "CONFIRMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            { 
                MessageBox.Show("No se pudo generar el proceso. Vuelva a intentarlo. " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmXmlProrrogas_Load(object sender, EventArgs e)
        {

        }


       
    }
}
