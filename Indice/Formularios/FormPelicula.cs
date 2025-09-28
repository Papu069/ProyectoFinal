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
    /// Formulario que muestra la información de una película y permite comprar entradas.
    /// </summary>
    public partial class FormPelicula : Form
    {
        private FormInicio _formInicio;
        private Pelicula _pelicula;
        private Sala _sala;
        /// <summary>
        /// Constructor del formulario de película.
        /// Inicializa referencias al formulario de inicio, la película y la primera sala disponible.
        /// </summary>
        /// <param name="formInicio">Formulario principal de la aplicación.</param>
        /// <param name="pelicula">Película seleccionada.</param>
        /// <param name="sala">Sala de la película (se asigna la primera del listado de salas de la película).</param>
        public FormPelicula(FormInicio formInicio, Pelicula pelicula, Sala sala)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula;
            _sala = pelicula.Salas[0];
        }
        /// <summary>
        /// Evento que se ejecuta al hacer clic en la flecha de retroceso.
        /// Cierra el formulario actual y regresa al anterior.
        /// </summary>
        private void ptrRetroceso2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Evento que se ejecuta al cargar el formulario.
        /// Muestra la información de la película en los labels correspondientes.
        /// </summary>
        private void FormPelicula_Load(object sender, EventArgs e)
        {
            lblNamePelicula.Text = _pelicula.NombreDEPelicula;
            lblGenero.Text = _pelicula.Genero;
            lblDescripcion.Text = _pelicula.Descripcion;
            lblFechaEstreno.Text = _pelicula.FechaEstreno.ToShortDateString();
            lblhorafuncion.Text = _pelicula.HoraDEestreno.ToString();
            lblCostoEntrada.Text = $"P/U: Bs. {_pelicula.CostoEntrada}";
        }
        /// <summary>
        /// Evento del botón "Comprar".
        /// Abre el formulario de selección de asientos y oculta el formulario de película.
        /// </summary>
        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormAsiento formAsiento = new FormAsiento(_formInicio, _pelicula, _sala);
            this.Hide();
            formAsiento.ShowDialog();
        }
    }
}
