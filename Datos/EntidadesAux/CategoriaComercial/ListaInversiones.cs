using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EntidadesAux.CategoriaComercial
{
    public class ListaInversiones
    {
        public string COD_INVERSION { get; set; }

        public string DES_INVERSION { get; set; }

        public string FULL_INVERSION
        {
            get
            {
                return COD_INVERSION + " - " + DES_INVERSION;
            }
        }
    }
}
