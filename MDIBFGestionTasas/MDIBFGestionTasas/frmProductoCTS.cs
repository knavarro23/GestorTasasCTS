using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIBFGestionTasasDP.modelos;

namespace MDIBFGestionTasas
{
    public partial class frmProductoCTS : Form
    {
        string strusuario;
        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases objclsfrmBases = new clsfrmBases();

        NegocioProyMDIBFGestionTasasDP.tipoproductoCTS m_tipoproductoCTS = new NegocioProyMDIBFGestionTasasDP.tipoproductoCTS();
        NegocioProyMDIBFGestionTasasDP.productoCTS m_productoCTS = new NegocioProyMDIBFGestionTasasDP.productoCTS();
        public frmProductoCTS(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            DataTable dt = new DataTable();

            string strTipoProducto = ddltipoproducto.SelectedItem.ToString();
            string strNombres = txtnombre.Text.Trim();
            string strCodigo = txtcodigo.Text.Trim();

            dt = m_productoCTS.BuscarProductoCTS(conexion, strTipoProducto, strNombres, strCodigo);

            if (dt.Rows.Count > 0)
            {
                gvProducto.DataSource = dt;
                gvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                MessageBox.Show(this, "No se encontraron datos en la búsqueda.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvProducto.DataSource = null;
            }
        }

        private void frmProductoCTS_Load(object sender, EventArgs e)
        {
            ddltipoproducto.DataSource = m_tipoproductoCTS.ListarTipoProductoCTS(conexion);
            ddltipoproducto.ValueMember = "codigo";
            ddltipoproducto.DisplayMember = "nombre";
        }

     
    }
}
