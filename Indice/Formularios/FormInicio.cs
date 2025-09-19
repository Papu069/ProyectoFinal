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
            Application.Exit();
        }

        private void CambiarTab(TabPage tab)
        {
            tabGeneral.TabPages.Clear();
            tabGeneral.TabPages.Add(tab);
            tabGeneral.SelectedTab = tab;
        }

        private void btnVerPeliculas_Click(object sender, EventArgs e)
        {
            CambiarTab(tabInicio);
        }

        private void btnComprarEntrada_Click(object sender, EventArgs e)
        {
            CambiarTab(tabDatosPersonales);
        }
    }
}
