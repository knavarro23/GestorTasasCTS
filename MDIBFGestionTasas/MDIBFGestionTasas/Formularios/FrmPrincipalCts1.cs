using System;
using System.Windows.Forms;
using MDIBFGestionTasas.Core;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmPrincipalCts1 : MetroForm
    {
        private FrmProductoCTS _frmProductoCts;
        private FrmCargaStockBF _frmCargaStockBf;
        private FrmProcesoCargaCTS _frmProcesoCargaCts;

        public FrmPrincipalCts1()
        {
            InitializeComponent();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProductoCts == null || _frmProductoCts.IsDisposed)
            {
                _frmProductoCts = new FrmProductoCTS {MdiParent = this};
                _frmProductoCts.Show();
            }
            else
            {
                _frmProductoCts.BringToFront();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            toolUsuario.Text = @"Usuario: " + Constantes.NombreUsuario;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void procesoDeCargaStockBFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmCargaStockBf == null || _frmCargaStockBf.IsDisposed)
            {
                _frmCargaStockBf = new FrmCargaStockBF {MdiParent = this};
                _frmCargaStockBf.Show();
            }
            else
            {
                _frmCargaStockBf.BringToFront();
            }
        }

        private void procesoDeCargaCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProcesoCargaCts == null || _frmProcesoCargaCts.IsDisposed)
            {
                _frmProcesoCargaCts = new FrmProcesoCargaCTS {MdiParent = this};
                _frmProcesoCargaCts.Show();
            }
            else
            {
                _frmProcesoCargaCts.BringToFront();
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}