using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux
{
    public class ContratoGestionPendi
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Contrato { get; set; }
        public decimal MONTO_REAL { get; set; }
        public decimal MONTO_DISPONIBLE { get; set; }
        public decimal MONTO_BLOQUEADO { get; set; }
        public bool habilitar { get; set; }
    }
}
