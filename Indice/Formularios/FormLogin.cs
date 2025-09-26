using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Indice.Formularios
{
    /// <summary>
    /// Formulario de inicio de sesión para acceder al catalogo de peliculas y el sistema de reservas de cine.
    /// </summary>
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento que se dispara al cargar el formulario, inicializa los campos de texto y el botón.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnIngrearIndice.Enabled = true;
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el icono de salida, cierra la aplicación.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el icono de minimizar, minimiza la ventana.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        /// <summary>
        /// Evento que se dispara al salir del campo de texto del usuario, si está 
        /// vacío, restaura el texto por defecto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de ingresar, verifica las credenciales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngrearIndice_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(Application.StartupPath, "Usuarios.txt");
            /// Si el archivo no existe, lo crea vacío.
            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "");
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);
            bool acceso = false;
            /// Recorre las líneas del archivo en bloques de 3 (usuario, contraseña, fecha de nacimiento)
            for (int i = 0; i < lineas.Length; i += 3)
            {
                string usuario = lineas[i];
                string password = lineas[i + 1];
                /// Verifica si las credenciales coinciden.
                if (txtUsuario.Text == usuario && txtPassword.Text == password)
                {
                    acceso = true;
                    break;
                }
            }
            txtUsuario.Text = "";
            txtPassword.Text = "";
            if (acceso)
            {
                Program.Inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }
        /// <summary>
        /// Evento que se dispara al entrar en el campo de texto de la contraseña, si contiene
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        /// <summary>
        /// Evento que se dispara al salir del campo de texto de la contraseña, si
        /// está vacío, restaura el texto por defecto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
            }
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el icono de nuevo administrador,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptrNuevoAdmin_Click(object sender, EventArgs e)
        {
            FormNuevoAdmin formNuevoAdmin = new FormNuevoAdmin(this);
            this.Hide();
            formNuevoAdmin.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el enlace de ayuda, muestra información de contacto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contáctate con el administrador del sistema para recuperar su usuario o contraseña." +
                " Tél: 75147665");
        }
    }
}
