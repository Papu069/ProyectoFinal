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
    /// <summary>
    /// Formulario para procesar el pago de los asientos seleccionados de una película.
    /// </summary>
    public partial class FormPago : Form
    {
        private FormInicio _formInicio;
        private Pelicula _pelicula;
        private Sala _sala;
        private List<Asiento> _asientosSeleccionados;
        /// <summary>
        /// Constructor del formulario de pago.
        /// Inicializa las referencias al formulario de inicio, película, sala y los asientos seleccionados.
        /// </summary>
        /// <param name="formInicio">Formulario principal de la aplicación.</param>
        /// <param name="pelicula">Película seleccionada.</param>
        /// <param name="sala">Sala donde se proyecta la película.</param>
        /// <param name="asientosSeleccionados">Lista de asientos que el usuario ha seleccionado.</param>
        public FormPago(FormInicio formInicio, Pelicula pelicula, Sala sala, List<Asiento> asientosSeleccionados)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula;
            _sala = sala;
            _asientosSeleccionados = asientosSeleccionados;
        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Calcula el total de la compra y muestra el grupo de tarjeta si está seleccionado.
        /// </summary>
        private void FormPago_Load_1(object sender, EventArgs e)
        {
            double total = 0;
            foreach (var asiento in _asientosSeleccionados)
                total += asiento.Precio;

            lblTotal.Text = $"Total: Bs. {total}";
            grpTarjeta.Visible = rbtTarjeta.Checked;
        }

        /// <summary>
        /// Evento del botón de pagar.
        /// Valida los datos del usuario, marca los asientos como ocupados y abre el formulario del boleto.
        /// </summary>
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

        /// <summary>
        /// Evento que se ejecuta al cambiar la opción de pago a tarjeta.
        /// Muestra u oculta el grupo de tarjeta según la selección.
        /// </summary>
        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            grpTarjeta.Visible = rbtTarjeta.Checked;
        }

        /// <summary>
        /// Evento que se ejecuta al cancelar la compra.
        /// Cierra el formulario de pago.
        /// </summary>
        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void rbtEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
