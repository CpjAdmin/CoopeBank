using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.XMLLegitimacion
{
    public class DatosXMLLegitimacion
    {
        public string tipo_persona { get; set; }

        public string id_persona { get; set; }

        public string tipo_operacion { get; set; }

        public string tipo_entrada_salida { get; set; }

        public string tipo_moneda { get; set; }

        public decimal monto { get; set; }

        public DateTime fecha_transaccion { get; set; }

        public string tipo_transaccion { get; set; }

        public string tipo_actividad { get; set; }

        public string origen_fondos { get; set; }

        public string fecha { get; set; }

    }
}
