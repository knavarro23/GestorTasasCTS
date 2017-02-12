using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIBFGestionTasasDP
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        NegocioProyMDIBFGestionTasasDP.usuario m_usuario = new NegocioProyMDIBFGestionTasasDP.usuario();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Trim() == "")
            {
                MessageBox.Show("El campo usuario se encuentra vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtcontrasenia.Text.Trim() == "")
            {
                MessageBox.Show("El campo contraseña se encuentra vacío.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                EntidadProyMDIBFGestionTasasDP.usuario _usuario = new EntidadProyMDIBFGestionTasasDP.usuario();
                _usuario.username = txtusuario.Text.Trim();
                _usuario.password = txtcontrasenia.Text.Trim();

                DataTable dt = new DataTable();
                dt = m_usuario.BuscarUsuario(conexion, _usuario);

                string strTotal;
                strTotal = dt.Rows.Count.ToString();

                if (Int32.Parse(strTotal) > 0)
                {
                    this.Hide();
                    frmPrincipal varfrmPrincipal = new frmPrincipal();
                    varfrmPrincipal._usuario = _usuario.username;

                    varfrmPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Las credenciales ingresadas no se encuentran registradas.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtcontrasenia.Text = "";
                    txtcontrasenia.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en la conexión con la BD: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
