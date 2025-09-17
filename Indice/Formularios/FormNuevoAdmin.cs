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
    public partial class FormNuevoAdmin: Form
    {
        FormLogin formAnterior;
        public FormNuevoAdmin()
        {
            InitializeComponent();
        }

        public FormNuevoAdmin(FormLogin formlogin)
        {
            InitializeComponent();
            formAnterior = formlogin;
        }

        private void ptrRetroceso_Click(object sender, EventArgs e)
        {
            formAnterior.Show();
            this.Hide();
        }

        private void btnConfirmarUsuario_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == txtConfPass.Text)
            {
                string[] datosUsuarios = { txtNuevoUsuario.Text, txtConfPass.Text };
                using (StreamWriter datos = new StreamWriter(@"C:\\ProyectoFinalProgra3\\fase 2\\Usuarios.txt", true))
                {
                    foreach (string guardar in datosUsuarios)
                    {
                        datos.WriteLine(guardar);
                    }
                }
                formAnterior.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden, intente de nuevo");
                txtNuevoUsuario.Text = string.Empty;
                txtPass.Text = string.Empty;
                txtConfPass.Text = string.Empty;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void txtConfPass_Enter(object sender, EventArgs e)
        {
            txtConfPass.UseSystemPasswordChar = true;
        }
    }
}
