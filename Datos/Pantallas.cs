//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pantallas
    {
        public int IdSubOp { get; set; }
        public int IdPantalla { get; set; }
        public string DesPantalla { get; set; }
        public string NomPantalla { get; set; }
        public int EstPantalla { get; set; }
    
        public virtual SubOpciones SubOpciones { get; set; }
    }
}