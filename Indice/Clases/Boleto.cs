using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa un boleto de cine.
    /// </summary>
    public class Boleto
    {
        public Pelicula Pelicula { get; set; }
        public Sala Sala { get; set; }
        public DateTime FechaDEPelicula { get; set; }
        public double Precio { get; set; }

        /// <summary>
        /// Constructor que inicializa un boleto con valores por defecto.
        /// </summary>
        public Boleto()
        {
            this.Pelicula = new Pelicula();
            this.Sala = new Sala();
            this.FechaDEPelicula = new DateTime();
            this.Precio = 0;
        }
    }
}
