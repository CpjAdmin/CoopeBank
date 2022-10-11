using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.ComparabilidadFinanciera
{
    public class Cargo
    {
        public int CodigoProducto { get; set; }

        public string CodTipoCobro { get; set; }
        public int TipoCargo { get; set; }

        public double ValorCargo { get; set; }

        public int TipoValorCargo { get; set; }

        public string ObsCargo { get; set; }

        public int TipoMonedaCargo { get; set; }

        public Cargo()
        {
            this.TipoMonedaCargo = 1;
        }



    }
}
