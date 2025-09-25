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
    public partial class FormAsiento : Form
    {
        private FormInicio _formInicio;
        private Pelicula _pelicula;
        private Sala _sala;
        private List<Asiento> _asientosSeleccionados = new List<Asiento>();

        public FormAsiento(FormInicio formInicio, Pelicula pelicula, Sala sala)
        {
            InitializeComponent();
            _formInicio = formInicio;
            _pelicula = pelicula;
            _sala = sala;
        }

        private void FormAsiento_Load_1(object sender, EventArgs e)
        {
            GenerarAsientos();
        }

        private void GenerarAsientos()
        {
            int filas = 7;
            int columnas = 9;

            panelAsientos.Controls.Clear();

            if (_sala.Asientos.Count == 0)
            {
                for (int f = 0; f < filas; f++)
                {
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

        private void BtnAsiento_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Asiento asiento = (Asiento)btn.Tag;

            if (asiento.Ocupado) return;

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

        private void ptrExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
