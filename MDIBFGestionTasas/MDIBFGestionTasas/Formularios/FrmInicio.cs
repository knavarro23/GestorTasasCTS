using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmInicio : MetroForm
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnTarifario2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmInicioCts frmInicioCts = new FrmInicioCts();
            frmInicioCts.Show();
        }

        private void btnTarifario1_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}