using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux
{
    public class AsoReingreso
    {
        public string PDES_IDENTIFICACION { get; set; } 
        public string NOM_CLIENTE { get; set; }
        
        public DateTime PFEC_REGISTRO { get; set; }
        public DateTime PFEC_REINGRESO { get; set; }
        public string USU_AFILIA { get; set; }
        public string USU_REGISTRO { get; set; }
        
    }
}
