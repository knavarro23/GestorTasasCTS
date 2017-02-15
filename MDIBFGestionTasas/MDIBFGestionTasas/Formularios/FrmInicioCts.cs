using System;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmInicioCts : MetroForm
    {
        public FrmInicioCts()
        {
            InitializeComponent();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCts1_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipalCts1 frmPrincipal = new FrmPrincipalCts1();
            frmPrincipal.Show();
        }

        private void btnCts2_Click(object sender, EventArgs e)
        {
            Hide();
            FrmPrincipalCts2 frmPrincipal = new FrmPrincipalCts2();
            frmPrincipal.Show();
        }
    }
}