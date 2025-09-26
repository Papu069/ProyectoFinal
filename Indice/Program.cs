using Indice.Clases;
using Indice.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indice

{

    // Clase principal del programa
    class Program
    {
        // Instancia global del formulario de login
        public static FormLogin Login;
        // Instancia global del formulario de inicio
        public static FormInicio Inicio;

        // Método principal de la aplicación
        static void Main(string[] args)
        {
            // Lista de salas de cine
            List<Sala> _salas = new List<Sala>();
            // Lista de asientos guardados
            List<Asiento> _asientosGuardados = new List<Asiento>();

            // Configuración visual de la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicialización de los formularios
            Login = new FormLogin();
            Inicio = new FormInicio();

            // Ejecuta el formulario de login como ventana principal
            Application.Run(new FormLogin());
        }
    }
}
