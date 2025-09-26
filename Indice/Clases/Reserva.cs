using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa una reserva de boletos de cine.
    /// </summary>
    public class Reserva
    {

        public Usuario Usuario { get; set; }
        public List<Boleto> Boletos { get; set; }
        public DateTime FechaDEReserva { get; set; }
        public bool Confirmado { get; set; }

        /// <summary>
        /// Constructor que inicializa una reserva con valores por defecto.
        /// </summary>
        public Reserva()
        {
            this.Usuario = new Usuario();
            this.Boletos = new List<Boleto>();
            this.FechaDEReserva = new DateTime();
            this.Confirmado = true;
        }
    }
}
