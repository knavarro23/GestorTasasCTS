using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using CsvHelper;
using MDIBFGestionTasasDP.modelos;
using MetroFramework.Forms;

namespace MDIBFGestionTasas.Formularios
{
    public partial class FrmCargaStockBF : MetroForm
    {
        int _intRetorno = 0;

        public FrmCargaStockBF()
        {
            InitializeComponent();
        }

        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases objclsfrmBases = new clsfrmBases();

        NegocioProyMDIBFGestionTasasDP.proceso m_proceso = new NegocioProyMDIBFGestionTasasDP.proceso();
        NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP m_procesogestionDP = new NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP();

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtproceso.Text = "";
            txttipocambio.Text = "";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtproceso.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese al menos un archivo para realizar el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seguro que desea procesar el archivo seleccionado?", "Carga Total", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK))
            {
                return;
            }

            objclsfrmBases.BotonAgregarDP = btnAgregar.Enabled;

            string filenameDP = System.IO.Path.GetFileName(txtproceso.Text.Trim());
            objclsfrmBases.pathNombreArchivosDP = txtproceso.Text.Trim();
            objclsfrmBases.NombreArchivosDP = filenameDP;

            objclsfrmBases.MensajeProceso = (string)lblmensajeproceso.Text.Trim();
            objclsfrmBases.BotonLimpiar = btnLimpiar.Enabled;
            objclsfrmBases.TextoTipoCambio = txttipocambio.Enabled;
            objclsfrmBases.BotonCerrarVentana = true;

            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
            objclsfrmBases.BotonMenuMantenimientos = ms.Items[0].Enabled;
            objclsfrmBases.BotonMenuProcesos = ms.Items[1].Enabled;

            //11-02-17 - Tipo de cambio
            if (txttipocambio.Text.Trim() == "")
            {
                objclsfrmBases.TipoCambio = 0;
            }
            else 
            {
                objclsfrmBases.TipoCambio = Convert.ToDecimal(txttipocambio.Text);
            }
              
            bw1.RunWorkerAsync();

            cargaDatos();
        }

        private void btnAgregarDP_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtproceso.Text = ofd1.FileName.Trim();
        }

        private void ProcesoCarga()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga de datos...";
            int porcentaje = 0;
            int intTotal = 2400000;
            decimal j = 0;

            try
            {
                //Eliminar los registros solicitados
                bool resultado = m_procesogestionDP.EliminarProcesoGestionTasas(conexion);

                #region Crear dataTable

                DataTable dtDP = new DataTable();

                dtDP.Columns.Add("codcategoria", typeof(string));
                dtDP.Columns.Add("categoria", typeof(string));
                dtDP.Columns.Add("codsubcategoria", typeof(string));
                dtDP.Columns.Add("subcategoria", typeof(string));
                dtDP.Columns.Add("cuenta", typeof(string));
                dtDP.Columns.Add("tipodocumento", typeof(string));
                dtDP.Columns.Add("numerodocumento", typeof(string));
                dtDP.Columns.Add("nombre", typeof(string));
                dtDP.Columns.Add("ejecutivo", typeof(string));
                dtDP.Columns.Add("estado", typeof(string));
                dtDP.Columns.Add("descestado", typeof(string));
                dtDP.Columns.Add("fecproceso", typeof(string));
                dtDP.Columns.Add("mesproceso", typeof(string));
                dtDP.Columns.Add("fecapertura", typeof(string));
                dtDP.Columns.Add("mesapertura", typeof(string));
                dtDP.Columns.Add("fecrenovacion", typeof(string));
                dtDP.Columns.Add("mesrenovacion", typeof(string));
                dtDP.Columns.Add("fecvencimiento", typeof(string));
                dtDP.Columns.Add("mesvencimiento", typeof(string));
                dtDP.Columns.Add("msaldo", typeof(string));
                dtDP.Columns.Add("tasa", typeof(string));
                dtDP.Columns.Add("numeradortasa", typeof(double));
                dtDP.Columns.Add("tipomoneda", typeof(string));
                dtDP.Columns.Add("plazo", typeof(string));
                dtDP.Columns.Add("plazoactual", typeof(string));
                dtDP.Columns.Add("numeradorplzpact", typeof(string));
                dtDP.Columns.Add("numeradorplzact", typeof(string));
                dtDP.Columns.Add("saldodisponible", typeof(string));
                dtDP.Columns.Add("rucempleador", typeof(string));
                dtDP.Columns.Add("codtienda", typeof(string));
                dtDP.Columns.Add("desctienda", typeof(string));
                dtDP.Columns.Add("montoconvenio", typeof(string));
                dtDP.Columns.Add("diacargo", typeof(string));
                dtDP.Columns.Add("fecinicioconv", typeof(string));
                dtDP.Columns.Add("cuentacmr", typeof(string));
                dtDP.Columns.Add("tarjetacmr", typeof(string));
                dtDP.Columns.Add("codigoejecutivo", typeof(string));
                dtDP.Columns.Add("tipocambio", typeof(decimal));
                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosDP, System.Text.Encoding.Default, false))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP> records = reader.GetRecords<EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.TextoTipoCambio = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable

                        drDP["codcategoria"] = record.codcategoria.Trim();
                        drDP["categoria"] = record.categoria.Trim();
                        drDP["codsubcategoria"] = record.codsubcategoria.Trim();
                        drDP["subcategoria"] = record.subcategoria.Replace('ó', 'o').Replace('á', 'a').Replace('?', 'o');
                        drDP["cuenta"] = record.cuenta.Trim();
                        drDP["tipodocumento"] = record.tipodocumento.Trim();
                        if (record.numerodocumento.Length > 7) drDP["numerodocumento"] = record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 7) drDP["numerodocumento"] = "0" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 6) drDP["numerodocumento"] = "00" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 5) drDP["numerodocumento"] = "000" + record.numerodocumento.Trim();
                        drDP["nombre"] = record.nombre.Replace(',', ' ');
                        drDP["ejecutivo"] = record.ejecutivo.Trim();
                        drDP["estado"] = record.estado.Trim();
                        drDP["descestado"] = record.descestado.Trim();
                        drDP["fecproceso"] = record.fecproceso.Trim();
                        drDP["mesproceso"] = record.mesproceso.Trim();
                        drDP["fecapertura"] = record.fecapertura.Trim();
                        drDP["mesapertura"] = record.mesapertura.Trim();
                        drDP["fecrenovacion"] = record.fecrenovacion.Trim();
                        drDP["mesrenovacion"] = record.mesrenovacion.Trim();
                        drDP["fecvencimiento"] = record.fecvencimiento.Trim();
                        drDP["mesvencimiento"] = record.mesvencimiento.Trim();
                        drDP["msaldo"] = record.msaldo.Trim();
                        drDP["tasa"] = record.tasa.Trim();
                        drDP["numeradortasa"] = record.numeradortasa.Trim();
                        drDP["tipomoneda"] = record.tipomoneda.Trim();
                        drDP["plazo"] = record.plazo.Trim();
                        drDP["plazoactual"] = record.plazoactual.Trim();
                        drDP["numeradorplzpact"] = record.numeradorplzpact.Trim();
                        drDP["numeradorplzact"] = record.numeradorplzact.Trim();
                        drDP["saldodisponible"] = record.saldodisponible.Trim();
                        drDP["rucempleador"] = record.rucempleador.Trim();
                        drDP["codtienda"] = record.codtienda.Trim();
                        drDP["desctienda"] = record.desctienda.Trim();
                        drDP["montoconvenio"] = record.montoconvenio.Trim();
                        drDP["diacargo"] = record.diacargo.Trim();
                        drDP["fecinicioconv"] = record.fecinicioconv.Trim();
                        drDP["cuentacmr"] = record.cuentacmr.Trim();
                        drDP["tarjetacmr"] = record.tarjetacmr.Trim();
                        drDP["codigoejecutivo"] = record.codigoejecutivo.Trim();
                        drDP["tipocambio"] = objclsfrmBases.TipoCambio;
                        #endregion

                        dtDP.Rows.Add(drDP);

                        if (j == 1000000 || j == 1800000)
                        {
                            #region Inserciones temporales
                            using (var conexionBulkCopy = new SqlConnection(conexion))
                            {
                                conexionBulkCopy.Open();
                                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conexion))
                                {
                                    bulkCopy.BulkCopyTimeout = int.MaxValue;
                                    bulkCopy.DestinationTableName = "dbo.ProcesoGestionTasas";

                                    bulkCopy.ColumnMappings.Add("codcategoria", "codcategoria");
                                    bulkCopy.ColumnMappings.Add("categoria", "categoria");
                                    bulkCopy.ColumnMappings.Add("codsubcategoria", "codsubcategoria");
                                    bulkCopy.ColumnMappings.Add("subcategoria", "subcategoria");
                                    bulkCopy.ColumnMappings.Add("cuenta", "cuenta");
                                    bulkCopy.ColumnMappings.Add("tipodocumento", "tipodocumento");
                                    bulkCopy.ColumnMappings.Add("numerodocumento", "numerodocumento");
                                    bulkCopy.ColumnMappings.Add("nombre", "nombre");
                                    bulkCopy.ColumnMappings.Add("ejecutivo", "ejecutivo");
                                    bulkCopy.ColumnMappings.Add("estado", "estado");
                                    bulkCopy.ColumnMappings.Add("descestado", "descestado");
                                    bulkCopy.ColumnMappings.Add("fecproceso", "fecproceso");
                                    bulkCopy.ColumnMappings.Add("mesproceso", "mesproceso");
                                    bulkCopy.ColumnMappings.Add("fecapertura", "fecapertura");
                                    bulkCopy.ColumnMappings.Add("mesapertura", "mesapertura");
                                    bulkCopy.ColumnMappings.Add("fecrenovacion", "fecrenovacion");
                                    bulkCopy.ColumnMappings.Add("mesrenovacion", "mesrenovacion");
                                    bulkCopy.ColumnMappings.Add("fecvencimiento", "fecvencimiento");
                                    bulkCopy.ColumnMappings.Add("mesvencimiento", "mesvencimiento");
                                    bulkCopy.ColumnMappings.Add("msaldo", "msaldo");
                                    bulkCopy.ColumnMappings.Add("tasa", "tasa");
                                    bulkCopy.ColumnMappings.Add("numeradortasa", "numeradortasa");
                                    bulkCopy.ColumnMappings.Add("tipomoneda", "tipomoneda");
                                    bulkCopy.ColumnMappings.Add("plazo", "plazo");
                                    bulkCopy.ColumnMappings.Add("plazoactual", "plazoactual");
                                    bulkCopy.ColumnMappings.Add("numeradorplzpact", "numeradorplzpact");
                                    bulkCopy.ColumnMappings.Add("numeradorplzact", "numeradorplzact");
                                    bulkCopy.ColumnMappings.Add("saldodisponible", "saldodisponible");
                                    bulkCopy.ColumnMappings.Add("rucempleador", "rucempleador");
                                    bulkCopy.ColumnMappings.Add("codtienda", "codtienda");
                                    bulkCopy.ColumnMappings.Add("desctienda", "desctienda");
                                    bulkCopy.ColumnMappings.Add("montoconvenio", "montoconvenio");
                                    bulkCopy.ColumnMappings.Add("diacargo", "diacargo");
                                    bulkCopy.ColumnMappings.Add("fecinicioconv", "fecinicioconv");
                                    bulkCopy.ColumnMappings.Add("cuentacmr", "cuentacmr");
                                    bulkCopy.ColumnMappings.Add("tarjetacmr", "tarjetacmr");
                                    bulkCopy.ColumnMappings.Add("codigoejecutivo", "codigoejecutivo");
                                    bulkCopy.ColumnMappings.Add("tipocambio", "tipocambio");

                                    bulkCopy.WriteToServer(dtDP);
                                }
                            }
                            #endregion

                            dtDP.Rows.Clear();
                        }

                        j++;
                        porcentaje = Convert.ToInt32((j / intTotal) * 100);
                        bw1.ReportProgress(porcentaje);
                    }
                }
                using (var conexionBulkCopy = new SqlConnection(conexion))
                {
                    conexionBulkCopy.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conexion))
                    {
                        bulkCopy.BulkCopyTimeout = int.MaxValue;
                        bulkCopy.DestinationTableName = "dbo.ProcesoGestionTasas";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("codcategoria", "codcategoria");
                        bulkCopy.ColumnMappings.Add("categoria", "categoria");
                        bulkCopy.ColumnMappings.Add("codsubcategoria", "codsubcategoria");
                        bulkCopy.ColumnMappings.Add("subcategoria", "subcategoria");
                        bulkCopy.ColumnMappings.Add("cuenta", "cuenta");
                        bulkCopy.ColumnMappings.Add("tipodocumento", "tipodocumento");
                        bulkCopy.ColumnMappings.Add("numerodocumento", "numerodocumento");
                        bulkCopy.ColumnMappings.Add("nombre", "nombre");
                        bulkCopy.ColumnMappings.Add("ejecutivo", "ejecutivo");
                        bulkCopy.ColumnMappings.Add("estado", "estado");
                        bulkCopy.ColumnMappings.Add("descestado", "descestado");
                        bulkCopy.ColumnMappings.Add("fecproceso", "fecproceso");
                        bulkCopy.ColumnMappings.Add("mesproceso", "mesproceso");
                        bulkCopy.ColumnMappings.Add("fecapertura", "fecapertura");
                        bulkCopy.ColumnMappings.Add("mesapertura", "mesapertura");
                        bulkCopy.ColumnMappings.Add("fecrenovacion", "fecrenovacion");
                        bulkCopy.ColumnMappings.Add("mesrenovacion", "mesrenovacion");
                        bulkCopy.ColumnMappings.Add("fecvencimiento", "fecvencimiento");
                        bulkCopy.ColumnMappings.Add("mesvencimiento", "mesvencimiento");
                        bulkCopy.ColumnMappings.Add("msaldo", "msaldo");
                        bulkCopy.ColumnMappings.Add("tasa", "tasa");
                        bulkCopy.ColumnMappings.Add("numeradortasa", "numeradortasa");
                        bulkCopy.ColumnMappings.Add("tipomoneda", "tipomoneda");
                        bulkCopy.ColumnMappings.Add("plazo", "plazo");
                        bulkCopy.ColumnMappings.Add("plazoactual", "plazoactual");
                        bulkCopy.ColumnMappings.Add("numeradorplzpact", "numeradorplzpact");
                        bulkCopy.ColumnMappings.Add("numeradorplzact", "numeradorplzact");
                        bulkCopy.ColumnMappings.Add("saldodisponible", "saldodisponible");
                        bulkCopy.ColumnMappings.Add("rucempleador", "rucempleador");
                        bulkCopy.ColumnMappings.Add("codtienda", "codtienda");
                        bulkCopy.ColumnMappings.Add("desctienda", "desctienda");
                        bulkCopy.ColumnMappings.Add("montoconvenio", "montoconvenio");
                        bulkCopy.ColumnMappings.Add("diacargo", "diacargo");
                        bulkCopy.ColumnMappings.Add("fecinicioconv", "fecinicioconv");
                        bulkCopy.ColumnMappings.Add("cuentacmr", "cuentacmr");
                        bulkCopy.ColumnMappings.Add("tarjetacmr", "tarjetacmr");
                        bulkCopy.ColumnMappings.Add("codigoejecutivo", "codigoejecutivo");
                        bulkCopy.ColumnMappings.Add("tipocambio", "tipocambio");
                        #endregion

                        bulkCopy.WriteToServer(dtDP);
                    }
                }

                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;
                //objclsfrmBases.BotonActualizar = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonAgregarDP = true;
                objclsfrmBases.TextoTipoCambio = true;

                bw1.ReportProgress(100);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = 1;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosDP);
                _proceso.tipo = "Archivo Stock BF";
                _intRetorno = m_proceso.InsertarProceso(conexion, _proceso);

                MessageBox.Show("Archivo(s) procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;    
                //objclsfrmBases.BotonActualizar = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonAgregarDP = true;
                objclsfrmBases.TextoTipoCambio = true;
                bw1.ReportProgress(100);
            }
        }

        private void frmCargaStockBF_Load(object sender, EventArgs e)
        {
            //Carga de fecha
            lblfechacarga23.Text = DateTime.Now.ToString("G");
            txttipocambio.Focus(); 
            cargaDatos();
        }

        private void cargaDatos()
        {
            DataTable dt = new DataTable();

            dt = m_proceso.ListarProceso(conexion, "Archivo Stock BF");

            if (dt.Rows.Count > 0)
            {
                gvlistado.DataSource = dt;
                gvlistado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void txttipocambio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txttipocambio.Text.Length; i++)
            {
                if (txttipocambio.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Total
            if (objclsfrmBases.NombreArchivosDP.Trim() != "") ProcesoCarga();
        }

        private void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 100)
            {
                progressBar1.Value = 100;
            }
            else 
            {
                progressBar1.Value = e.ProgressPercentage;
            }
            
            lblmensajeproceso.Text = objclsfrmBases.MensajeProceso;

            if (e.ProgressPercentage == 0)
            {
                btnProcesar.Enabled = false;
                btnLimpiar.Enabled = false;
                btnSalir.Enabled = false;
                btnAgregar.Enabled = false;
                
                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];

                ms.Items[0].Enabled = false;
                ms.Items[1].Enabled = false;
            }

            if (e.ProgressPercentage == 100)
            {
                btnProcesar.Enabled = objclsfrmBases.BotonProcesar;
                btnLimpiar.Enabled = objclsfrmBases.BotonLimpiar;
                btnSalir.Enabled = objclsfrmBases.BotonSalir;
                btnAgregar.Enabled = objclsfrmBases.BotonAgregarDP;
                
                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
                ms.Items[0].Enabled = objclsfrmBases.BotonMenuMantenimientos;
                ms.Items[1].Enabled = objclsfrmBases.BotonMenuProcesos;

                lblmensajeproceso.Text = "";
                progressBar1.Value = 0;
            }
        }
    }
}