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
    public partial class FormBoleto : Form
    {
        private FormInicio _formInicio;
        private Pelicula _pelicula;
        private Sala _sala;
        private List<Asiento> _asientosSeleccionados;
        private Usuario _usuario;

        public FormBoleto(FormInicio formInicio, Pelicula pelicula, Sala sala, List<Asiento> asientosSeleccionados, Usuario usuario)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula;
            _sala = sala;
            _asientosSeleccionados = asientosSeleccionados;
            _usuario = usuario;
        }

        private void FormBoleto_Load_1(object sender, EventArgs e)
        {
            double total = _asientosSeleccionados.Sum(a => a.Precio);

            lblUsuario.Text = $"{_usuario.Nombre} (CI: {_usuario.CI}, Tel: {_usuario.Telefono})";
            lblPelicula.Text = $"{_pelicula.NombreDEPelicula}";
            lblSala.Text = $"{_sala.NumDESala}";
            lblFecha.Text = $"{DateTime.Now}";
            lblAsientos.Text = "Asientos: " + string.Join(", ", _asientosSeleccionados.Select(a => $"{a.Fila}-{a.Numero}"));
            lblTotal.Text = $"Total Pagado: Bs. {total}";
        }

        private void ptrInicio_Click(object sender, EventArgs e)
        {
            _formInicio.Show();
            this.Close();
        }
    }
}
