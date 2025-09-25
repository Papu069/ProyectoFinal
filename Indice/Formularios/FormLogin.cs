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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load_1(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = false;
            txtPassword.ReadOnly = false;
            btnIngrearIndice.Enabled = true;
        }

        private void ptrExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void btnIngrearIndice_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(Application.StartupPath, "Usuarios.txt");

            if (!File.Exists(rutaArchivo))
            {
                File.WriteAllText(rutaArchivo, "");
            }

            string[] lineas = File.ReadAllLines(rutaArchivo);
            bool acceso = false;
            for (int i = 0; i < lineas.Length; i += 3)
            {
                string usuario = lineas[i];
                string password = lineas[i + 1];

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

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "CONTRASEÑA";
            }
        }

        private void ptrNuevoAdmin_Click(object sender, EventArgs e)
        {
            FormNuevoAdmin formNuevoAdmin = new FormNuevoAdmin(this);
            this.Hide();
            formNuevoAdmin.ShowDialog();
            this.Show();
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contáctate con el administrador del sistema para recuperar su usuario o contraseña." +
                " Tél: 75147665");
        }
    }
}
