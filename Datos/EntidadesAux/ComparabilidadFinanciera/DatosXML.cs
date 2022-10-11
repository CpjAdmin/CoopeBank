using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.ComparabilidadFinanciera
{
    public class DatosXML
    {
        public int IdEncabezado { get; set; }

        public int IdDatos { get; set; }

        public List<ProductoFinanciero> ListadoProductos { get; set; }
    }
}
