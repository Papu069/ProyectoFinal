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
        public FormInicio()
        {
            InitializeComponent();
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tabInicio);
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

        private void Img_Click(object sender, EventArgs e)
        {
            Pelicula pelicula1 = new Pelicula()
            {
                NombreDEPelicula = "QUANTUMANIA",
                Genero = "Ciencia ficción",
                Descripcion = "Quantumania es una película de superhéroes que inicia la Fase 5 del Universo Cinematográfico de Marvel, en la " +
                "que Scott Lang, su hija Cassie, y el resto de la familia de Hank Pym y Janet van Dyne son accidentalmente transportados al " +
                "Reino Cuántico. Una vez allí, deben enfrentarse a Kang el Conquistador, el villano principal de la saga del multiverso y un " +
                "enemigo mucho más poderoso que cualquiera que los Vengadores hayan enfrentado antes.",
                FechaEstreno = new DateTime(2025, 09, 22)
            };
            FormPelicula formPelicula = new FormPelicula(pelicula1);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie2_Click(object sender, EventArgs e)
        {
            Pelicula pelicula1 = new Pelicula()
            {
                NombreDEPelicula = "65, AL BORDE DE LA EXTINCIÓN",
                Genero = "Ficción histórica",
                Descripcion = "El piloto Mills (Adam Driver) y la joven Koa (Ariana Greenblatt) sobreviven a un " +
                "accidente espacial en la Tierra de hace 65 millones de años, una era repleta de dinosaurios y " +
                "peligros prehistóricos. Su objetivo es alcanzar el único módulo de escape intacto, mientras " +
                "luchan por sobrevivir contra las bestias de aquel mundo y encuentran una forma de regresar a su tiempo.",
                FechaEstreno = new DateTime(2025, 09, 23)
            };
            FormPelicula formPelicula = new FormPelicula(pelicula1);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
        }

        private void ImgMovie3_Click(object sender, EventArgs e)
        {
            Pelicula pelicula1 = new Pelicula()
            {
                NombreDEPelicula = "LOS MUÉRTIMER",
                Genero = "Misterio y comedia",
                Descripcion = "narra la aventura de Nico, un adolescente acosado por ser hijo de los dueños de " +
                "una funeraria, y Gabi, una joven estudiante de intercambio francesa. Juntos, descubren una " +
                "trama de robos de joyas en un cementerio, se unen a sus propios acosadores para investigar y " +
                "deben desentrañar el misterio antes de que sea demasiado tarde",
                FechaEstreno = new DateTime(2025, 09, 24)
            };
            FormPelicula formPelicula = new FormPelicula(pelicula1);
            this.Hide();
            formPelicula.ShowDialog();
            this.Show();
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
    }
}
