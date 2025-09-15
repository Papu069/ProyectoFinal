using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Pago
    {
        public Reserva Reserva { get; set; }
        public double Precio { get; set; }
        public DateTime FechaDEPago { get; set; }
        public string MetodoDEPago { get; set; }

        public Pago()
        {
            this.Reserva = new Reserva();
            this.Precio = 0;
            this.FechaDEPago = new DateTime();
            this.MetodoDEPago = "Indefinido";
        }
    }

    public class Tarjeta
    {
        public string NumeroDETarjeta { get; set; }
        public string NombreDuenio { get; set; }
        public string FechaDEVencimiento { get; set; }
        public string Clave { get; set; }

        public Tarjeta()
        {
            this.NumeroDETarjeta = "XXXX-XXXX-XXXX-XXXX";
            this.NombreDuenio = "Sin definir";
            this.FechaDEVencimiento = "Sin definir";
            this.Clave = "XXXX";
        }
    }
}