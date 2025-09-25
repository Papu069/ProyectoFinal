using Indice.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Indice.Formularios
{
    public partial class FormPago : Form
    {
        private FormInicio _formInicio;
        private Pelicula _pelicula;
        private Sala _sala;
        private List<Asiento> _asientosSeleccionados;

        public FormPago(FormInicio formInicio, Pelicula pelicula, Sala sala, List<Asiento> asientosSeleccionados)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula;
            _sala = sala;
            _asientosSeleccionados = asientosSeleccionados;
        }

        private void FormPago_Load_1(object sender, EventArgs e)
        {
            double total = 0;
            foreach (var asiento in _asientosSeleccionados)
                total += asiento.Precio;

            lblTotal.Text = $"Total: Bs. {total}";
        }
        
        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCI.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos del usuario.");
                return;
            }

            Usuario usuario = new Usuario
            {
                Nombre = txtNombre.Text,
                CI = int.Parse(txtCI.Text),
                Telefono = int.Parse(txtTelefono.Text)
            };

            foreach (var asiento in _asientosSeleccionados)
                asiento.Ocupado = true;

            FormBoleto formBoleto = new FormBoleto(_formInicio, _pelicula, _sala, _asientosSeleccionados, usuario);
            this.Hide();
            formBoleto.ShowDialog();
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                rbtTarjeta.Checked = true;
                rbtEfectivo.Checked = false;
            }
            else
            {
                rbtTarjeta.Checked = false;
                rbtEfectivo.Checked = true;
            }
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
