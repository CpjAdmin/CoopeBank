using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux
{
    public class OpeIncob
    {

        public string COD_COMPANIA { get; set; }
        public string DES_IDENTIFICACION { get; set; }
        public int COD_CLIENTE { get; set; }
        public string NOM_CLIENTE { get; set; }
        public string NUM_OPERACION { get; set; }
        public DateTime FEC_ULTPINT { get; set; }
        public DateTime FEC_VENCIMIENTO { get; set; }
        public decimal Saldo { get; set; }
        public int CancelarSaldo { get; set; }
        public int CuotaCancela { get; set; }
        public string COD_CENTRO { get; set; }
        public decimal POR_TASA { get; set; }
    }
}
