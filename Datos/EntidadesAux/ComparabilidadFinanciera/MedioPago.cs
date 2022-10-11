using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.ComparabilidadFinanciera
{
    public class MedioPago
    {
        public string CodigoProducto { get; set; }

        public int TipoMedio { get; set; }

        public string MarcaMedio { get; set; }

        public string NombreMedio { get; set; }

        public int TipoMoneda { get; set; }

        public double LineaCredito { get; set; }

        public int Plazo { get; set; }

        public int PlazoMaximo { get; set; }

        public int Lugares { get; set; }

        public int Cobertura { get; set; }

        public string Observaciones { get; set; }

        public string Beneficios { get; set; }

        public List<Cargo> ListadoCargosMedio { get; set; }

        public string pXML_ListaCargos { get; set; }

        public MedioPago()
        {
            this.ListadoCargosMedio = null;
            this.pXML_ListaCargos = string.Empty;
        }

    }
}
