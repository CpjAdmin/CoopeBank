using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.ComparabilidadFinanciera
{
    public enum enum_TipoArchivo {ICFPC,ICFMP};
    public enum enum_TipoPersona { Fisica = 1, Juridica = 2}

    public class EncabezadoXML
    {
        public int IdEncabezado { get; set; }

        public enum_TipoArchivo CodArchivo { get; set; }

        public string NombreContacto { get; set; }

        public string CorreoContacto { get; set; }

        public string TelContacto { get; set; }

        public string NombreArchivo { get; set; }

        public enum_TipoPersona TipoPersona { get; set; }

        public string IdOferente { get; set; }

        public string Periodo { get; set; }

        
    }

}
