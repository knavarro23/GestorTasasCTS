using System;
using System.Data;
using System.Windows.Forms;
using MDIBFGestionTasasDP.modelos;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmProductoCTS : MetroForm
    {
        readonly string _conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases ObjclsfrmBases = new clsfrmBases();

        readonly NegocioProyMDIBFGestionTasasDP.tipoproductoCTS _mTipoproductoCts = new NegocioProyMDIBFGestionTasasDP.tipoproductoCTS();
        readonly NegocioProyMDIBFGestionTasasDP.productoCTS _mProductoCts = new NegocioProyMDIBFGestionTasasDP.productoCTS();

        public FrmProductoCTS()
        {
            InitializeComponent();
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

            dt = _mProductoCts.BuscarProductoCTS(_conexion, strTipoProducto, strNombres, strCodigo);

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
            ddltipoproducto.DataSource = _mTipoproductoCts.ListarTipoProductoCTS(_conexion);
            ddltipoproducto.ValueMember = "codigo";
            ddltipoproducto.DisplayMember = "nombre";
        }
    }
}