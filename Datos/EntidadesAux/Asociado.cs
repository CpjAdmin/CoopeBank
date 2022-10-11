using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux
{
    public class Asociado
    {
        public int COD_CLIENTE { get; set; }
        public string DES_IDENTIFICACION { get; set; }
        public string NOM_CLIENTE { get; set; }

        public DateTime FEC_INACTIVO { get; set; }
        public DateTime FEC_AFILIACION { get; set; }
        public DateTime FEC_REGISTRO { get; set; }
        public DateTime PFEC_REINGRESO { get; set; }
        public string USU_AFILIA { get; set; }
        public string USU_REGISTRO { get; set; }

        public string COD_ESTADO { get; set; }

        public int TipoPersona { get; set; }
       
        public Asociado()
        {
            this.TipoPersona = 1;
        }

    }
}
