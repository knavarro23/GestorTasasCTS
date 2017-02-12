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
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;
using System.IO;
using CsvHelper;

namespace MDIBFGestionTasasDP
{
    public partial class frmReporteCargaDP : Form
    {
        string strusuario;
        string conexion = System.Configuration.ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
        public clsfrmBases objclsfrmBases = new clsfrmBases();
        string strRuta = "";
        int porcentaje = 0;

        NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP m_procesogestionDP = new NegocioProyMDIBFGestionTasasDP.ProcesoGestionDP();
        NegocioProyMDIBFGestionTasasDP.tipoproductoDP m_tipoproductoDP = new NegocioProyMDIBFGestionTasasDP.tipoproductoDP();
        NegocioProyMDIBFGestionTasasDP.productoDP m_productoDP = new NegocioProyMDIBFGestionTasasDP.productoDP();

        public frmReporteCargaDP(string usuario)
        {
            InitializeComponent();
            this.strusuario = usuario;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnExportar.Enabled = false;

            DataTable dt = new DataTable();

            dt = m_procesogestionDP.BusquedaProcesoDP(conexion, ddlproducto.SelectedValue.ToString());

            if (dt.Rows.Count > 0)
            {
                gvprocesosDP.DataSource = dt;
                gvprocesosDP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                btnBuscar.Enabled = true;
                btnExportar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontraron datos en la búsqueda.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvprocesosDP.DataSource = null;
                btnBuscar.Enabled = true; 
                btnExportar.Enabled = false;
            }
        }
        private void frmReporteCargaDP_Load(object sender, EventArgs e)
        {
            ddltipoproducto.DataSource = m_tipoproductoDP.ListarTipoProducto(conexion);
            ddltipoproducto.ValueMember = "codigo";
            ddltipoproducto.DisplayMember = "nombre";

            ddlproducto.DataSource = m_productoDP.ListarProductoDP(conexion, ddltipoproducto.SelectedValue.ToString());
            ddlproducto.ValueMember = "codigo";
            ddlproducto.DisplayMember = "nombre";

            btnExportar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ddltipoproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlproducto.DataSource = m_productoDP.ListarProductoDP(conexion, ddltipoproducto.SelectedValue.ToString());
            ddlproducto.ValueMember = "codigo";
            ddlproducto.DisplayMember = "nombre";
        }
        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (chktotal.Checked == false)
            {
                sfd1.Filter = "Excel Files|*.xlsx;*.xls;";
                sfd1.Title = "Archivo Excel a guardar";
            }
            else
            {
                sfd1.Filter = "CSV Files|*.csv;";
                sfd1.Title = "Archivo CSV a guardar";
            }
            
            sfd1.FileName = string.Empty;

            if (sfd1.ShowDialog() == DialogResult.OK) strRuta = sfd1.FileName; else return;

            objclsfrmBases.Producto = (string)ddlproducto.SelectedValue;
            objclsfrmBases.BotonBuscar = (bool)btnBuscar.Enabled;
            objclsfrmBases.BotonExportar = (bool)btnExportar.Enabled;
            objclsfrmBases.BotonSalir = (bool)btnSalir.Enabled;
            objclsfrmBases.ExportarTotalDP = (bool)chktotal.Checked;

            bw1.RunWorkerAsync();
        }
        private void bw1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (objclsfrmBases.ExportarTotalDP == false)
            {
                ReporteDP();
            }
             if (objclsfrmBases.ExportarTotalDP == true)
            {
                ReporteTotalDP();
            }
        }
        private void ReporteTotalDP()
        {
            objclsfrmBases.BotonBuscar = false;
            objclsfrmBases.BotonSalir = false;
            objclsfrmBases.BotonExportar = false;
            bw1.ReportProgress(100);

            FileInfo t = new FileInfo(strRuta);
            StreamWriter Tex = t.CreateText();

            string cadena = "codcategoria,categoria,codsubcategoria,subcategoria,cuenta,tipodocumento,numerodocumento," +
                            "nombre,ejecutivo,estado,descestado,fecproceso,mesproceso,fecapertura,mesapertura," +
                            "fecrenovacion,mesrenovacion,fecvencimiento,mesvencimiento,msaldo,tasa,numeradortasa," +
                            "plazo,plazoactual,numeradorplzpact,numeradorplzact,saldodisponible,rucempleador," +
                            "codtienda,desctienda,montoconvenio,diacargo,fecinicioconv,cuentacmr,tarjetacmr," +
                            "codigoejecutivo,flagcuentasueldo,flagclienteCMR,flagmontoinversion,flagsumacondicion," +
                            "flagpizarra,tipomoneda,plazoredondeado,flagproductounico,tasavigenteDP,flagcodprodnuevo," + 
                            "flagdiferencia";
           Tex.WriteLine(cadena);
           
           DataTable dt = m_procesogestionDP.ReporteProcesoTotalDP(conexion);
                
            int rCnt = 0;
            int i = 0;
            decimal j = 0;

            for (rCnt = 1; rCnt <= dt.Rows.Count; rCnt++)
            {
                cadena = dt.Rows[i]["codCategoria"].ToString() + "," + dt.Rows[i]["categoria"].ToString() + "," +
                         dt.Rows[i]["codsubcategoria"].ToString() + "," + dt.Rows[i]["subcategoria"].ToString() + "," +
                         dt.Rows[i]["cuenta"].ToString() + "," + dt.Rows[i]["tipodocumento"].ToString() + "," +
                         dt.Rows[i]["numerodocumento"].ToString() + "," + dt.Rows[i]["nombre"].ToString() + "," +
                         dt.Rows[i]["ejecutivo"].ToString() + "," + dt.Rows[i]["estado"].ToString() + "," +
                         dt.Rows[i]["descestado"].ToString() + "," + dt.Rows[i]["fecproceso"].ToString() + "," +
                         dt.Rows[i]["mesproceso"].ToString() + "," + dt.Rows[i]["fecapertura"].ToString() + "," +
                         dt.Rows[i]["mesapertura"].ToString() + "," + dt.Rows[i]["fecrenovacion"].ToString() + "," +
                         dt.Rows[i]["mesrenovacion"].ToString() + "," + dt.Rows[i]["fecvencimiento"].ToString() + "," +
                         dt.Rows[i]["mesvencimiento"].ToString() + "," + dt.Rows[i]["msaldo"].ToString() + "," +
                         dt.Rows[i]["tasa"].ToString() + "," + dt.Rows[i]["numeradortasa"].ToString() + "," +
                         dt.Rows[i]["plazo"].ToString() + "," +
                         dt.Rows[i]["plazoactual"].ToString() + "," + dt.Rows[i]["numeradorplzpact"].ToString() + "," +
                         dt.Rows[i]["numeradorplzact"].ToString() + "," + dt.Rows[i]["saldodisponible"].ToString() + "," +
                         dt.Rows[i]["rucempleador"].ToString() + "," + dt.Rows[i]["codtienda"].ToString() + "," +
                         dt.Rows[i]["desctienda"].ToString() + "," + dt.Rows[i]["montoconvenio"].ToString() + "," +
                         dt.Rows[i]["diacargo"].ToString() + "," + dt.Rows[i]["fecinicioconv"].ToString() + "," +
                         dt.Rows[i]["cuentacmr"].ToString() + "," + dt.Rows[i]["tarjetacmr"].ToString() + "," +
                         dt.Rows[i]["codigoejecutivo"].ToString() + "," + dt.Rows[i]["flagcuentasueldo"].ToString() + "," +
                         dt.Rows[i]["flagclienteCMR"].ToString() + "," + dt.Rows[i]["flagmontoinversion"].ToString() + "," +
                         dt.Rows[i]["flagsumacondicion"].ToString() + "," + dt.Rows[i]["flagpizarra"].ToString() + "," +
                         dt.Rows[i]["tipomoneda"].ToString() + "," +
                         dt.Rows[i]["plazoredondeado"].ToString() + "," + dt.Rows[i]["flagproductounico"].ToString() + "," +
                         dt.Rows[i]["tasavigenteDP"].ToString() + "," + dt.Rows[i]["flagcodprodnuevo"].ToString() + "," +
                         dt.Rows[i]["flagdiferencia"].ToString();

                        Tex.WriteLine(cadena);
                        i++; j++;
                        porcentaje = Convert.ToInt32((j / dt.Rows.Count) * 100);
                        bw1.ReportProgress(porcentaje);
            }

            Tex.Flush();
            Tex.Close();
            
            objclsfrmBases.BotonMenuProcesos = true;
            objclsfrmBases.BotonMenuReportes = true;
            objclsfrmBases.BotonMenuMantenimientos = true;
            objclsfrmBases.BotonExportar = true;
            objclsfrmBases.BotonSalir = true;
            objclsfrmBases.BotonBuscar = true;
            bw1.ReportProgress(100);

            MessageBox.Show("Reporte generado exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        private void ReporteDP()
        {
            try
            {
                objclsfrmBases.BotonBuscar = false;
                objclsfrmBases.BotonExportar = false;
                bw1.ReportProgress(100);

                objclsfrmBases.MensajeProceso = "Procesando reporte DP: " + objclsfrmBases.Producto.ToString();
                porcentaje = 0;

                Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlApp.Visible = false;

                if (xlApp == null)
                {
                    MessageBox.Show("Excel no se encuentra instalado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);


                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlWorkSheet.Cells[1, 1] = "CodCategoria";
                xlWorkSheet.Cells[1, 2] = "Categoria";
                xlWorkSheet.Cells[1, 3] = "CodSubCategoria";
                xlWorkSheet.Cells[1, 4] = "SubCategoria";
                xlWorkSheet.Cells[1, 5] = "Cuenta";
                xlWorkSheet.Cells[1, 6] = "TipoDocumento";
                xlWorkSheet.Cells[1, 7] = "NumeroDocumento";
                xlWorkSheet.Cells[1, 8] = "Nombre";
                xlWorkSheet.Cells[1, 9] = "Ejecutivo";
                xlWorkSheet.Cells[1, 10] = "Estado";
                xlWorkSheet.Cells[1, 11] = "DescEstado";
                xlWorkSheet.Cells[1, 12] = "FechaProceso";
                xlWorkSheet.Cells[1, 13] = "MesProceso";
                xlWorkSheet.Cells[1, 14] = "FechaApertura";
                xlWorkSheet.Cells[1, 15] = "MesApertura";
                xlWorkSheet.Cells[1, 16] = "FechaRenovacion";
                xlWorkSheet.Cells[1, 17] = "MesRenovacion";
                xlWorkSheet.Cells[1, 18] = "FechaVencimiento";
                xlWorkSheet.Cells[1, 19] = "MesVencimiento";
                xlWorkSheet.Cells[1, 20] = "mSaldo";
                xlWorkSheet.Cells[1, 21] = "Tasa";
                xlWorkSheet.Cells[1, 22] = "NumeradorTasa";
                xlWorkSheet.Cells[1, 23] = "Plazo";
                xlWorkSheet.Cells[1, 24] = "PlazoActual";
                xlWorkSheet.Cells[1, 25] = "Numeradorplzpact";
                xlWorkSheet.Cells[1, 26] = "Numeradorplzact";
                xlWorkSheet.Cells[1, 27] = "SaldoDisponible";
                xlWorkSheet.Cells[1, 28] = "RUCEmpleador";
                xlWorkSheet.Cells[1, 29] = "CodTienda";
                xlWorkSheet.Cells[1, 30] = "DescTienda";
                xlWorkSheet.Cells[1, 31] = "MontoConvenio";
                xlWorkSheet.Cells[1, 32] = "DiaCargo";
                xlWorkSheet.Cells[1, 33] = "FecInicioConv";
                xlWorkSheet.Cells[1, 34] = "CuentaCMR";
                xlWorkSheet.Cells[1, 35] = "TarjetaCMR";
                xlWorkSheet.Cells[1, 36] = "CodigoEjecutivo";
                xlWorkSheet.Cells[1, 37] = "FlagCuentaSueldo";
                xlWorkSheet.Cells[1, 38] = "ClienteCMR";
                xlWorkSheet.Cells[1, 39] = "FlagMontoInversion";
                xlWorkSheet.Cells[1, 40] = "FlagSumaCondicion";
                xlWorkSheet.Cells[1, 41] = "FlagPizarra";
                xlWorkSheet.Cells[1, 42] = "Moneda";
                xlWorkSheet.Cells[1, 43] = "PlazoRedondeado";
                xlWorkSheet.Cells[1, 44] = "FlagProductoUnico";
                xlWorkSheet.Cells[1, 45] = "TasaVigenteDP";
                xlWorkSheet.Cells[1, 46] = "FlagCodProdNuevo";
                xlWorkSheet.Cells[1, 47] = "FlagDiferencia";

                xlWorkSheet.get_Range("A1", "AU1").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "AU1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                xlWorkSheet.get_Range("A1", "AU1").Font.Size = "10";

                
                DataTable dt = m_procesogestionDP.ReporteProcesoDP(conexion, objclsfrmBases.Producto.ToString());
                
                int rCnt = 0;
                int i = 0;
                decimal j = 0;

                for (rCnt = 2; rCnt <= dt.Rows.Count; rCnt++)
                {
                    xlWorkSheet.Cells[rCnt, 1].NumberFormat = "@";
                    xlWorkSheet.Cells[rCnt, 1] = dt.Rows[i]["codcategoria"].ToString();
                    xlWorkSheet.Cells[rCnt, 2] = dt.Rows[i]["categoria"].ToString();
                    xlWorkSheet.Cells[rCnt, 3] = dt.Rows[i]["codsubcategoria"].ToString();
                    xlWorkSheet.Cells[rCnt, 4] = dt.Rows[i]["subcategoria"].ToString();
                    xlWorkSheet.Cells[rCnt, 5] = dt.Rows[i]["cuenta"].ToString();
                    xlWorkSheet.Cells[rCnt, 6] = dt.Rows[i]["tipodocumento"].ToString();
                    xlWorkSheet.Cells[rCnt, 7].NumberFormat = "@";
                    xlWorkSheet.Cells[rCnt, 7] = dt.Rows[i]["numerodocumento"].ToString();
                    xlWorkSheet.Cells[rCnt, 8] = dt.Rows[i]["nombre"].ToString();
                    xlWorkSheet.Cells[rCnt, 9] = dt.Rows[i]["ejecutivo"].ToString();
                    xlWorkSheet.Cells[rCnt, 10] = dt.Rows[i]["estado"].ToString();
                    xlWorkSheet.Cells[rCnt, 11] = dt.Rows[i]["descestado"].ToString();
                    xlWorkSheet.Cells[rCnt, 12] = dt.Rows[i]["fecproceso"].ToString();
                    xlWorkSheet.Cells[rCnt, 13] = dt.Rows[i]["mesproceso"].ToString();
                    xlWorkSheet.Cells[rCnt, 14] = dt.Rows[i]["fecapertura"].ToString();
                    xlWorkSheet.Cells[rCnt, 15] = dt.Rows[i]["mesapertura"].ToString();
                    xlWorkSheet.Cells[rCnt, 16] = dt.Rows[i]["fecrenovacion"].ToString();
                    xlWorkSheet.Cells[rCnt, 17] = dt.Rows[i]["mesrenovacion"].ToString();
                    xlWorkSheet.Cells[rCnt, 18] = dt.Rows[i]["fecvencimiento"].ToString();
                    xlWorkSheet.Cells[rCnt, 19] = dt.Rows[i]["mesvencimiento"].ToString();
                    xlWorkSheet.Cells[rCnt, 20] = dt.Rows[i]["msaldo"].ToString();
                    xlWorkSheet.Cells[rCnt, 21] = dt.Rows[i]["tasa"].ToString();
                    xlWorkSheet.Cells[rCnt, 22] = dt.Rows[i]["numeradortasa"].ToString();
                    xlWorkSheet.Cells[rCnt, 23] = dt.Rows[i]["plazo"].ToString();
                    xlWorkSheet.Cells[rCnt, 24] = dt.Rows[i]["plazoactual"].ToString();
                    xlWorkSheet.Cells[rCnt, 25] = dt.Rows[i]["numeradorplzpact"].ToString();
                    xlWorkSheet.Cells[rCnt, 26] = dt.Rows[i]["numeradorplzact"].ToString();
                    xlWorkSheet.Cells[rCnt, 27] = dt.Rows[i]["saldodisponible"].ToString();
                    xlWorkSheet.Cells[rCnt, 28] = dt.Rows[i]["rucempleador"].ToString();
                    xlWorkSheet.Cells[rCnt, 29] = dt.Rows[i]["codtienda"].ToString();
                    xlWorkSheet.Cells[rCnt, 30] = dt.Rows[i]["desctienda"].ToString();
                    xlWorkSheet.Cells[rCnt, 31] = dt.Rows[i]["montoconvenio"].ToString();
                    xlWorkSheet.Cells[rCnt, 32] = dt.Rows[i]["diacargo"].ToString();
                    xlWorkSheet.Cells[rCnt, 33] = dt.Rows[i]["fecinicioconv"].ToString();
                    xlWorkSheet.Cells[rCnt, 34] = dt.Rows[i]["cuentacmr"].ToString();
                    xlWorkSheet.Cells[rCnt, 35] = dt.Rows[i]["tarjetacmr"].ToString();
                    xlWorkSheet.Cells[rCnt, 36] = dt.Rows[i]["codigoejecutivo"].ToString();
                    xlWorkSheet.Cells[rCnt, 37] = dt.Rows[i]["flagcuentasueldo"].ToString();
                    xlWorkSheet.Cells[rCnt, 38] = dt.Rows[i]["flagclienteCMR"].ToString();
                    xlWorkSheet.Cells[rCnt, 39] = dt.Rows[i]["flagmontoinversion"].ToString();
                    xlWorkSheet.Cells[rCnt, 40] = dt.Rows[i]["flagsumacondicion"].ToString();
                    xlWorkSheet.Cells[rCnt, 41] = dt.Rows[i]["flagpizarra"].ToString();
                    xlWorkSheet.Cells[rCnt, 42] = dt.Rows[i]["tipomoneda"].ToString();
                    xlWorkSheet.Cells[rCnt, 43] = dt.Rows[i]["plazoredondeado"].ToString();
                    xlWorkSheet.Cells[rCnt, 44] = dt.Rows[i]["flagproductounico"].ToString();
                    xlWorkSheet.Cells[rCnt, 45] = dt.Rows[i]["tasavigenteDP"].ToString();
                    xlWorkSheet.Cells[rCnt, 46] = dt.Rows[i]["flagcodprodnuevo"].ToString();
                    xlWorkSheet.Cells[rCnt, 47] = dt.Rows[i]["flagdiferencia"].ToString();

                    i++; j++;
                    porcentaje = Convert.ToInt32((j / dt.Rows.Count) * 100);
                    bw1.ReportProgress(porcentaje);
                }

                xlWorkSheet.Cells.Select();
                xlWorkSheet.Cells.EntireColumn.AutoFit();
                xlWorkSheet.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlWorkSheet.Cells[1, 1].Select();
                //xlWorkBook.SaveAs(strRuta, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.SaveAs(strRuta);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
                KillExcel();

                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonMenuReportes = true;
                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonExportar = true;
                objclsfrmBases.BotonSalir = true;
                objclsfrmBases.BotonBuscar = true;
                bw1.ReportProgress(100);

                MessageBox.Show("Reporte generado exitosamente.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                KillExcel();
                MessageBox.Show("Ocurrión un error al momento de generar el reporte: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                objclsfrmBases.BotonMenuProcesos = true;
                objclsfrmBases.BotonMenuReportes = true;
                objclsfrmBases.BotonMenuMantenimientos = true;
                objclsfrmBases.BotonExportar = true;
                objclsfrmBases.BotonSalir = true;
                bw1.ReportProgress(100);
            }
            }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                if (ex.Message!= "") obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
        private void KillExcel()
        {
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }
        private void bw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblmensajeproceso.Text = objclsfrmBases.MensajeProceso;

            if (e.ProgressPercentage == 0)
            {
                btnExportar.Enabled = false;
                btnBuscar.Enabled = false;
                btnSalir.Enabled = false;

                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
                ms.Items[0].Enabled = false;
                ms.Items[1].Enabled = false;
                ms.Items[2].Enabled = false;
            }

            if (e.ProgressPercentage == 100)
            {
                btnExportar.Enabled = objclsfrmBases.BotonExportar;
                btnBuscar.Enabled = objclsfrmBases.BotonBuscar;
                btnSalir.Enabled = objclsfrmBases.BotonSalir;

                Form frm = (Form)this.MdiParent;
                MenuStrip ms = (MenuStrip)frm.Controls["menuStrip"];
                ms.Items[0].Enabled = objclsfrmBases.BotonMenuMantenimientos;
                ms.Items[1].Enabled = objclsfrmBases.BotonMenuProcesos;
                ms.Items[2].Enabled = objclsfrmBases.BotonMenuReportes;

                lblmensajeproceso.Text = "";
                progressBar1.Value = 0;
            }
        }
        private void chktotal_CheckedChanged(object sender, EventArgs e)
        {
            if (chktotal.Checked == true) 
            {
                btnExportar.Enabled = true;
                btnExportar.Text = "Exportar CSV";
            }
            if (chktotal.Checked == false)
            {
                
                btnExportar.Text = "Exportar Excel";
            }
            
        }
      }
    }

