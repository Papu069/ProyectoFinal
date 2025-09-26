using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa un cine con sus películas y salas.
    /// </summary>
    public class Cine
    {
        public List<Pelicula> Peliculas { get; set; }
        public List<Sala> Salas { get;  set; }
        /// <summary>
        /// Constructor que inicializa Cine con listas vacías de películas y salas.
        /// </summary>
        public Cine()
        {
            this.Peliculas = new List<Pelicula>();
            this.Salas = new List<Sala>();
        }
    }
}
