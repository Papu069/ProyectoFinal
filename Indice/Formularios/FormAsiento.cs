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
    /// Formulario para la selección de asientos en una sala de cine.
    /// </summary>
    public partial class FormAsiento : Form
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
        /// Lista de asientos seleccionados por el usuario.
        /// </summary>
        private List<Asiento> _asientosSeleccionados = new List<Asiento>();
        /// <summary>
        /// Constructor que inicializa el formulario con la película y sala seleccionadas.
        /// </summary>
        /// <param name="formInicio">Referencia al formulario de inicio.</param>
        /// <param name="pelicula">Película seleccionada.</param>
        /// <param name="sala">Sala seleccionada.</param>
        public FormAsiento(FormInicio formInicio, Pelicula pelicula, Sala sala)
        {
            InitializeComponent();
            _formInicio = formInicio; 
            _pelicula = pelicula;     
            _sala = sala;             
        }
        /// <summary>
        /// Evento que se dispara al cargar el formulario, genera los asientos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAsiento_Load_1(object sender, EventArgs e)
        {

            GenerarAsientos();
        }
        /// <summary>
        /// Genera los botones de asientos en el panel, asignando colores según su estado (ocupado o libre).
        /// </summary>
        private void GenerarAsientos()
        {
            int filas = 7;
            int columnas = 9;

            panelAsientos.Controls.Clear();
            /// Si la sala no tiene asientos, se crean nuevos asientos.
            if (_sala.Asientos.Count == 0)
            {
                /// Crear asientos en la sala
                for (int f = 0; f < filas; f++)
                {
                    /// Crear una fila de asientos
                    for (int c = 0; c < columnas; c++)
                    {
                        Asiento asiento = new Asiento()
                        {
                            Fila = f + 1,
                            Numero = c + 1,
                            Ocupado = false,
                            Precio = (double)_pelicula.CostoEntrada
                        };
                        _sala.Asientos.Add(asiento);
                    }
                }
            }
            /// Crear botones para cada asiento
            for (int i = 0; i < _sala.Asientos.Count; i++)
            {
                Asiento asiento = _sala.Asientos[i];
                int f = asiento.Fila - 1;
                int c = asiento.Numero - 1;

                Button btn = new Button();
                btn.Width = 60;
                btn.Height = 40;
                btn.Left = c * (60 + 5);
                btn.Top = f * (60 + 5);
                btn.Text = $"{asiento.Fila}-{asiento.Numero}";
                btn.Tag = asiento;

                btn.BackColor = asiento.Ocupado ? Color.Red : Color.Green;

                btn.Click += BtnAsiento_Click;
                panelAsientos.Controls.Add(btn);
            }
        }
        /// <summary>
        /// Maneja el evento de clic en un botón de asiento, seleccionando o deseleccionando el asiento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Asiento asiento = (Asiento)btn.Tag;
            /// Si el asiento está ocupado, no se puede seleccionar.
            if (asiento.Ocupado) return;
            /// Alternar selección del asiento
            if (_asientosSeleccionados.Contains(asiento))
            {
                _asientosSeleccionados.Remove(asiento);
                btn.BackColor = Color.Green;
            }
            else
            {
                _asientosSeleccionados.Add(asiento);
                btn.BackColor = Color.Yellow;
            }
        }
        /// <summary>
        /// Maneja el evento de clic en el botón de confirmar, validando la selección y abriendo el formulario de pago.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            if (_asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un asiento.");
                return;
            }

            FormPago formPago = new FormPago(_formInicio, _pelicula, _sala, _asientosSeleccionados);
            this.Hide();
            formPago.ShowDialog();

            panelAsientos.Controls.Clear();
            GenerarAsientos();
        }
        /// <summary>
        /// Maneja el evento de clic en el botón de salir, cerrando el formulario actual.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ptrExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
