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

namespace AppEscritorio.estructuras
{

    public class DestinationCustomer
    {
        public string Id { get; set; }

        public string IdType { get; set; }

        public string Name { get; set; }

        public string IBAN { get; set; }

        public string Email { get; set; }

        public double MontoTran { get; set; }

        public string CurrencyCode { get; set; }

        public DestinationCustomer()
        {
            this.IdType = "0"; //Persona Física nacional (catalogo "Tipos de Identificacion" - Enviado por Prosoft

            this.Name = string.Empty;

            this.IBAN = string.Empty;

            this.Email = string.Empty;

            this.MontoTran = 0.00;

            this.CurrencyCode = "CRC";
        }
    }

    public class ResPINEntity
    {
        public bool PINEntity { get; set; }
        public bool IsSuccessful { get; set; }

        public List<object> Errors { get; set; }

        public string OperationId { get; set; }

        public ResPINEntity()
        {
            this.PINEntity = false;
        }
    }

    public class ReqPinEntity
    {
        public string HostId { get; set; }
        public string OperationId { get; set; }
        public string ClientIPAddress { get; set; }
        public string CultureCode { get; set; }
        public string AccountNumber { get; set; }

        public ReqPinEntity()
        {
            this.HostId = "d4m8dt+vRNc0eUq0LglIJm4tZ+wmDde3zEOaYmalGJ4kaUSpi37+PpqAHfkZ7ookOq4pNaUMPcCrPPyLR0Z5ug==";
            this.OperationId = string.Empty;
            this.ClientIPAddress = "127.0.0.1";
            this.CultureCode = "ES-CR";
            this.AccountNumber = string.Empty;
        }
    }

    public class cifras
    {

        public string DetalleCifra {get;set;}      
        public string Modulo{get;set;}
        public Decimal SIC { get; set; }
        public Decimal PsBank { get; set; }
    }

    public class vendedores
    {
        public int cod_vendedor { get; set; }
        public string nombre_vendedor { get; set; } 
    }

    public class Usuario
    {
        public string cod_usuario { get; set; }
        public string des_nombre { get; set; }
        public int cod_vendedor { get; set; }
        
    }

    public class sucursales
    {
        public string cod_sucursal { get; set; }
        public string nom_sucursal { get; set; }
    }

    public class ahorrosP
    {
        public int cod_cliente { get; set; }
        public string nom_cliente { get; set; }
        public int num_contrato { get; set; }
        public decimal mon_saldo_real { get; set; }
        public int seleccionado { get; set; }
        public DateTime ? fec_vencimiento {get; set; }
    }

    

    public static class utilidades
    {
        public static void ExportToExcel(DataGridView dg, string titulo)
        {
            // Creating a Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = titulo;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;



                worksheet.Columns.NumberFormat = "@";


                //Loop through each row and read value from each column. 
                for (int i = -1; i < dg.Rows.Count; i++)
                {
                    for (int j = 0; j < dg.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dg.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dg.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Exportación realizada");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }

        }
    }
}
