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
    public partial class FrmProcesoCargaDP : MetroForm
    {
        int _intretorno = 0;

        public FrmProcesoCargaDP()
        {
            InitializeComponent();
        }

        readonly string _conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases objclsfrmBases = new clsfrmBases();

        readonly NegocioProyMDIBFGestionTasasDP.proceso _mProceso = new NegocioProyMDIBFGestionTasasDP.proceso();
        readonly NegocioProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP _mProcesoCuentaSueldoDp = new NegocioProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP();
        readonly NegocioProyMDIBFGestionTasasDP.ProcesoClienteCMRDP _mProcesoClienteCmrdp = new NegocioProyMDIBFGestionTasasDP.ProcesoClienteCMRDP();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtCuentaSueldoDP.Text.Trim() == "" && txtClienteCMRDP.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese al menos un archivo para realizar el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seguro que desea procesar los archivos seleccionados?", "Carga DP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK))
            {
                return;
            }

            objclsfrmBases.BotonClienteCMRDP = btnClienteCMRDP.Enabled;
            objclsfrmBases.BotonCuentaSueldoDP = btnCuentaSueldoDP.Enabled;

            objclsfrmBases.MensajeProceso = (string)lblmensajeproceso.Text.Trim();
            objclsfrmBases.BotonLimpiar = btnLimpiar.Enabled;
            objclsfrmBases.BotonCerrarVentana = true;

            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
            objclsfrmBases.BotonMenuMantenimientos = ms.Items[0].Enabled;
            objclsfrmBases.BotonMenuProcesos = ms.Items[1].Enabled;
           

            //DP
            string filenameCuentaSueldoDP = System.IO.Path.GetFileName(txtCuentaSueldoDP.Text.Trim());
            objclsfrmBases.pathNombreArchivosCuentaSueldoDP = txtCuentaSueldoDP.Text.Trim();

            string filenameClienteCMRDP = System.IO.Path.GetFileName(txtClienteCMRDP.Text.Trim());
            objclsfrmBases.pathNombreArchivosClienteCMRDP = txtClienteCMRDP.Text.Trim();

            objclsfrmBases.NombreArchivosCuentaSueldoDP = filenameCuentaSueldoDP;
            objclsfrmBases.NombreArchivosClienteCMRDP = filenameClienteCMRDP;

            bw1.RunWorkerAsync();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuentaSueldoDP.Text = "";
            txtClienteCMRDP.Text = "";
        }

        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            //DP
            if (objclsfrmBases.NombreArchivosCuentaSueldoDP.Trim() != "") ProcesoCuentaSueldoDP();
            if (objclsfrmBases.NombreArchivosClienteCMRDP.Trim() != "") ProcesoClienteCMRDP();
        }

        private void ProcesoCuentaSueldoDP()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga cuenta sueldo DP...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;

            try
            {
                //Eliminar los registros de Cuenta Sueldo DP
                bool resultado = _mProcesoCuentaSueldoDp.EliminarCuentaSueldoDP(_conexion);

                #region Crear dataTable

                DataTable dtDP = new DataTable();

                dtDP.Columns.Add("llave", typeof(string));
                dtDP.Columns.Add("fechaaperturaCS", typeof(string));

                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosCuentaSueldoDP))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP> records = reader.GetRecords<EntidadProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable

                        drDP["llave"] = record.llave.Trim();
                        drDP["fechaaperturaCS"] = record.fechaaperturaCS.Trim();
                        #endregion

                        dtDP.Rows.Add(drDP);

                        j++;

                        porcentaje = Convert.ToInt32((j / intTotal) * 100);
                        bw1.ReportProgress(porcentaje);
                    }
                }

                using (var conexionBulkCopy = new SqlConnection(_conexion))
                {
                    conexionBulkCopy.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_conexion))
                    {
                        bulkCopy.BulkCopyTimeout = int.MaxValue;
                        bulkCopy.DestinationTableName = "dbo.CuentaSueldoDP";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("llave", "llave");
                        bulkCopy.ColumnMappings.Add("fechaaperturaCS", "fechaaperturaCS");
                        #endregion

                        bulkCopy.WriteToServer(dtDP);
                    }
                }

                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonAgregarDP = true;
                objclsfrmBases.BotonClienteCMRDP = true;
                
                bw1.ReportProgress(100);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosCuentaSueldoDP);
                _proceso.tipo = "DP - Cuenta Sueldo";

                _intretorno = _mProceso.InsertarProceso(_conexion, _proceso);


                MessageBox.Show("Archivo(s) Cuenta Sueldo procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonClienteCMRDP = true;
                objclsfrmBases.BotonCuentaSueldoDP = true;
                bw1.ReportProgress(100);
            }
        }
        private void ProcesoClienteCMRDP()
        {
            objclsfrmBases.MensajeProceso = "Procesando cliente CMR DP...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;

            try
            {
                //Eliminar los registros solicitados
                bool resultado = _mProcesoClienteCmrdp.EliminarProcesoClienteCMRDP(_conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosClienteCMRDP);
                _proceso.tipo = "DP - CMR";

                _intretorno = _mProceso.InsertarProceso(_conexion, _proceso);

                #region Crear dataTable

                DataTable dtDP = new DataTable();

                dtDP.Columns.Add("llave", typeof(string));
                dtDP.Columns.Add("t_cliente", typeof(string));

                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosClienteCMRDP))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasasDP.ProcesoClienteCMRDP> records = reader.GetRecords<EntidadProyMDIBFGestionTasasDP.ProcesoClienteCMRDP>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasasDP.ProcesoClienteCMRDP record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable

                        drDP["llave"] = record.llave.Trim();
                        drDP["t_cliente"] = record.t_cliente.Trim();
                        #endregion

                        dtDP.Rows.Add(drDP);
                        j++;
                        porcentaje = Convert.ToInt32((j / intTotal) * 100);
                        if (porcentaje <= 100)
                        {
                            bw1.ReportProgress(porcentaje);
                        }
                    }
                }
                using (var conexionBulkCopy = new SqlConnection(_conexion))
                {
                    conexionBulkCopy.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(_conexion))
                    {
                        bulkCopy.BulkCopyTimeout = int.MaxValue;
                        bulkCopy.DestinationTableName = "dbo.ClienteCMRDP";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("llave", "llave");
                        bulkCopy.ColumnMappings.Add("t_cliente", "t_cliente");
                        #endregion

                        bulkCopy.WriteToServer(dtDP);
                    }
                }

                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonActualizar = true;
                objclsfrmBases.BotonMenuReportes = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonAgregarDP = true;
                objclsfrmBases.BotonClienteCMRDP = true;
                objclsfrmBases.BotonCuentaSueldoDP = true;
                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) CMR procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonClienteCMRDP = true;
                objclsfrmBases.BotonCuentaSueldoDP = true;
                bw1.ReportProgress(100);
            }
        } 
    }
}