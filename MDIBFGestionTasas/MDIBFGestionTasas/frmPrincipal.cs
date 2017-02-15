using System;
using System.Windows.Forms;
using MDIBFGestionTasas.Formularios;
using MetroFramework.Forms;

namespace MDIBFGestionTasas
{
    public partial class frmPrincipal : MetroForm
    {
        FrmCargaStockBF _frmCargaStockBf;
        FrmProcesoCargaDP _frmProcesoCargaDp;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void procesoDeCargaStockBFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmCargaStockBf == null || _frmCargaStockBf.IsDisposed)
            {
                _frmCargaStockBf = new FrmCargaStockBF { MdiParent = this };
                _frmCargaStockBf.Show();
            }
            else
            {
                _frmCargaStockBf.BringToFront();
            }
        }

        private void procesoDeCargaDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProcesoCargaDp == null || _frmProcesoCargaDp.IsDisposed)
            {
                _frmProcesoCargaDp = new FrmProcesoCargaDP { MdiParent = this };
                _frmProcesoCargaDp.Show();
            }
            else
            {
                _frmProcesoCargaDp.BringToFront();
            }
        }

        private void toolMenuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}