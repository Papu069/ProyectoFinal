using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa una película en el cine con todos los datos de la pelicula.
    /// </summary>
    public class Pelicula : Cine
    {
        public string NombreDEPelicula { get; set; }
        public string Genero { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public TimeSpan HoraDEestreno { get; set; }
        public decimal CostoEntrada { get; set; } = 35.00m;
        /// <summary>
        /// Constructor que inicializa una película con valores por defecto.
        /// </summary>
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
