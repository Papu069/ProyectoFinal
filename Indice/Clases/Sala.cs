using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Sala
    {
        public int NumDESala { get; set; }
        public int Capacidad { get; set; }
        public List<Asiento> Asientos { get; set; }

        public Sala()
        {
            this.NumDESala = 0;
            this.Capacidad = 0;
            this.Asientos = new List<Asiento>();
        }
    }
}
