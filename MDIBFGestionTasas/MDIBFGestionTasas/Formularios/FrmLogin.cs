using System;
using System.Data;
using System.Windows.Forms;
using MDIBFGestionTasas.Core;
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
                EntidadProyMDIBFGestionTasasDP.usuario _usuario = new EntidadProyMDIBFGestionTasasDP.usuario
                {
                    username = mtxtUsuario.Text.Trim(),
                    password = mtxtClave.Text.Trim()
                };

                DataTable dt = new DataTable();
                dt = m_usuario.BuscarUsuario(conexion, _usuario);

                string strTotal;
                strTotal = dt.Rows.Count.ToString();

                if (Int32.Parse(strTotal) > 0)
                {
                    Hide();
                    Constantes.NombreUsuario = _usuario.username;
                    FrmInicio frmInicio = new FrmInicio();
                    frmInicio.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Las credenciales ingresadas no se encuentran registradas.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtClave.Text = "";
                    mtxtClave.Focus();
                    return;
                }
                Constantes.NombreUsuario = _usuario.username;
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
