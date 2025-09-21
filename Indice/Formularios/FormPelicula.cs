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
    public partial class FormPelicula : Form
    {
        private Pelicula _pelicula;
        public FormPelicula(Pelicula pelicula)
        {
            InitializeComponent();
            _pelicula = pelicula;
        }

        private void ptrRetroceso2_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            this.Hide();
            formInicio.ShowDialog();
            this.Show();
        }

        private void FormPelicula_Load(object sender, EventArgs e)
        {
            lblNamePelicula.Text = _pelicula.NombreDEPelicula;
            lblGenero.Text = _pelicula.Genero;
            lblDescripcion.Text = _pelicula.Descripcion;
            lblFechaEstreno.Text = _pelicula.FechaEstreno.ToShortDateString();
            lblCostoEntrada.Text = $"P/U: Bs. {_pelicula.CostoEntrada}";
        }
    }
}
