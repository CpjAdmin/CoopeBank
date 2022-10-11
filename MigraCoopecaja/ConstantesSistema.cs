using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorio
{

    public struct CatalogoBCCR
    {
        public string NomCatalogo { get; set; }
        public int Codigo { get; set; }
        public string Campo1 { get; set;  }

        public string Campo2 { get; set; }

       

    }
    public static class ConstantesSistema
    {
              

        //Catalog SUGEF "Tipo categoría crediticia" estos catalogos no sufren cambio casi nunca, por eso se crea como constante del sistema
        public static List<CatalogoBCCR> K_TipoCateCredi
        {
           get
            {
                List<CatalogoBCCR> listaAux = new List<CatalogoBCCR>();
                using (StreamReader leerArchivo = new StreamReader("CatalogosBCCR.txt"))
                {
                    string linea;
                    
                    while ((linea = leerArchivo.ReadLine())!=null)
                    {
                        if (linea.Length > 0 && linea.Substring(0,2) == "*-")
                        {
                            string[] parte = linea.Substring(2).Split(';');
                            listaAux.Add(new CatalogoBCCR() { NomCatalogo = parte[0], Codigo = Convert.ToInt32(parte[1]), Campo1 = parte[2], Campo2 = parte[3] });
                        }
                        
                    }
                }
                return listaAux;
            }
        }

    }
}
