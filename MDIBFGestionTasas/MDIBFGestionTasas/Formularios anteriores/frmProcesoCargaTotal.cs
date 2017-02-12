using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioProyMDIBFGestionTasas;
using EntidadProyMDIBFGestionTasas;
using MDIBFGestionTasasDP.modelos;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using CsvHelper;

namespace MDIBFGestionTasasDP
{
    public partial class frmProcesoCargaTotal : Form
    {
        int intretorno = 0;
        string strusuario;
        public frmProcesoCargaTotal(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }

        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases objclsfrmBases = new clsfrmBases();

        NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP m_procesogestionDP = new NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP();
        NegocioProyMDIBFGestionTasasDP.responsable m_responsable = new NegocioProyMDIBFGestionTasasDP.responsable();
        NegocioProyMDIBFGestionTasasDP.proceso m_proceso = new NegocioProyMDIBFGestionTasasDP.proceso();
        
        NegocioProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP m_procesoCuentaSueldoDP = new NegocioProyMDIBFGestionTasasDP.ProcesoCuentaSueldoDP();
        NegocioProyMDIBFGestionTasasDP.ProcesoClienteCMRDP m_procesoClienteCMRDP = new NegocioProyMDIBFGestionTasasDP.ProcesoClienteCMRDP();

        NegocioProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS m_procesoCuentaSueldoCTS = new NegocioProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS();
        NegocioProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS m_procesoAbonoQuintaCTS = new NegocioProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS();
        NegocioProyMDIBFGestionTasas.ProcesoAbono360CTS m_procesoAbono360CTS = new NegocioProyMDIBFGestionTasas.ProcesoAbono360CTS();
        NegocioProyMDIBFGestionTasas.ProcesoMigracionCTS m_ProcesoMigracionCTS = new NegocioProyMDIBFGestionTasas.ProcesoMigracionCTS();
        NegocioProyMDIBFGestionTasas.ProcesoContactoCTS m_ProcesoContactoCTS = new NegocioProyMDIBFGestionTasas.ProcesoContactoCTS();

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (txtprocesoDP.Text.Trim() == "" && txtCuentaSueldoDP.Text.Trim() == "" && txtClienteCMRDP.Text.Trim() == "" && txtabonoQuintaCTS.Text.Trim() == "" && txtcuentasueldoCTS.Text.Trim() == "" && txtabono360CTS.Text.Trim() == "" && txtmigracionCuentaCTS.Text.Trim() == "" && txtdatoscontactoCTS.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese al menos un archivo para realizar el proceso.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Seguro que desea procesar los archivos seleccionados?", "Carga Total", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (!result.Equals(DialogResult.OK))
            {
                return;
            }

            objclsfrmBases.BotonAgregarDP = btnAgregarDP.Enabled;
            objclsfrmBases.BotonClienteCMRDP = btnClienteCMRDP.Enabled;
            objclsfrmBases.BotonCuentaSueldoDP = btnCuentaSueldoDP.Enabled;
            objclsfrmBases.BotonCuentaSueldoCTS = btncuentasueldoCTS.Enabled;
            objclsfrmBases.BotonAbono360CTS = btnabono360CTS.Enabled;
            objclsfrmBases.BotonAbonoQuintaCTS = btnabonoQuintaCTS.Enabled;
            objclsfrmBases.BotonMigracionCuentaCTS = btnmigracionCuentaCTS.Enabled;
            objclsfrmBases.BotonDatosContactoCTS = btnDatosContactoCTS.Enabled;

            objclsfrmBases.Responsable = (int)ddlresponsable.SelectedValue;
            objclsfrmBases.MensajeProceso = (string)lblmensajeproceso.Text.Trim();
            objclsfrmBases.BotonLimpiar = btnLimpiar.Enabled;
            objclsfrmBases.BotonActualizar = btnActualizar.Enabled;
            objclsfrmBases.BotonCerrarVentana = true;

            Form frm = (Form)this.MdiParent;
            MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
            objclsfrmBases.BotonMenuMantenimientos = ms.Items[0].Enabled;
            objclsfrmBases.BotonMenuProcesos = ms.Items[1].Enabled;
            objclsfrmBases.BotonMenuReportes = ms.Items[2].Enabled;

            //DP
            string filenameDP = System.IO.Path.GetFileName(txtprocesoDP.Text.Trim());
            objclsfrmBases.pathNombreArchivosDP = txtprocesoDP.Text.Trim();

            string filenameCuentaSueldoDP = System.IO.Path.GetFileName(txtCuentaSueldoDP.Text.Trim());
            objclsfrmBases.pathNombreArchivosCuentaSueldoDP = txtCuentaSueldoDP.Text.Trim();

            string filenameClienteCMRDP = System.IO.Path.GetFileName(txtClienteCMRDP.Text.Trim());
            objclsfrmBases.pathNombreArchivosClienteCMRDP = txtClienteCMRDP.Text.Trim();

            objclsfrmBases.NombreArchivosDP = filenameDP;
            objclsfrmBases.NombreArchivosCuentaSueldoDP = filenameCuentaSueldoDP;
            objclsfrmBases.NombreArchivosClienteCMRDP = filenameClienteCMRDP;

            //CTS
            string filenamecuentasueldoCTS = System.IO.Path.GetFileName(txtcuentasueldoCTS.Text.Trim());
            objclsfrmBases.pathNombreArchivosCuentaSueldoCTS = txtcuentasueldoCTS.Text.Trim();

            string filenameAbono360CTS = System.IO.Path.GetFileName(txtabono360CTS.Text.Trim());
            objclsfrmBases.pathNombreArchivosAbono360CTS = txtabono360CTS.Text.Trim();

            string filenameAbonoQuintaCTS = System.IO.Path.GetFileName(txtabonoQuintaCTS.Text.Trim());
            objclsfrmBases.pathNombreArchivosAbonoQuintaCTS = txtabonoQuintaCTS.Text.Trim();

            string filenameMigracionCuentaCTS = System.IO.Path.GetFileName(txtmigracionCuentaCTS.Text.Trim());
            objclsfrmBases.pathNombreArchivosMigracionCuentaCTS = txtmigracionCuentaCTS.Text.Trim();

            string filenameDatosContactoCTS = System.IO.Path.GetFileName(txtdatoscontactoCTS.Text.Trim());
            objclsfrmBases.pathNombreArchivosDatosContactoCTS = txtdatoscontactoCTS.Text.Trim();

            objclsfrmBases.NombreArchivosCuentaSueldoCTS = filenamecuentasueldoCTS;
            objclsfrmBases.NombreArchivosAbono360CTS = filenameAbono360CTS;
            objclsfrmBases.NombreArchivosAbonoQuintaCTS = filenameAbonoQuintaCTS;
            objclsfrmBases.NombreArchivosMigracionCuentaCTS = filenameMigracionCuentaCTS;
            objclsfrmBases.NombreArchivosDatosContactoCTS = filenameDatosContactoCTS;

            bw1.RunWorkerAsync();

            cargaDatos();

        }
        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {

            //Total
            if (objclsfrmBases.NombreArchivosDP.Trim() != "") ProcesoCargaDP();

            //DP
            if (objclsfrmBases.NombreArchivosCuentaSueldoDP.Trim() != "") ProcesoCuentaSueldoDP();
            if (objclsfrmBases.NombreArchivosClienteCMRDP.Trim() != "") ProcesoClienteCMRDP();
          
            //CTS
            if (objclsfrmBases.NombreArchivosCuentaSueldoCTS.Trim() != "") ProcesoCuentaSueldoCTS();
            if (objclsfrmBases.NombreArchivosAbonoQuintaCTS.Trim() != "") ProcesoAbonoQuintaCTS();
            if (objclsfrmBases.NombreArchivosAbono360CTS.Trim() != "") ProcesoAbono360CTS();
            if (objclsfrmBases.NombreArchivosMigracionCuentaCTS.Trim() != "") ProcesoMigracionCuentaCTS();
            if (objclsfrmBases.pathNombreArchivosDatosContactoCTS.Trim() != "") ProcesoDatosContactoCTS();
        }
        private void ProcesoCargaDP()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga de datos...";
            int porcentaje = 0;
            int intTotal = 2400000;
            decimal j = 0;

            try
            {
                //Eliminar los registros solicitados
                bool resultado = m_procesogestionDP.EliminarProcesoGestionTasas(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosDP);
                _proceso.tipo = "Total";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

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
                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosDP, System.Text.Encoding.Default, false))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP> records = reader.GetRecords<EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS  = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false; 
                    objclsfrmBases.BotonDatosContactoCTS = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasasDP.ProcesoGestionDP record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        

                        #region Asignar valores dataTable

                        //if (j == 2997)
                        //{
                        //    string hola = "parar";
                        //}

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
                        drDP["nombre"] = record.nombre.Replace(',',' ');
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
                        drDP["codigoejecutivo"] = record.codigoejecutivo.Trim(); ;
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;
                bw1.ReportProgress(100);
            }
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
                bool resultado = m_procesoCuentaSueldoDP.EliminarCuentaSueldoDP(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosCuentaSueldoDP);
                _proceso.tipo = "DP - Cuenta Sueldo";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

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
                        objclsfrmBases.BotonActualizar = false;
                        objclsfrmBases.BotonMenuReportes = false;
                        objclsfrmBases.BotonProcesar = false;
                        objclsfrmBases.BotonLimpiar = false;
                        objclsfrmBases.BotonSalir = false;
                        objclsfrmBases.BotonAgregarDP = false;
                        objclsfrmBases.BotonClienteCMRDP = false;
                        objclsfrmBases.BotonCuentaSueldoDP = false;
                        objclsfrmBases.BotonAbono360CTS = false;
                        objclsfrmBases.BotonAbonoQuintaCTS = false;
                        objclsfrmBases.BotonCuentaSueldoCTS = false;
                        objclsfrmBases.BotonMigracionCuentaCTS = false;
                        objclsfrmBases.BotonDatosContactoCTS = false;

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

                    using (var conexionBulkCopy = new SqlConnection(conexion))
                    {
                        conexionBulkCopy.Open();
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conexion))
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
                objclsfrmBases.BotonActualizar = true;
                objclsfrmBases.BotonMenuReportes = true;
                objclsfrmBases.BotonProcesar = true;
                objclsfrmBases.BotonLimpiar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonAgregarDP = true;
                objclsfrmBases.BotonClienteCMRDP = true;
                objclsfrmBases.BotonCuentaSueldoDP = true;
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) Cuenta Sueldo procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;
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
                bool resultado = m_procesoClienteCMRDP.EliminarProcesoClienteCMRDP(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosClienteCMRDP);
                _proceso.tipo = "DP - CMR";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

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
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false;
                    objclsfrmBases.BotonDatosContactoCTS = false;

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
                using (var conexionBulkCopy = new SqlConnection(conexion))
                {
                    conexionBulkCopy.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conexion))
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;
                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) CMR procesados con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;
                bw1.ReportProgress(100);
            } 
        } 
        private void ProcesoCuentaSueldoCTS()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga cuenta sueldo CTS...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;
            try
            {
                //Eliminar los registros de Cuenta Sueldo DP
                bool resultado = m_procesoCuentaSueldoCTS.EliminarCuentaSueldoCTS(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosCuentaSueldoCTS);
                _proceso.tipo = "CTS - Cuenta Sueldo";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

                #region Crear dataTable
                DataTable dtDP = new DataTable();
                dtDP.Columns.Add("numerodocumento", typeof(string));
                dtDP.Columns.Add("flag", typeof(int));
                dtDP.Columns.Add("fechaaperturaCS", typeof(string));
                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosCuentaSueldoCTS, System.Text.Encoding.Default, false))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS> records = reader.GetRecords<EntidadProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false;
                    objclsfrmBases.BotonDatosContactoCTS = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasas.ProcesoCuentaSueldoCTS record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable

                        if (record.numerodocumento.Length > 7) drDP["numerodocumento"] = record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 7) drDP["numerodocumento"] = "0" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 6) drDP["numerodocumento"] = "00" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 5) drDP["numerodocumento"] = "000" + record.numerodocumento.Trim();

                        drDP["flag"] = record.flag;
                        drDP["fechaaperturaCS"] = record.fechaaperturaCS.Trim();
                        #endregion

                        dtDP.Rows.Add(drDP);
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
                        bulkCopy.DestinationTableName = "dbo.CuentaSueldoCTS";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("numerodocumento", "numerodocumento");
                        bulkCopy.ColumnMappings.Add("flag", "flag");
                        bulkCopy.ColumnMappings.Add("fechaaperturaCS", "fechaaperturaCS");
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) Cuenta Sueldo CTS procesado con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);
            }

        }
        private void ProcesoAbonoQuintaCTS()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga abono Quinta CTS...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;
            //try
            //{
                //Eliminar los registros de abono quinta
                bool resultado = m_procesoAbonoQuintaCTS.EliminarAbonoQuintaCTS(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosAbonoQuintaCTS);
                _proceso.tipo = "CTS - Abono Quinta";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

                #region Crear dataTable

                DataTable dtDP = new DataTable();

                dtDP.Columns.Add("numerodocumento", typeof(string));
                dtDP.Columns.Add("fecha", typeof(string));
                dtDP.Columns.Add("flag", typeof(int));

                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosAbonoQuintaCTS))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS> records = reader.GetRecords<EntidadProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false;
                    objclsfrmBases.BotonDatosContactoCTS = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasas.ProcesoAbonoQuintaCTS record in records)
                    {
                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable

                        if (record.numerodocumento.Length > 7) drDP["numerodocumento"] = record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 7) drDP["numerodocumento"] = "0" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 6) drDP["numerodocumento"] = "00" + record.numerodocumento.Trim();
                        if (record.numerodocumento.Length == 5) drDP["numerodocumento"] = "000" + record.numerodocumento.Trim();

                        drDP["fecha"] = record.fecha.Trim();
                        drDP["flag"] = record.flag;
                        #endregion

                        dtDP.Rows.Add(drDP);
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
                        bulkCopy.DestinationTableName = "dbo.AbonoQuintaCTS";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("numerodocumento", "numerodocumento");
                        bulkCopy.ColumnMappings.Add("fecha", "fecha");
                        bulkCopy.ColumnMappings.Add("flag", "flag");
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) Abono Quinta CTS procesado con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    objclsfrmBases.BotonMenuMantenimientos = true;
            //    objclsfrmBases.BotonMenuProcesos = true;
            //    objclsfrmBases.BotonActualizar = true;
            //    objclsfrmBases.BotonMenuReportes = true;
            //    objclsfrmBases.BotonProcesar = true;
            //    objclsfrmBases.BotonLimpiar = true;
            //    objclsfrmBases.BotonSalir = true;
            //    objclsfrmBases.BotonAgregarDP = true;
            //    objclsfrmBases.BotonClienteCMRDP = true;
            //    objclsfrmBases.BotonCuentaSueldoDP = true;
            //    objclsfrmBases.BotonAbono360CTS = true;
            //    objclsfrmBases.BotonAbonoQuintaCTS = true;
            //    objclsfrmBases.BotonCuentaSueldoCTS = true;
            //    objclsfrmBases.BotonMigracionCuentaCTS = true;
            //    objclsfrmBases.BotonDatosContactoCTS = true;

            //    bw1.ReportProgress(100);
            //}

        }
        private void ProcesoAbono360CTS()
        {
            objclsfrmBases.MensajeProceso = "Procesando carga abono 360 CTS...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;
            try
            {
                //Eliminar los registros de carga abono 360 CTS
                bool resultado = m_procesoAbono360CTS.EliminarAbono360CTS(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosAbono360CTS);
                _proceso.tipo = "CTS - Abono 360";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

                #region Crear dataTable

                DataTable dtDP = new DataTable();

                dtDP.Columns.Add("numerocuenta", typeof(string));
                dtDP.Columns.Add("fecha", typeof(string));
                dtDP.Columns.Add("flag", typeof(int));

                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosAbono360CTS))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasas.ProcesoAbono360CTS> records = reader.GetRecords<EntidadProyMDIBFGestionTasas.ProcesoAbono360CTS>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false;
                    objclsfrmBases.BotonDatosContactoCTS = false;

                    dtDP.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasas.ProcesoAbono360CTS record in records)
                    {

                        DataRow drDP = dtDP.NewRow();

                        #region Asignar valores dataTable
                        drDP["numerocuenta"] = record.numerocuenta.Trim();
                        drDP["fecha"] = record.fecha.Trim();
                        drDP["flag"] = record.flag;
                        #endregion

                        dtDP.Rows.Add(drDP);
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
                        bulkCopy.DestinationTableName = "dbo.Abono360CTS";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("numerocuenta", "numerocuenta");
                        bulkCopy.ColumnMappings.Add("fecha", "fecha");
                        bulkCopy.ColumnMappings.Add("flag", "flag");
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) Abono 360 CTS procesado con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;


                bw1.ReportProgress(100);
            }
        }
        private void ProcesoMigracionCuentaCTS()
        {
            try
            {
            objclsfrmBases.MensajeProceso = "Procesando carga Migración CTS...";
            int porcentaje = 0;
            int intTotal = 1000000;
            decimal j = 0;

            //Eliminar los registros de migración CTS
            bool resultado = m_ProcesoMigracionCTS.EliminarMigracionCTS(conexion);

            //Insertar el proceso
            EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
            _proceso.responsableId = objclsfrmBases.Responsable;
            _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosMigracionCuentaCTS);
            _proceso.tipo = "CTS - Migracion";

            intretorno = m_proceso.InsertarProceso(conexion, _proceso);

            #region Crear dataTable

            DataTable dtMg = new DataTable();

            dtMg.Columns.Add("cuenta", typeof(string));
            dtMg.Columns.Add("fechamigracion", typeof(string));
            dtMg.Columns.Add("codprodamigrar", typeof(int));
            dtMg.Columns.Add("productoamigrar", typeof(string));

            #endregion

            using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosMigracionCuentaCTS))
            {
                var reader = new CsvReader(sr);
                IEnumerable<EntidadProyMDIBFGestionTasas.ProcesoMigracionCTS> records = reader.GetRecords<EntidadProyMDIBFGestionTasas.ProcesoMigracionCTS>();

                objclsfrmBases.BotonMenuMantenimientos = false;
                objclsfrmBases.BotonMenuProcesos = false;
                objclsfrmBases.BotonActualizar = false;
                objclsfrmBases.BotonMenuReportes = false;
                objclsfrmBases.BotonProcesar = false;
                objclsfrmBases.BotonLimpiar = false;
                objclsfrmBases.BotonSalir = false;
                objclsfrmBases.BotonAgregarDP = false;
                objclsfrmBases.BotonClienteCMRDP = false;
                objclsfrmBases.BotonCuentaSueldoDP = false;
                objclsfrmBases.BotonAbono360CTS = false;
                objclsfrmBases.BotonAbonoQuintaCTS = false;
                objclsfrmBases.BotonCuentaSueldoCTS = false;
                objclsfrmBases.BotonMigracionCuentaCTS = false;
                objclsfrmBases.BotonDatosContactoCTS = false;


                dtMg.Rows.Clear();

                foreach (EntidadProyMDIBFGestionTasas.ProcesoMigracionCTS record in records)
                {
                    DataRow drMg = dtMg.NewRow();

                    #region Asignar valores dataTable
                    drMg["cuenta"] = record.cuenta.Trim();
                    drMg["fechamigracion"] = record.fechacambio.Trim();
                    drMg["codprodamigrar"] = (int)record.codprodamigrar;
                    drMg["productoamigrar"] = record.productoamigrar.Trim();
                    #endregion

                    dtMg.Rows.Add(drMg);
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
                    bulkCopy.DestinationTableName = "dbo.MigracionCuentaCTS";

                    #region Datatable bullcopy
                    bulkCopy.ColumnMappings.Add("cuenta", "cuenta");
                    bulkCopy.ColumnMappings.Add("fechamigracion", "fechamigracion");
                    bulkCopy.ColumnMappings.Add("codprodamigrar", "codprodamigrar");
                    bulkCopy.ColumnMappings.Add("productoamigrar", "productoamigrar");
                    #endregion

                    bulkCopy.WriteToServer(dtMg);
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
            objclsfrmBases.BotonAbono360CTS = true;
            objclsfrmBases.BotonAbonoQuintaCTS = true;
            objclsfrmBases.BotonCuentaSueldoCTS = true;
            objclsfrmBases.BotonMigracionCuentaCTS = true;
            objclsfrmBases.BotonDatosContactoCTS = true;


            bw1.ReportProgress(100);

            MessageBox.Show("Archivo(s) Migración CTS procesado con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);
            }
        }
        private void ProcesoDatosContactoCTS()
        {
            try
            {
                objclsfrmBases.MensajeProceso = "Procesando carga Contacto CTS...";
                int porcentaje = 0;
                int intTotal = 1000000;
                decimal j = 0;

                //Eliminar los registros de carga contacto CTS
                bool resultado = m_ProcesoContactoCTS.EliminarContactoCTS(conexion);

                //Insertar el proceso
                EntidadProyMDIBFGestionTasasDP.proceso _proceso = new EntidadProyMDIBFGestionTasasDP.proceso();
                _proceso.responsableId = objclsfrmBases.Responsable;
                _proceso.nombrearchivo = Path.GetFileName(objclsfrmBases.pathNombreArchivosDatosContactoCTS);
                _proceso.tipo = "CTS - Contacto";

                intretorno = m_proceso.InsertarProceso(conexion, _proceso);

                #region Crear dataTable

                DataTable dtCon = new DataTable();

                dtCon.Columns.Add("cuenta", typeof(string));
                dtCon.Columns.Add("numerocuenta", typeof(string));
                dtCon.Columns.Add("llave", typeof(string));
                dtCon.Columns.Add("correoelectronico", typeof(string));
                dtCon.Columns.Add("telefonocelular", typeof(string));
                dtCon.Columns.Add("telefonofijo", typeof(string));
                dtCon.Columns.Add("direccion", typeof(string));

                #endregion

                using (var sr = new StreamReader(objclsfrmBases.pathNombreArchivosDatosContactoCTS))
                {
                    var reader = new CsvReader(sr);
                    IEnumerable<EntidadProyMDIBFGestionTasas.ProcesoContactoCTS> records = reader.GetRecords<EntidadProyMDIBFGestionTasas.ProcesoContactoCTS>();

                    objclsfrmBases.BotonMenuMantenimientos = false;
                    objclsfrmBases.BotonMenuProcesos = false;
                    objclsfrmBases.BotonActualizar = false;
                    objclsfrmBases.BotonMenuReportes = false;
                    objclsfrmBases.BotonProcesar = false;
                    objclsfrmBases.BotonLimpiar = false;
                    objclsfrmBases.BotonSalir = false;
                    objclsfrmBases.BotonAgregarDP = false;
                    objclsfrmBases.BotonClienteCMRDP = false;
                    objclsfrmBases.BotonCuentaSueldoDP = false;
                    objclsfrmBases.BotonAbono360CTS = false;
                    objclsfrmBases.BotonAbonoQuintaCTS = false;
                    objclsfrmBases.BotonCuentaSueldoCTS = false;
                    objclsfrmBases.BotonMigracionCuentaCTS = false;
                    objclsfrmBases.BotonDatosContactoCTS = false;

                    dtCon.Rows.Clear();

                    foreach (EntidadProyMDIBFGestionTasas.ProcesoContactoCTS record in records)
                    {
                        DataRow drCon = dtCon.NewRow();

                        #region Asignar valores dataTable
                        string cuenta = record.cuenta.Trim();
                        drCon["cuenta"] = cuenta;
                        drCon["numerocuenta"] = cuenta.Substring(0, 2) + "-" + cuenta.Substring(2, 3) + "-" + cuenta.Substring(5, 7) + "-" + cuenta.Substring(12, 1);
                        drCon["llave"] = record.llave.Trim();
                        drCon["correoelectronico"] = record.correoelectronico.Trim();
                        drCon["telefonocelular"] = record.telefonocelular.Trim();
                        drCon["telefonofijo"] = record.telefonofijo.Trim();
                        drCon["direccion"] = record.direccion.Trim();
                        #endregion

                        dtCon.Rows.Add(drCon);
                        j++;
                        porcentaje = Convert.ToInt32((j / intTotal) * 100);
                        if (porcentaje > 100) porcentaje = 100;
                        bw1.ReportProgress(porcentaje);
                    }
                }

                using (var conexionBulkCopy = new SqlConnection(conexion))
                {
                    conexionBulkCopy.Open();
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conexion))
                    {
                        bulkCopy.BulkCopyTimeout = int.MaxValue;
                        bulkCopy.DestinationTableName = "dbo.ContactoCTS";

                        #region Datatable bullcopy
                        bulkCopy.ColumnMappings.Add("cuenta", "cuenta");
                        bulkCopy.ColumnMappings.Add("numerocuenta", "numerocuenta");
                        bulkCopy.ColumnMappings.Add("llave", "llave");
                        bulkCopy.ColumnMappings.Add("correoelectronico", "correoelectronico");
                        bulkCopy.ColumnMappings.Add("telefonocelular", "telefonocelular");
                        bulkCopy.ColumnMappings.Add("telefonofijo", "telefonofijo");
                        bulkCopy.ColumnMappings.Add("direccion", "direccion");
                        #endregion

                        bulkCopy.WriteToServer(dtCon);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);

                MessageBox.Show("Archivo(s) Contacto CTS procesado con éxito.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error en el proceso: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objclsfrmBases.BotonAbono360CTS = true;
                objclsfrmBases.BotonAbonoQuintaCTS = true;
                objclsfrmBases.BotonCuentaSueldoCTS = true;
                objclsfrmBases.BotonMigracionCuentaCTS = true;
                objclsfrmBases.BotonDatosContactoCTS = true;

                bw1.ReportProgress(100);
            }
        }
        private void frmProcesoCargaDP_Load(object sender, EventArgs e)
        {
            EntidadProyMDIBFGestionTasasDP.responsable _responsable = new EntidadProyMDIBFGestionTasasDP.responsable();
            ddlresponsable.DataSource = m_responsable.ListarResponsable(conexion, _responsable);
            ddlresponsable.ValueMember = "codigo";
            ddlresponsable.DisplayMember = "nombrecompleto";

            //Carga de fecha
            lblfechacarga.Text = DateTime.Now.ToString("G");

            cargaDatos();
            
        }
        private void cargaDatos() 
        {
            DataTable dt = new DataTable();

            dt = m_proceso.ListarProceso(conexion,"Todos");

            if (dt.Rows.Count > 0)
            {
                gvlistado.DataSource = dt;
                gvlistado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblmensajeproceso.Text = objclsfrmBases.MensajeProceso;

            if (e.ProgressPercentage == 0)
            {

                btnActualizar.Enabled = false;
                btnProcesar.Enabled = false;
                btnLimpiar.Enabled = false;
                btnSalir.Enabled = false;
                btnAgregarDP.Enabled = false;
                btnClienteCMRDP.Enabled = false;
                btnCuentaSueldoDP.Enabled = false;
                btnabono360CTS.Enabled = false;
                btnabonoQuintaCTS.Enabled = false;
                btncuentasueldoCTS.Enabled = false;
                btnmigracionCuentaCTS.Enabled = false;
                btnDatosContactoCTS.Enabled = false;

                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];

                ms.Items[0].Enabled = false;
                ms.Items[1].Enabled = false;
                ms.Items[2].Enabled = false;
            }

            if (e.ProgressPercentage == 100)
            {
                btnProcesar.Enabled = objclsfrmBases.BotonProcesar;
                btnLimpiar.Enabled = objclsfrmBases.BotonLimpiar;
                btnActualizar.Enabled = objclsfrmBases.BotonActualizar;
                btnSalir.Enabled = objclsfrmBases.BotonSalir;
                btnAgregarDP.Enabled = objclsfrmBases.BotonAgregarDP;
                btnClienteCMRDP.Enabled = objclsfrmBases.BotonClienteCMRDP;
                btnCuentaSueldoDP.Enabled = objclsfrmBases.BotonCuentaSueldoDP;
                btncuentasueldoCTS.Enabled = objclsfrmBases.BotonCuentaSueldoCTS;
                btnabono360CTS.Enabled = objclsfrmBases.BotonAbono360CTS;
                btnabonoQuintaCTS.Enabled = objclsfrmBases.BotonAbonoQuintaCTS;
                btnmigracionCuentaCTS.Enabled = objclsfrmBases.BotonMigracionCuentaCTS;
                btnDatosContactoCTS.Enabled = objclsfrmBases.BotonDatosContactoCTS;   

                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
                ms.Items[0].Enabled = objclsfrmBases.BotonMenuMantenimientos;
                ms.Items[1].Enabled = objclsfrmBases.BotonMenuProcesos;
                ms.Items[2].Enabled = objclsfrmBases.BotonMenuReportes;

                lblmensajeproceso.Text = "";
                progressBar1.Value = 0;
            }
        }       
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtprocesoDP.Text = "";
            txtCuentaSueldoDP.Text = "";
            txtClienteCMRDP.Text = "";

            txtcuentasueldoCTS.Text = "";
            txtabonoQuintaCTS.Text = "";
            txtabono360CTS.Text = "";
            txtmigracionCuentaCTS.Text = "";
            txtdatoscontactoCTS.Text = "";

        }
        private void btnCuentaSueldoDP_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtCuentaSueldoDP.Text = ofd1.FileName.Trim();
        }
        private void btnClienteCMRDP_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtClienteCMRDP.Text = ofd1.FileName.Trim();
        }
        private void btnabonoQuintaCTS_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtabonoQuintaCTS.Text = ofd1.FileName.Trim();
        }
        private void btnabono360CTS_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtabono360CTS.Text = ofd1.FileName.Trim();
        }
        private void btnmigracionCuentaCTS_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtmigracionCuentaCTS.Text = ofd1.FileName.Trim();
        }
        private void btnDatosContactoCTS_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtdatoscontactoCTS.Text = ofd1.FileName.Trim();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargaDatos();
        }
        private void btncuentasueldoCTS_Click(object sender, EventArgs e)
        {
            ofd1.Filter = "CSV Files|*.csv";
            ofd1.Title = "Archivos a cargar CSV";
            ofd1.FileName = string.Empty;

            if (ofd1.ShowDialog() == DialogResult.OK) txtcuentasueldoCTS.Text = ofd1.FileName.Trim();
        }
    }
}
