using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Reserva
    {
        public Usuario Usuario { get; set; }
        public List<Boleto> Boletos { get; set; }
        public DateTime FechaDEReserva { get; set; }
        public bool Confirmado { get; set; }

        public Reserva()
        {
            this.Usuario = new Usuario();
            this.Boletos = new List<Boleto>();
            this.FechaDEReserva = new DateTime();
            this.Confirmado = true;
        }
    }
}
