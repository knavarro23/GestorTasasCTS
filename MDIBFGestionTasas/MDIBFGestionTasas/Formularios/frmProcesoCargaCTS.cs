using System;
using System.Drawing;
using System.IO;
using MDIBFGestionTasas.Core;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmProcesoCargaCTS : MetroForm
    {
        CustomizedToolTip _toolTipGeneral;

        public FrmProcesoCargaCTS()
        {
            InitializeComponent();

            InitializeToolTip();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ptbCuentaSueldo_Click(object sender, EventArgs e)
        {
            _toolTipGeneral.SetToolTip(ptbCuentaSueldo, "tooltip");
            _toolTipGeneral.Active = true;
        }

        private void ptbAbonoQuinta_Click(object sender, EventArgs e)
        {
            _toolTipGeneral.SetToolTip(ptbAbonoQuinta, "tooltip");
            _toolTipGeneral.Active = true;
        }

        private void ptbAbonoDias_Click(object sender, EventArgs e)
        {
            _toolTipGeneral.SetToolTip(ptbAbonoDias, "tooltip");
            _toolTipGeneral.Active = true;
        }

        private void ptbMigracion_Click(object sender, EventArgs e)
        {
            _toolTipGeneral.SetToolTip(ptbMigracion, "tooltip");
            _toolTipGeneral.Active = true;
        }

        private void ptbDatosContacto_Click(object sender, EventArgs e)
        {
            _toolTipGeneral.SetToolTip(ptbDatosContacto, "tooltip");
            _toolTipGeneral.Active = true;
        }

        private void InitializeToolTip()
        {
            _toolTipGeneral = new CustomizedToolTip {AutoSize = false};

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\bancoFalabella.png");

            _toolTipGeneral.SetToolTip(ptbCuentaSueldo, "tooltip");
            ptbCuentaSueldo.Tag = Image.FromFile(path);

            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Resources\bancoFalabella.png");
            _toolTipGeneral.SetToolTip(ptbAbonoQuinta, "tooltip");
            ptbAbonoQuinta.Tag = Image.FromFile(path);
        }
    }
}