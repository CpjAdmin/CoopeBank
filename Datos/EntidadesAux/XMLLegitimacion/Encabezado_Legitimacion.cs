using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.XMLLegitimacion
{
    public class Encabezado_Legitimacion
    {
       
            public string clase { get; set; }
            public string versionClase { get; set; }
            public string archivo { get; set; }
            public string versionArchivo { get; set; }
            public string Periodo { get; set; }
            public string entidad { get; set; }
            public string tipoCarga { get; set; }
            public string tipoMoneda { get; set; }
        
    }
}
