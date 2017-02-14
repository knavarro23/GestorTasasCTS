using System;
using MetroFramework.Components;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmProcesoCargaCTS : MetroForm
    {
        public FrmProcesoCargaCTS()
        {
            InitializeComponent();
        }

        private void frmProcesoCargaCTS_Load(object sender, EventArgs e)
        {
            //toolTipCuentaSueldo.SetToolTip(ptbCuentaSueldo, "Esto es una prueba\nEsto es una prueba\nEsto es una prueba");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbCuentaSueldo_Click(object sender, EventArgs e)
        {
            var tool = new MetroToolTip();
            tool.SetToolTip(ptbCuentaSueldo, "Esto es una prueba\nEsto es una prueba\nEsto es una prueba");
        }
    }
}