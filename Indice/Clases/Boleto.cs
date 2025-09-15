using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Boleto
    {
        public int ID { get; set; }
        public Pelicula Pelicula { get; set; }
        public Sala Sala { get; set; }
        public DateTime FechaDEPelicula { get; set; }
        public double Precio { get; set; }

        public Boleto()
        {
            this.ID = 000;
            this.Pelicula = new Pelicula();
            this.Sala = new Sala();
            this.FechaDEPelicula = new DateTime();
            this.Precio = 0;
        }
    }
}
