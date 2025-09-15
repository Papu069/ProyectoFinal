using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Asiento
    {
        public int Fila { get; set; }
        public int Numero { get; set; }
        public bool Ocupado { get; set; }
        public double Precio { get; set; }

        public Asiento()
        {
            this.Fila = 0;
            this.Numero = 0;
            this.Ocupado = false;
            this.Precio = 0;
        }
    }
}
