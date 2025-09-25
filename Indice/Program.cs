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
    class Program
    {
        public static FormLogin Login;
        public static FormInicio Inicio;
        static void Main(string[] args) 
        {
            List<Sala> _salas = new List<Sala>();
            List<Asiento> _asientosGuardados = new List<Asiento>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login = new FormLogin();
            Inicio = new FormInicio();

            Application.Run(new FormLogin());
        }
    }
}
