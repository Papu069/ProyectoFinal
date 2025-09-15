using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Cine
    {
        public List<Pelicula> Peliculas { get; set; }
        public List<Sala> Salas { get;  set; }

        public Cine()
        {
            this.Peliculas = new List<Pelicula>();
            this.Salas = new List<Sala>();
        }
    }
}
