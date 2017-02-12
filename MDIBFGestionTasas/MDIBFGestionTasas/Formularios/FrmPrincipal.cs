using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmPrincipal : MetroForm
    {
        #region Propiedades y Variables

        //private frmCargaTrama _frmCargaProcesos;
        //private frmReporteEmail _frmReporteEmail;
        //private frmReporteSMS _frmReporteSms;
        //private FrmCargaCmrPuntos _frmCargaCmrPuntos;
        //private FrmContraseña _frmContraseña;
        //private FrmListarUsuario _frmListarUsuario;
        //private FrmListarEmailExcluido _frmEmailExcluidos;
        //private FrmListarCelularExcluido _frmCelularExcluido;

        public string Usuario;

        #endregion

        #region Constructor

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Eventos

        private void menuItemCargaProceso_Click(object sender, EventArgs e)
        {
            //if (_frmCargaProcesos == null || _frmCargaProcesos.IsDisposed)
            //{
            //    _frmCargaProcesos = new frmCargaTrama(Usuario) { MdiParent = this };
            //    _frmCargaProcesos.Show();
            //}
            //else
            //{
            //    _frmCargaProcesos.BringToFront();
            //}
        }

        private void menuItemCargaPuntos_Click(object sender, EventArgs e)
        {
            //if (_frmCargaCmrPuntos == null || _frmCargaCmrPuntos.IsDisposed)
            //{
            //    _frmCargaCmrPuntos = new FrmCargaCmrPuntos(Usuario) { MdiParent = this };
            //    _frmCargaCmrPuntos.Show();
            //}
            //else
            //{
            //    _frmCargaCmrPuntos.BringToFront();
            //}
        }

        private void menuItemSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemReporteEmail_Click(object sender, EventArgs e)
        {
            //if (_frmReporteEmail == null || _frmReporteEmail.IsDisposed)
            //{
            //    _frmReporteEmail = new frmReporteEmail(Usuario) { MdiParent = this };
            //    _frmReporteEmail.Show();
            //}
            //else
            //{
            //    _frmReporteEmail.BringToFront();
            //}
        }

        private void menuItemReporteSms_Click(object sender, EventArgs e)
        {
            //if (_frmReporteSms == null || _frmReporteSms.IsDisposed)
            //{
            //    _frmReporteSms = new frmReporteSMS(Usuario) { MdiParent = this };
            //    _frmReporteSms.Show();
            //}
            //else
            //{
            //    _frmReporteSms.BringToFront();
            //}
        }

        private void menuItemCambiarClave_Click(object sender, EventArgs e)
        {
            //if (_frmContraseña == null || _frmContraseña.IsDisposed)
            //{
            //    _frmContraseña = new FrmContraseña {MdiParent = this};
            //    _frmContraseña.Show();
            //}
            //else
            //{
            //    _frmContraseña.BringToFront();
            //}
        }

        private void menuItemNuevoUsuario_Click(object sender, EventArgs e)
        {
            //if (_frmListarUsuario == null || _frmListarUsuario.IsDisposed)
            //{
            //    _frmListarUsuario = new FrmListarUsuario { MdiParent = this };
            //    _frmListarUsuario.Show();
            //}
            //else
            //{
            //    _frmListarUsuario.BringToFront();
            //}
        }

        private void menuItemCorreoExcluido_Click(object sender, EventArgs e)
        {
            //if (_frmEmailExcluidos == null || _frmEmailExcluidos.IsDisposed)
            //{
            //    _frmEmailExcluidos = new FrmListarEmailExcluido { MdiParent = this };
            //    _frmEmailExcluidos.Show();
            //}
            //else
            //{
            //    _frmEmailExcluidos.BringToFront();
            //}
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void celularesExcluidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (_frmCelularExcluido == null || _frmCelularExcluido.IsDisposed)
            //{
            //    _frmCelularExcluido = new FrmListarCelularExcluido { MdiParent = this };
            //    _frmCelularExcluido.Show();
            //}
            //else
            //{
            //    _frmCelularExcluido.BringToFront();
            //}
        }

        #endregion
    }
}