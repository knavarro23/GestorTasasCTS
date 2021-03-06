﻿using System;
using System.Data;
using System.Windows.Forms;
using MDIBFGestionTasasDP.modelos;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmProductoCTS : MetroForm
    {
        private int _intAccion = 2;
        private int _intProductoCtsId;
        private int _intActivo;
        private bool _resultado;

        private readonly string _conexion =
            System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;

        public clsfrmBases objclsfrmBases = new clsfrmBases();

        private readonly NegocioProyMDIBFGestionTasasDP.tipoproductoCTS _mTipoproductoCts =
            new NegocioProyMDIBFGestionTasasDP.tipoproductoCTS();

        private readonly NegocioProyMDIBFGestionTasasDP.productoCTS _mProductoCts =
            new NegocioProyMDIBFGestionTasasDP.productoCTS();

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

            string strTipoProducto = ddltipoproducto.SelectedValue.ToString();
            string strCodigo = txtcodigo.Text.Trim();
            string strNombres = txtnombre.Text.Trim();

            dt = _mProductoCts.BuscarProductoCTS(_conexion, strTipoProducto, strCodigo, strNombres);

            if (dt.Rows.Count > 0)
            {
                gvProducto.DataSource = dt;
                gvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            else
            {
                MessageBox.Show(this, "No se encontraron datos en la búsqueda.", "Error de búsqueda",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                gvProducto.DataSource = null;
            }
        }

        private void frmProductoCTS_Load(object sender, EventArgs e)
        {
            ddltipoproducto.DataSource = _mTipoproductoCts.ListarTipoProductoCTS(_conexion);
            ddltipoproducto.ValueMember = "codigo";
            ddltipoproducto.DisplayMember = "nombre";

            ddltipoproducto2.DataSource = _mTipoproductoCts.ListarTipoProductoCTS(_conexion);
            ddltipoproducto2.ValueMember = "codigo";
            ddltipoproducto2.DisplayMember = "nombre";

            ddlmoneda.DataSource = _mTipoproductoCts.ListarMonedaCTS(_conexion);
            ddlmoneda.ValueMember = "codigo";
            ddlmoneda.DisplayMember = "nombre";

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvProducto_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (gvProducto.Rows[e.RowIndex].Cells[0].Value != null)
            {
                gvProducto.Enabled = true;
                lblmensajeCTS2.Text = "Editar Producto CTS";
                _intAccion = 2;

                DataTable dt = new DataTable();
                dt = _mProductoCts.SeleccionarUnoPoductoCTS(_conexion, (int) gvProducto.Rows[e.RowIndex].Cells[0].Value);
                txtcodigo2.Text = dt.Rows[0]["Codigo"].ToString();
                txtnombre2.Text = dt.Rows[0]["Nombre"].ToString();
                txttasa.Text = dt.Rows[0]["Tasa"].ToString();
                txtclase.Text = dt.Rows[0]["Clase"].ToString();
                txtdescripcion.Text = dt.Rows[0]["Descripcion"].ToString();
                ddlmoneda.SelectedValue = dt.Rows[0]["Moneda"].ToString();
                ddltipoproducto2.SelectedValue = dt.Rows[0]["Tipo"].ToString();
                _intActivo = (int) dt.Rows[0]["Activo"];

                _intProductoCtsId = (int) dt.Rows[0]["Id"];

                if (_intActivo == 1) chkactivo.Checked = true;
                else chkactivo.Checked = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblmensajeCTS2.Text = "Insertar Producto CTS";
            gvProducto.DataSource = null;
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtcodigo2.Text = "";
            txtnombre2.Text = "";
            txtdescripcion.Text = "";
            txttasa.Text = "";
            txtclase.Text = "";

            chkactivo.Checked = false;

            _intAccion = 1;
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtcodigo2.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un valor para el campo código", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtnombre2.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese un valor para el campo nombre", Application.ProductName,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                #region "Registro: NUEVO"

                if (_intAccion == 1) // Si es nuevo
                {
                    DialogResult result = MessageBox.Show("Seguro que desea registrar el producto CTS?", "ProductoCTS",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (!result.Equals(DialogResult.OK))
                    {
                        return;
                    }

                    if (chkactivo.Checked == false)
                    {
                        _intActivo = 0;
                    }
                    else
                    {
                        _intActivo = 1;
                    }

                    EntidadProyMDIBFGestionTasas.productoCTS _productoCTS =
                        new EntidadProyMDIBFGestionTasas.productoCTS();
                    _productoCTS.codigo = txtcodigo2.Text.Trim();
                    _productoCTS.nombre = txtnombre2.Text.Trim();
                    _productoCTS.tasa = txttasa.Text.Trim();
                    _productoCTS.moneda = ddlmoneda.SelectedValue.ToString();
                    _productoCTS.descripcion = txtdescripcion.Text.Trim();
                    _productoCTS.tipo = ddltipoproducto2.SelectedValue.ToString();
                    _productoCTS.tasasinpor = txttasa.Text.Trim();
                    _productoCTS.clase = txtclase.Text;
                    _productoCTS.activo = (int) _intActivo;

                    _resultado = _mProductoCts.InsertarProductoCTS(_conexion, _productoCTS);

                    if (_resultado == true)
                    {
                        MessageBox.Show("Producto CTS insertado con éxito", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo2.Text = "";
                        txtnombre2.Text = "";
                        txttasa.Text = "";
                        txtdescripcion.Text = "";
                        txtclase.Text = "";
                        chkactivo.Checked = false;
                    }
                }

                #endregion

                if (_intAccion == 2) // Si es editar
                {
                    DialogResult result = MessageBox.Show("Seguro que desea editar el registro seleccionado?",
                        "ProductoCTS", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (!result.Equals(DialogResult.OK))
                    {
                        return;
                    }

                    if (chkactivo.Checked == false)
                    {
                        _intActivo = 0;
                    }
                    else
                    {
                        _intActivo = 1;
                    }

                    EntidadProyMDIBFGestionTasas.productoCTS _productoCTS =
                        new EntidadProyMDIBFGestionTasas.productoCTS();

                    _productoCTS.productoCTSId = _intProductoCtsId;
                    _productoCTS.codigo = txtcodigo2.Text.Trim();
                    _productoCTS.nombre = txtnombre2.Text.Trim();
                    _productoCTS.tasa = txttasa.Text.Trim();
                    _productoCTS.moneda = ddlmoneda.SelectedValue.ToString();
                    _productoCTS.descripcion = txtdescripcion.Text.Trim();
                    _productoCTS.tipo = ddltipoproducto2.SelectedValue.ToString();
                    _productoCTS.tasasinpor = txttasa.Text.Trim();
                    _productoCTS.clase = txtclase.Text;
                    _productoCTS.activo = (int) _intActivo;

                    _resultado = _mProductoCts.ActualizarProductoCTS(_conexion, _productoCTS);

                    if (_resultado == true)
                    {
                        MessageBox.Show("Producto CTS actualizado con éxito", Application.ProductName,
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcodigo2.Text = "";
                        txtnombre2.Text = "";
                        txttasa.Text = "";
                        txtdescripcion.Text = "";
                        txtclase.Text = "";
                        chkactivo.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió el siguiente error: " + ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtcodigo2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char) Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}