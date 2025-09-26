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
    /// Formulario para crear un nuevo usuario administrador.
    /// </summary>
    public partial class FormNuevoAdmin: Form
    {
        FormLogin formAnterior;
        /// <summary>
        /// Constructor que inicializa el formulario.
        /// </summary>
        public FormNuevoAdmin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor que inicializa el formulario y recibe una referencia al formulario de login.
        /// Permite regresar al formulario anterior después de crear el nuevo administrador.
        /// </summary>
        /// <param name="formlogin">Referencia al formulario de login que invocó este formulario.</param>
        public FormNuevoAdmin(FormLogin formlogin)
        {
            InitializeComponent();
            formAnterior = formlogin;
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el icono de retroceso, regresa al formulario anterior.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptrRetroceso_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Hide();
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de confirmar usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            /// Verifica que las contraseñas coincidan antes de guardar el nuevo usuario.
            if (txtPass.Text == txtConfPass.Text)
            {
                string rutaArchivo = Path.Combine(Application.StartupPath, "Usuarios.txt");
                /// Si el archivo no existe, lo crea vacío.
                if (!File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, "");
                }

                string[] datosUsuarios = { txtNuevoUsuario.Text, txtConfPass.Text, dtpFechaNacimiento.Text };

                using (StreamWriter datos = new StreamWriter(rutaArchivo, true))
                {
                    /// Guarda el nuevo usuario, contraseña y fecha de nacimiento en el archivo.
                    foreach (string guardar in datosUsuarios)
                    {
                        datos.WriteLine(guardar);
                    }
                }
                formAnterior.Show();
                this.Close();
            }
            /// Si las contraseñas no coinciden, muestra un mensaje de error y limpia los campos.
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, intente de nuevo");
                txtNuevoUsuario.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtConfPass.Text = string.Empty;
            }
        }
        /// <summary>
        /// Evento que se dispara al entrar en el campo de texto de la 
        /// contraseña, activa el modo de contraseña.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
        /// <summary>
        /// Evento que se dispara al entrar en el campo de texto de la
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtConfPass_Enter(object sender, EventArgs e)
        {
            txtConfPass.UseSystemPasswordChar = true;
        }
    }
}
