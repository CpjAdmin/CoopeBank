using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using DocumentFormat;
using Datos.EntidadesAux;
using System.IO;
using Logica;
using System.Threading;

namespace AppEscritorio.Captacion
{

    struct Productos
	{
		public string CodProducto {get;set;}
        public string NombreProducto {get;set;}
	}

    //struct ContratoGestion
    //{
    //    public string Cedula { get; set; }
    //    public string Nombre { get; set; }
    //    public string Contrato { get; set; }
    //    public decimal MONTO { get; set; }
    //    public bool habilitar { get; set; }
    //}
    public partial class FrmGestionExcedentes : Form
    {


        //public string TIP_INVERSION { get; set; }
        //public string COD_MOVIMIENTO { get; set; }
        //public double MONTO { get; set; }
        //public string NUM_CEDULA { get; set; }
        //public string DES_OBSERVACION { get; set; }
        //public double COD_CLIENTE { get; set; }
        //public double NUM_CONTRATO { get; set; }
        List<ExcedentesCarga> ListadoExcedentesCarga;
        List<ContratoGestion> ListadoContratoGestion;
        List<ContratoGestionPendi> ListadoContratoPendientes;
        List<Productos> ListadoProductos;
        List<Productos> ListadoProductosActivacion;
        List<Productos> ListadoProductosActivacionSinpe;
        List<Productos> ListadoProductosPend;
        CapaLogica objLogica;
        Task ProcesoCarga;
        string CedulaNoEncontrada;
        string PersonaNoEncontrada;


        public FrmGestionExcedentes()
        {
            InitializeComponent();
        }

        void CargaPendientesBD(ref List<ContratoGestionPendi> pLista)
        {
            objLogica = new CapaLogica();
            pLista = objLogica.ConsultarPendientesProd();


        }

        void CargarArchivoExcelPagoSinpe(ref List<ContratoGestion> pLista)
        {
            SLDocument ArchivoExcel = new SLDocument(opFileDialog.FileName);
            SLWorksheetStatistics stats = ArchivoExcel.GetWorksheetStatistics();
            pLista = new List<ContratoGestion>();
            PersonaNoEncontrada = string.Empty;

            for (int row = stats.StartRowIndex; row <= stats.EndRowIndex; ++row)
            {
                ContratoGestion objContrato = new ContratoGestion();
                objContrato.Cedula = ArchivoExcel.GetCellValueAsString(row, 1);
                objLogica = new CapaLogica();
                string DatosCliente = objLogica.ConsultarDatosCliente(objContrato.Cedula);
                objContrato.Nombre = DatosCliente.Split('>')[1].ToString();
                if (objContrato.Nombre.Trim() == "-1")
                {
                    PersonaNoEncontrada += "Este cliente no se encuentra en PSBAN [" + objContrato.Cedula + "];";
                    continue;
                }
                objContrato.Contrato = objLogica.ConsultarDatosContratoAhorro(DatosCliente.Split('>')[0].ToString(), CmbProdActivar.SelectedValue.ToString()).Split('>')[0].ToString();
                if (objContrato.Contrato.Trim() == "-1")
                {
                    PersonaNoEncontrada += "El contrato de ahorro no existe para: [" + objContrato.Cedula + "];";
                    continue;
                }
                //objContrato.habilitar = objLogica.ConsultarDatosContratoAhorro(DatosCliente.Split('>')[0].ToString(), CmbProdActivar.SelectedValue.ToString()).Split('>')[6].ToString() == "01" ? true : false;
                objContrato.habilitar = true;
                objContrato.MONTO = Convert.ToDecimal(objLogica.ConsultarDatosContratoAhorro(DatosCliente.Split('>')[0].ToString(), CmbProdActivar.SelectedValue.ToString()).Split('>')[3]);



                //Console.WriteLine(objExce.NUM_CEDULA);
                pLista.Add(objContrato);


            }


        }

        void CargarArchivoExcel()
        {

       
                SLDocument ArchivoExcel = new SLDocument(opFileDialog.FileName);        
                SLWorksheetStatistics stats = ArchivoExcel.GetWorksheetStatistics();
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        prges.Maximum = stats.NumberOfRows - 1;
                    }));
                }
               
                ListadoExcedentesCarga = new List<ExcedentesCarga>();
                CedulaNoEncontrada = string.Empty;
                LstClienteNoEncontrados.Text = string.Empty;               
                for (int row = stats.StartRowIndex + 1; row <= stats.EndRowIndex; ++row)
                {
                   

                    ExcedentesCarga objExce = new ExcedentesCarga();      
                    objExce.TIP_INVERSION = CmbProducto.SelectedValue.ToString();
                    objExce.COD_MOVIMIENTO = "H";
                    objExce.MONTO = ArchivoExcel.GetCellValueAsDecimal(row, 3);
                    objExce.NUM_CEDULA = ArchivoExcel.GetCellValueAsString(row, 4);
                    objExce.DES_OBSERVACION = ArchivoExcel.GetCellValueAsString(row, 5);
                    objLogica = new CapaLogica();
                    string DatosCliente = objLogica.ConsultarDatosCliente(objExce.NUM_CEDULA);                    
                    objExce.COD_CLIENTE = Convert.ToDouble(DatosCliente.Split('>')[0]);
                   
                    objExce.NUM_CONTRATO = Convert.ToDouble(objLogica.ConsultarDatosContratoAhorro(objExce.COD_CLIENTE.ToString(), CmbProducto.SelectedValue.ToString()).Split('>')[0]);                   
                    objExce.NOMCLIENTE = DatosCliente.Split('>')[1];
                    if (objExce.COD_CLIENTE.ToString().Trim() == "-1")
                    {
                        CedulaNoEncontrada += objExce.NUM_CEDULA + ";";
                    }
                    //Console.WriteLine(objExce.NUM_CEDULA);
                    ListadoExcedentesCarga.Add(objExce);


                }

                dgDatosGenerar.DataSource = ListadoExcedentesCarga;
                

               

             
                
                

            

                 

        }

        void GenerarArchivo()
        {

            if (ListadoExcedentesCarga.Count <= 0)
            {
                MessageBox.Show("Debe primero cargar el archivo Excel","Validación" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ;
            

            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\ArchivoGeneradoExcedentes.txt");

            foreach (ExcedentesCarga item in ListadoExcedentesCarga)
            {

                //SI EL CLIENTE NO FUE ENCONTRADO EN PSBANK SE EXCLUYE EN LA GENERACIÓN DEL ARCHIVO
                if (item.COD_CLIENTE.ToString() == "-1")
                {
                    continue;
                }

                string Linea = item.TIP_INVERSION.Trim() + "|H|" +
                               item.MONTO.ToString().Trim() + "|" +
                               item.NUM_CEDULA.Trim() + "|" +
                               item.DES_OBSERVACION.Trim() + "|" +
                               (item.COD_CLIENTE.ToString().Trim() == "-1" ? "" : item.COD_CLIENTE.ToString().Trim()) + "|" +
                               (item.NUM_CONTRATO.ToString().Trim() == "-1" ? "" : item.NUM_CONTRATO.ToString().Trim()) + "|";

                sw.WriteLine(Linea);
            }

            sw.Close();

            
            
        }

        void HabilitaControles(bool Habilita)
        {
            BtnCargaArchivo.Enabled = Habilita;
            CmbProducto.Enabled = Habilita;
            BtnGeneraArchivo.Enabled = Habilita;
            LstClienteNoEncontrados.Enabled = Habilita;
            
        }

        private async void BtnGenerarArchivo_Click(object sender, EventArgs e)
        {
            
            opFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            DialogResult result = opFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                HabilitaControles(false);
                prges.Visible = true;
                LblRegistros.Visible = true;
                LblRegistros0.Visible = true;
                Thread.Sleep(100);
                TmProceso.Start();
                


                //CargarArchivoExcel();
                await Task.Run(new Action(() =>
                {
                    CargarArchivoExcel();
                }));



                HabilitaControles(true);
                prges.Value = 0;
                prges.Visible = false;
                LstClienteNoEncontrados.Text = CedulaNoEncontrada;
               

                

                //MessageBox.Show("Termino");
                //prges.Value = 0;
                //prges.Visible = false;
                //LstClienteNoEncontrados.Text = CedulaNoEncontrada;

                LstClienteNoEncontrados.Items.Clear();
                foreach (string item in CedulaNoEncontrada.Split(';'))
	            {
                    LstClienteNoEncontrados.Items.Add(item);
	            }

                
                

                //TmProceso.Stop();

              
                
            }
            
           

           
        }

        private void FrmGestionExcedentes_Load(object sender, EventArgs e)
        {
            ListadoProductos = new List<Productos>();
            ListadoProductos.Add(new Productos() { CodProducto = "010", NombreProducto = "Excedentes" });
            ListadoProductos.Add(new Productos() { CodProducto = "001", NombreProducto = "Capital Social" });

            ListadoProductosActivacion = new List<Productos>();
            ListadoProductosActivacion.Add(new Productos() { CodProducto = "010", NombreProducto = "Excedentes" });
            ListadoProductosActivacion.Add(new Productos() { CodProducto = "009", NombreProducto = "Ahorro a la vista" });
            ListadoProductosActivacion.Add(new Productos() { CodProducto = "015", NombreProducto = "Sobrantes" });
            


            ListadoProductosActivacionSinpe = new List<Productos>();
            ListadoProductosActivacionSinpe.Add(new Productos() { CodProducto = "010", NombreProducto = "Excedentes" });
            ListadoProductosActivacionSinpe.Add(new Productos() { CodProducto = "009", NombreProducto = "Ahorro a la vista" });
            ListadoProductosActivacionSinpe.Add(new Productos() { CodProducto = "015", NombreProducto = "Sobrantes" });

            ListadoProductosPend = new List<Productos>();
            ListadoProductosPend.Add(new Productos() { CodProducto = "010", NombreProducto = "Excedentes" });
            ListadoProductosPend.Add(new Productos() { CodProducto = "009", NombreProducto = "Ahorro a la vista" });
            ListadoProductosPend.Add(new Productos() { CodProducto = "015", NombreProducto = "Sobrantes" });


            


            ListadoExcedentesCarga = new List<ExcedentesCarga>();
            CmbProducto.DataSource = ListadoProductos;
            CmbProducto.SelectedIndex = 0;
            CmbAccion.SelectedIndex = 0;
            CmbProdActive.DataSource = ListadoProductosActivacion;
            CmbProdActivar.DataSource = ListadoProductosActivacionSinpe;
            CmbProdPend.DataSource = ListadoProductosPend;
            CmbTipoBloqueo.SelectedIndex = 0;
            CedulaNoEncontrada = string.Empty;
            prges.Visible = false;
            LblRegistros.Visible = false;
            LblRegistros.Visible = false;
            ProcesoCarga = new Task(new Action(CargarArchivoExcel));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarArchivo();
            MessageBox.Show("Archivo generado","Finalizado",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void TmProceso_Tick(object sender, EventArgs e)
        {
                        
            if (ListadoExcedentesCarga.Count <= 0)
            {
                return;
            }
            prges.Value = ListadoExcedentesCarga.Count;
            LblRegistros.Text = ListadoExcedentesCarga.Count.ToString();
            

           
        }


        private void ObtenerAsociadosNoEncontrados(ListBox pLista)
        {
            if (pLista.Items.Count <= 0)
            {
                return;
                
            }

            MessageBox.Show(null, "Los clientes no encontrados deben ser guardados en un block de notas, esta información no se puede recuperar", "RESTRINCCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);


            for (int i = 0; i < pLista.Items.Count; i++)
            {

                pLista.SetSelected(i, true);
            }
            string s = "LISTADO PERSONAS NO ENCONTRADAS EN PSBANK " +Environment.NewLine;
            foreach (object o in pLista.SelectedItems)
            {
                s += o.ToString() + Environment.NewLine;
            }
            Clipboard.SetText(s);
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            ObtenerAsociadosNoEncontrados(LstClienteNoEncontrados);
        }

        private void BtnActivarProd_Click(object sender, EventArgs e)
        {
            LblProdActive.Text = string.Empty;
            LblProdActive.Visible = false;
            DialogResult dlg = MessageBox.Show("Esta seguro de " + (CmbAccion.SelectedIndex == 0 ? "Activar" : "Inactivar") + " el producto: " + CmbProdActive.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                return;
            }

            //MessageBox.Show(CmbProdActive.SelectedValue.ToString());
            int RegistrosAfectados = 0;
            objLogica = new CapaLogica();
            RegistrosAfectados = objLogica.ActualizarProdCtaExternaSinpe(CmbProdActive.SelectedValue.ToString(), (CmbAccion.SelectedIndex == 0 ? 'S' : 'N'));
            LblProdActive.Text = "Cantidad de contratos de ahorro afectados: " + RegistrosAfectados.ToString() + " a cuenta "+Environment.NewLine+"externa traslados SINPE estado: " + (CmbAccion.SelectedIndex == 0 ? "Activo" : "Inactivo");
            LblProdActive.Visible = true;

        }

        private void BtnCargaContra_Click(object sender, EventArgs e)
        {
            opFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            DialogResult result = opFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
               // CargarArchivoExcelPagoSinpe(ref ListadoContratoGestion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int InactivacionGeneral = 0;
            int ActivacionEspecifica = 0;
            DialogResult dlg = MessageBox.Show("Esta seguro de activar especificamente los contratos de ahorro indicados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                return;
            }

            if (ListadoContratoGestion != null && ListadoContratoGestion.Count > 0)
            {
                objLogica = new CapaLogica();
                InactivacionGeneral = objLogica.ActualizarEstadoTipoAhorro(CmbProdActivar.SelectedValue.ToString(), false);
                if (InactivacionGeneral <= 0)
                {
                    MessageBox.Show("Existe un error no se encuentran ahorros del tipo " + CmbProdActivar.SelectedText + " por inactivar, favor revisar primero");
                    return;
                }
                foreach (ContratoGestion item in ListadoContratoGestion)
                {
                    objLogica = new CapaLogica();
                    ActivacionEspecifica += objLogica.ActualizarEstadoContratoAhorro(CmbProdActivar.SelectedValue.ToString(), item.Contrato, true);
                    
                }
                MessageBox.Show("Proceso finalizó con exito. Se realizó una inactivacion del producto " + CmbProdActivar.SelectedText + " de " +
                                "forma general de un total de " + InactivacionGeneral.ToString() + " contratos de ahorro y por aparte se activan " + ActivacionEspecifica.ToString() + " contratos de ahorros indicados por el usuario ","Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void BtnCargaEx_Click(object sender, EventArgs e)
        {
            opFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            DialogResult result = opFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                CargarArchivoExcelPagoSinpe(ref ListadoContratoGestion);

                if (ListadoContratoGestion.Count > 0)
                {
                    
                    dgContratoActivar.DataSource = ListadoContratoGestion;                    
                    TotalTrasladoActivoSINPE(ListadoContratoGestion,LblCantOpeCance,LblTotalCancelar);

                }
                LstNoEncontrados.Items.Clear();
                foreach (string item in PersonaNoEncontrada.Split(';'))
                {
                    LstNoEncontrados.Items.Add(item);
                }

             
                
                
            }
        }

        private void TotalTrasladoActivoSINPE(List<ContratoGestion> pLista,Label pCant, Label pSum)
        {
            if (pLista != null && pLista.Count > 0)
            {
                pCant.Text = pLista.Count <= 0 ? "" : "Ahorros por"+Environment.NewLine+" gestionar: [" + pLista.Count.ToString() + "]";
                pCant.Visible = pLista.Count <= 0 ? false : true;
                pSum.Text = pLista.Count <= 0 ? "" : pLista.Sum(x => x.MONTO).ToString("C2");
                pSum.Visible = pLista.Count <= 0 ? false : true;
            }

        }


        private void TotalTrasladoActivoSINPE2(List<ContratoGestionPendi> pLista, Label pCant, Label pSum)
        {
            if (pLista != null && pLista.Count > 0)
            {
                pCant.Text = pLista.Count <= 0 ? "" : "Ahorros por" + Environment.NewLine + "  gestionar: [" + pLista.Count.ToString() + "]";
                pCant.Visible = pLista.Count <= 0 ? false : true;
                if (CmbTipoBloqueo.SelectedIndex == 0)
                {
                    pSum.Text = pLista.Count <= 0 ? "" : pLista.Sum(x => x.MONTO_BLOQUEADO).ToString("C2");
                }
                else
                {
                    pSum.Text = pLista.Count <= 0 ? "" : pLista.Sum(x => x.MONTO_DISPONIBLE).ToString("C2");
                }
                
                pSum.Visible = pLista.Count <= 0 ? false : true;
            }

        }

        private void dgContratoGestion_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgContratoActivar.IsCurrentCellDirty)
            {
                dgContratoActivar.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ObtenerAsociadosNoEncontrados(LstNoEncontrados);
        }

        private void BtnCargaPend_Click(object sender, EventArgs e)
        {
            //opFileDialog.Filter = "Excel Files(.xlsx)|*.xlsx| Excel Files(*.xlsm)|*.xlsm";
            //DialogResult result = opFileDialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    CargarArchivoExcelPagoSinpe(ref ListadoContratoPendientes);

            //    //if (ListadoContratoPendientes.Count > 0)
            //    //{
            //    //    dgPersoPend.DataSource = ListadoContratoPendientes;
            //    //    LstNoEnconPend.Items.Clear();
            //    //    foreach (string item in PersonaNoEncontrada.Split(';'))
            //    //    {                        
            //    //        LstNoEnconPend.Items.Add(item);
            //    //    }
            //    //    TotalTrasladoActivoSINPE(ListadoContratoPendientes,LblCantPen,LblSumPen);

            //    //}
            //}
        }

        private void BtnActuaPendi_Click(object sender, EventArgs e)
        {

            if (CmbProdPend.SelectedIndex != 0)
            {
                MessageBox.Show("La programación de esta pantalla esta solo para el producto excedentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ContratosGestionadosBloq = 0;
            DialogResult dlg = MessageBox.Show("Esta seguro de " + (CmbTipoBloqueo.SelectedIndex == 0 ? "BLOQUEAR" : "DESBLOQUEAR") + " el monto disponible de los asociados mostrados para el ahorro tipo: " + CmbProdPend.Text+" ? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                return;
            }

            if (ListadoContratoPendientes != null && ListadoContratoPendientes.Count > 0)
            {
                objLogica = new CapaLogica();

              
                foreach (ContratoGestionPendi item in ListadoContratoPendientes)
                {
                    objLogica = new CapaLogica();
                    ContratosGestionadosBloq +=  objLogica.BloquearMontoContrato(CmbProdPend.SelectedValue.ToString(), item.Contrato, (CmbTipoBloqueo.SelectedIndex == 0 ? true : false));                    

                }
                BtnBD.PerformClick();
                MessageBox.Show("Proceso finalizó con exito. Se realizó bloqueo de montos del producto " + CmbProdPend.SelectedText + ", el total de contratos bloqueados es de " + ContratosGestionadosBloq.ToString(), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBD_Click(object sender, EventArgs e)
        {
            
            if (CmbProdPend.SelectedIndex != 0){
                MessageBox.Show("La programación de esta pantalla esta solo para el producto excedentes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            CargaPendientesBD(ref ListadoContratoPendientes);

            if (ListadoContratoPendientes.Count > 0)
            {
                dgPersoPend.DataSource = ListadoContratoPendientes;
                TotalTrasladoActivoSINPE2(ListadoContratoPendientes, LblCantPen, LblSumPen);

            }
        }

        private void BtnActivarTodo_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Esta seguro de activar TODOS los contratos de ahorro del tipo: " + CmbProdActivar.Text + " ? ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.No)
            {
                return;
            }

            objLogica = new CapaLogica();
            int ProdActivos = 0;
            ProdActivos = objLogica.ActualizarEstadoTipoAhorro(CmbProdActivar.SelectedValue.ToString(), true);
            MessageBox.Show("Proceso finalizó con exito. Se realizó una activación del producto " + CmbProdActivar.SelectedText + " de " +
                               "forma general de un total de " + ProdActivos.ToString() + " contratos de ahorro","Confirmación",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}