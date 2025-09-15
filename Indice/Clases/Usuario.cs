using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int CI { get; set; }
        public int Telefono { get; set; }

        public Usuario()
        {
            this.Nombre = "Usuario";
            this.CI = 10000000;
            this.Telefono = 10000000;
        }
    }
}
