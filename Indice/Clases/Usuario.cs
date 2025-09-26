using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indice.Clases
{
    /// <summary>
    /// Clase que representa un usuario del sistema de reservas de cine.
    /// </summary>
    public class Usuario
    {
        public string Nombre { get; set; }
        public int CI { get; set; }
        public int Telefono { get; set; }
        /// <summary>
        /// Constructor que inicializa un usuario con valores por defecto.
        /// </summary>
        public Usuario()
        {
            this.Nombre = "Usuario";
            this.CI = 10000000;
            this.Telefono = 10000000;
        }
    }
}
