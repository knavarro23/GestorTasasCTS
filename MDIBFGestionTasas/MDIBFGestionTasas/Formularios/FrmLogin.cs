using System;
using System.Configuration;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmLogin : MetroForm
    {
        #region Constructor

        public FrmLogin()
        {
            InitializeComponent();
            mtxtUsuario.Focus();
        }

        #endregion

        #region Propiedades y Variables

        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        NegocioProyMDIBFGestionTasasDP.usuario m_usuario = new NegocioProyMDIBFGestionTasasDP.usuario();

        #endregion

        #region Eventos

        private void mbtnEntrar_Click(object sender, EventArgs e)
        {
            if (mtxtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("El campo usuario se encuentra vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mtxtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("El campo contraseña se encuentra vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //EntidadProyMDIBFGestionTasasDP.usuario _usuario = new EntidadProyMDIBFGestionTasasDP.usuario();
                //_usuario.username = mtxtUsuario.Text.Trim();
                //_usuario.password = mtxtClave.Text.Trim();

                //DataTable dt = new DataTable();
                //dt = m_usuario.BuscarUsuario(conexion, _usuario);

                //string strTotal;
                //strTotal = dt.Rows.Count.ToString();

                //if (Int32.Parse(strTotal) > 0)
                //{
                //    this.Hide();
                //    FrmPrincipal varFrmPrincipal = new FrmPrincipal();
                //    //varFrmPrincipal._usuario = _usuario.username;

                //    varFrmPrincipal.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Las credenciales ingresadas no se encuentran registradas.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    mtxtClave.Text = "";
                //    mtxtClave.Focus();
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la conexión con la BD: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void mbtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mtxtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                mbtnEntrar.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void mtxtClave_Enter(object sender, EventArgs e)
        {
            IsKeyLocked(Keys.CapsLock);
        }

        #endregion
    }
}