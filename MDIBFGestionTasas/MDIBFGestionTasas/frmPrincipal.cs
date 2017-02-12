using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIBFGestionTasas;

namespace MDIBFGestionTasasDP
{
    public partial class frmPrincipal : Form
    {
        frmCargaStockBF varfrmCargaStockBF;
        frmProcesoCargaDP varfrmProcesoCargaDP;
        frmProcesoCargaCTS varfrmProcesoCargaCTS;
        frmProductoCTS varfrmProductoCTS;
        frmIngresoNetoCTS varfrmIngresoNetoCTS;
        frmSaldoenCuentaCTS varfrmSaldoenCuentaCTS;


        public string _usuario;
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
            if (varfrmCargaStockBF == null || varfrmCargaStockBF.IsDisposed)
            {
                varfrmCargaStockBF = new frmCargaStockBF(_usuario);
                varfrmCargaStockBF.MdiParent = this;
                varfrmCargaStockBF.Show();
            }
            else
            {
                varfrmCargaStockBF.BringToFront();
            }
        }

        private void procesoDeCargaDPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varfrmProcesoCargaDP == null || varfrmProcesoCargaDP.IsDisposed)
            {
                varfrmProcesoCargaDP = new frmProcesoCargaDP(_usuario);
                varfrmProcesoCargaDP.MdiParent = this;
                varfrmProcesoCargaDP.Show();
            }
            else
            {
                varfrmProcesoCargaDP.BringToFront();
            }
        }

        private void procesoDeCargaCTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varfrmProcesoCargaCTS == null || varfrmProcesoCargaCTS.IsDisposed)
            {
                varfrmProcesoCargaCTS = new frmProcesoCargaCTS(_usuario);
                varfrmProcesoCargaCTS.MdiParent = this;
                varfrmProcesoCargaCTS.Show();
            }
            else
            {
                varfrmProcesoCargaCTS.BringToFront();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varfrmProductoCTS == null || varfrmProductoCTS.IsDisposed)
            {
                varfrmProductoCTS = new frmProductoCTS(_usuario);
                varfrmProductoCTS.MdiParent = this;
                varfrmProductoCTS.Show();
            }
            else
            {
                varfrmProductoCTS.BringToFront();
            }
        }

        private void mantenimientoIngresoNetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varfrmIngresoNetoCTS == null || varfrmIngresoNetoCTS.IsDisposed)
            {
                varfrmIngresoNetoCTS = new frmIngresoNetoCTS(_usuario);
                varfrmIngresoNetoCTS.MdiParent = this;
                varfrmIngresoNetoCTS.Show();
            }
            else
            {
                varfrmIngresoNetoCTS.BringToFront();
            }
        }

        private void mantenimientoSaldoNetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (varfrmSaldoenCuentaCTS == null || varfrmSaldoenCuentaCTS.IsDisposed)
            {
                varfrmSaldoenCuentaCTS = new frmSaldoenCuentaCTS(_usuario);
                varfrmSaldoenCuentaCTS.MdiParent = this;
                varfrmSaldoenCuentaCTS.Show();
            }
            else
            {
                varfrmSaldoenCuentaCTS.BringToFront();
            }
        }    
    }
}
