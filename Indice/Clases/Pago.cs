using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa un pago realizado para una reserva.
    /// </summary>
    public class Pago
    {
        public Reserva Reserva { get; set; }
        public double Precio { get; set; }
        public DateTime FechaDEPago { get; set; }
        public string MetodoDEPago { get; set; }

        /// <summary>
        /// Constructor que inicializa un pago con valores por defecto.
        /// </summary>
        public Pago()
        {
            this.Reserva = new Reserva();
            this.Precio = 0;
            this.FechaDEPago = new DateTime();
            this.MetodoDEPago = "Indefinido";
        }
    }
    /// <summary>
    /// Clase que representa una tarjeta de crédito o débito.
    /// </summary>
    public class Tarjeta
    {
        public string NumeroDETarjeta { get; set; }
        public string NombreDuenio { get; set; }
        public string FechaDEVencimiento { get; set; }
        public string Clave { get; set; }
        /// <summary>
        /// Constructor que inicializa una tarjeta con valores por defecto.
        /// </summary>
        public Tarjeta()
        {
            this.NumeroDETarjeta = "XXXX-XXXX-XXXX-XXXX";
            this.NombreDuenio = "Sin definir";
            this.FechaDEVencimiento = "Sin definir";
            this.Clave = "XXXX";
        }
    }
}