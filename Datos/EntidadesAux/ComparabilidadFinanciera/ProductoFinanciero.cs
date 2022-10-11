using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.ComparabilidadFinanciera
{
    public class ProductoFinanciero
    {
        public int CodigoProducto { get; set; }
        
        public int TipoProducto { get; set; }

        public int TipoUso { get; set; }

        public int TipoGenerador { get; set; }

        public int TipoCliente { get; set; }

        public string NombreProducto { get; set; }

        public int TipoMoneda { get; set; }

        public int Plazo { get; set; }

        public double Prima { get; set; }

        public int TipoTasa { get; set; }

        public double MontoMaximo { get; set; }

        public double TasaNominal { get; set; }

        public double TasaMoratoria { get; set; }

        public string ObsTasa { get; set; }

        public string Beneficios { get; set; }

        public List<Cargo> ListadoCargos { get; set; }
    }
}
