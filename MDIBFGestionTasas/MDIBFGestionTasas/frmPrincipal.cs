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
        FrmProcesoCargaCTS _frmProcesoCargaCts;
        FrmProductoCTS _frmProductoCts;
        FrmIngresoNetoCTS _frmIngresoNetoCts;
        FrmSaldoenCuentaCTS _frmSaldoenCuentaCts;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();  
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

        private void procesoDeCargaCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProcesoCargaCts == null || _frmProcesoCargaCts.IsDisposed)
            {
                _frmProcesoCargaCts = new FrmProcesoCargaCTS { MdiParent = this };
                _frmProcesoCargaCts.Show();
            }
            else
            {
                _frmProcesoCargaCts.BringToFront();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmProductoCts == null || _frmProductoCts.IsDisposed)
            {
                _frmProductoCts = new FrmProductoCTS { MdiParent = this };
                _frmProductoCts.Show();
            }
            else
            {
                _frmProductoCts.BringToFront();
            }
        }

        private void mantenimientoIngresoNetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmIngresoNetoCts == null || _frmIngresoNetoCts.IsDisposed)
            {
                _frmIngresoNetoCts = new FrmIngresoNetoCTS { MdiParent = this };
                _frmIngresoNetoCts.Show();
            }
            else
            {
                _frmIngresoNetoCts.BringToFront();
            }
        }

        private void mantenimientoSaldoNetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_frmSaldoenCuentaCts == null || _frmSaldoenCuentaCts.IsDisposed)
            {
                _frmSaldoenCuentaCts = new FrmSaldoenCuentaCTS { MdiParent = this };
                _frmSaldoenCuentaCts.Show();
            }
            else
            {
                _frmSaldoenCuentaCts.BringToFront();
            }
        }    
    }
}