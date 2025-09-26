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
    /// Formulario que muestra el boleto de cine con los detalles de la reserva.
    /// </summary>
    public partial class FormBoleto : Form
    {
        /// <summary>
        /// Referencia al formulario de inicio.
        /// </summary>
        private FormInicio _formInicio;
        /// <summary>
        /// La película seleccionada.
        /// </summary>
        private Pelicula _pelicula;
        /// <summary>
        /// La sala donde se seleccionan los asientos.
        /// </summary>
        private Sala _sala;
        /// <summary>
        ///Lista de asientos seleccionados por el usuario.
        /// </summary>
        private List<Asiento> _asientosSeleccionados;
        /// <summary>
        /// El usuario que realizó la reserva.
        /// </summary>
        private Usuario _usuario;
        /// <summary>
        /// Constructor que inicializa el formulario con la película, sala, asientos seleccionados y usuario.
        /// </summary>
        /// <param name="formInicio">Formulario de inicio desde el cual se navega.</param>
        /// <param name="pelicula">Película seleccionada por el usuario.</param>
        /// <param name="sala">Sala donde se proyecta la película.</param>
        /// <param name="asientosSeleccionados">Lista de asientos reservados por el usuario.</param>
        /// <param name="usuario">Usuario que realiza la reserva.</param>
        public FormBoleto(FormInicio formInicio, Pelicula pelicula, Sala sala, List<Asiento> asientosSeleccionados, Usuario usuario)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula; 
            _sala = sala; 
            _asientosSeleccionados = asientosSeleccionados; 
            _usuario = usuario; 
        }
        /// <summary>
        /// Evento que se dispara al cargar el formulario, muestra los detalles del boleto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBoleto_Load_1(object sender, EventArgs e)
        {
            double total = _asientosSeleccionados.Sum(a => a.Precio);

            lblUsuario.Text = $"{_usuario.Nombre} (CI: {_usuario.CI}, Tel: {_usuario.Telefono})";
            lblPelicula.Text = $"{_pelicula.NombreDEPelicula}";
            lblSala.Text = $"{_sala.NumDESala}";
            lblFecha.Text = $"{DateTime.Now}";
            lblhorafunciohn.Text = $"{_pelicula.HoraDEestreno}";
            lblAsientos.Text = "Asientos: " + string.Join(", ", _asientosSeleccionados.Select(a => $"{a.Fila}-{a.Numero}"));
            lblTotal.Text = $"Total Pagado: Bs. {total}";
        }
        /// <summary>
        /// Evento que se dispara al hacer clic en el ícono de inicio, vuelve al formulario de inicio.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptrInicio_Click(object sender, EventArgs e)
        {
            _formInicio.Show();
            this.Close();
        }
    }
}
