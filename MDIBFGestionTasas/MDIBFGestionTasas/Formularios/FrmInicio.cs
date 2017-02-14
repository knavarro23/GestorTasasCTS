using System;
using MDIBFGestionTasas.Core;
using MDIBFGestionTasasDP;
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
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void btnTarifario1_Click(object sender, EventArgs e)
        {
            Hide();
            frmPrincipal frmPrincipal = new frmPrincipal {_usuario = Constantes.NombreUsuario};
            frmPrincipal.Show();
        }

        private void FrmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}