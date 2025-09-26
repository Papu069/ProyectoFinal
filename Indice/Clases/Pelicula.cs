using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    public class Pelicula : Cine
    {
        public string NombreDEPelicula { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public TimeSpan HoraDEestreno { get; set; }
        public decimal CostoEntrada { get; set; } = 35.00m;

        public Pelicula()
        {
            this.NombreDEPelicula = "Desconocido";
            this.Genero = "Desconocido";
            this.Descripcion = "Sin Descripcion";
            this.FechaEstreno = new DateTime();
            this.HoraDEestreno = new TimeSpan();
        }
    }
}
