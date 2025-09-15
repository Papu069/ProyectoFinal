using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Pelicula
    {
        public string NombreDEPelicula { get; set; }
        public string Genero { get; set; }
        public int Estreno { get; set; }

        public Pelicula()
        {
            this.NombreDEPelicula = "Vacio";
            this.Genero = "Desconocido";
            this.Estreno = 2000;
        }
    }
}
