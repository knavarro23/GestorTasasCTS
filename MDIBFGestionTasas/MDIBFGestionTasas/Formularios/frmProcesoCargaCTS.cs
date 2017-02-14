using System;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmProcesoCargaCTS : MetroForm
    {
        public FrmProcesoCargaCTS()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbCuentaSueldo_Click(object sender, EventArgs e)
        {
            toolTipGeneral.SetToolTip(ptbCuentaSueldo, "Esto es una prueba\nEsto es una prueba\nEsto es una prueba");
            toolTipGeneral.Active = true;
        }

        private void ptbAbonoQuinta_Click(object sender, EventArgs e)
        {
            toolTipGeneral.SetToolTip(ptbAbonoQuinta, "Esto es una prueba2\nEsto es una prueba2\nEsto es una prueba2");
            toolTipGeneral.Active = true;
        }

        private void ptbAbonoDias_Click(object sender, EventArgs e)
        {
            toolTipGeneral.SetToolTip(ptbAbonoDias, "Esto es una prueba3\nEsto es una prueba3\nEsto es una prueba3");
            toolTipGeneral.Active = true;
        }

        private void ptbMigracion_Click(object sender, EventArgs e)
        {
            toolTipGeneral.SetToolTip(ptbMigracion, "Esto es una prueba4\nEsto es una prueba4\nEsto es una prueba4");
            toolTipGeneral.Active = true;
        }

        private void ptbDatosContacto_Click(object sender, EventArgs e)
        {
            toolTipGeneral.SetToolTip(ptbDatosContacto, "Esto es una prueba5\nEsto es una prueba5\nEsto es una prueba5");
            toolTipGeneral.Active = true;
        }
    }
}