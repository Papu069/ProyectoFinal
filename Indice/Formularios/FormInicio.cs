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
    public partial class FormInicio: Form
    {
        private Pelicula pelicula1;
        private Pelicula pelicula2;
        private Pelicula pelicula3;
        public FormInicio()
        {
            InitializeComponent();
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tabInicio);

            pelicula1 = new Pelicula
            {
                NombreDEPelicula = "QUANTUMANIA",
                Genero = "Ciencia ficción",
                Descripcion = "Quantumania es una película de superhéroes...",
                FechaEstreno = new DateTime(2025, 09, 22)
            };
            pelicula1.Salas.Add(new Sala { NumDESala = 1, Capacidad = 30 });

            pelicula2 = new Pelicula
            {
                NombreDEPelicula = "65, AL BORDE DE LA EXTINCIÓN",
                Genero = "Ficción histórica",
                Descripcion = "El piloto Mills y la joven Koa sobreviven...",
                FechaEstreno = new DateTime(2025, 09, 23)
            };
            pelicula2.Salas.Add(new Sala { NumDESala = 2, Capacidad = 30 });

            pelicula3 = new Pelicula
            {
                NombreDEPelicula = "LOS MUÉRTIMER",
                Genero = "Misterio y comedia",
                Descripcion = "Nico y Gabi descubren una trama de robos...",
                FechaEstreno = new DateTime(2025, 09, 24)
            };
            pelicula3.Salas.Add(new Sala { NumDESala = 3, Capacidad = 30 });
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.ShowDialog();
            this.Show();
        }

        private void CambiarTab(TabPage tab)
        {
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tab);
            tabGeneral.SelectedTab = tab;
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio2);
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio);
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio2);
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio3);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio);
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabLunes);
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabMartes);
        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            CambiarTab(tabMiercoles);
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            CambiarTab(tabJueves);
        }

        private void btnViernes_Click(object sender, EventArgs e)
        {
            CambiarTab(tabViernes);
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            CambiarTab(tabSabado);
        }

        private void btnDomingo_Click(object sender, EventArgs e)
        {
            CambiarTab(tabDomingo);
        }

        private void Img_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(pelicula1, pelicula1.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie2_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(pelicula2, pelicula2.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie3_Click(object sender, EventArgs e)
        {
            FormPelicula formPelicula = new FormPelicula(pelicula3, pelicula3.Salas[0]);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

    }
}
