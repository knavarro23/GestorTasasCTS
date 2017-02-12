namespace MDIBFGestionTasasDP
{
    partial class frmReporteCargaCTS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblproducto = new System.Windows.Forms.Label();
            this.ddlproducto = new System.Windows.Forms.ComboBox();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gvprocesosCTS = new System.Windows.Forms.DataGridView();
            this.chktotal = new System.Windows.Forms.CheckBox();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 410);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(898, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 63;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(217, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 62;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(116, 373);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(95, 23);
            this.btnExportar.TabIndex = 61;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(15, 50);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(53, 13);
            this.lblproducto.TabIndex = 60;
            this.lblproducto.Text = "Producto:";
            // 
            // ddlproducto
            // 
            this.ddlproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlproducto.FormattingEnabled = true;
            this.ddlproducto.Location = new System.Drawing.Point(122, 47);
            this.ddlproducto.Name = "ddlproducto";
            this.ddlproducto.Size = new System.Drawing.Size(237, 21);
            this.ddlproducto.TabIndex = 59;
            // 
            // ddltipoproducto
            // 
            this.ddltipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto.FormattingEnabled = true;
            this.ddltipoproducto.Location = new System.Drawing.Point(122, 11);
            this.ddltipoproducto.Name = "ddltipoproducto";
            this.ddltipoproducto.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto.TabIndex = 58;
            this.ddltipoproducto.SelectedIndexChanged += new System.EventHandler(this.ddltipoproducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tipo de producto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvprocesosCTS
            // 
            this.gvprocesosCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprocesosCTS.Location = new System.Drawing.Point(12, 111);
            this.gvprocesosCTS.MultiSelect = false;
            this.gvprocesosCTS.Name = "gvprocesosCTS";
            this.gvprocesosCTS.ReadOnly = true;
            this.gvprocesosCTS.Size = new System.Drawing.Size(898, 250);
            this.gvprocesosCTS.TabIndex = 55;
            // 
            // chktotal
            // 
            this.chktotal.AutoSize = true;
            this.chktotal.Location = new System.Drawing.Point(12, 376);
            this.chktotal.Name = "chktotal";
            this.chktotal.Size = new System.Drawing.Size(98, 17);
            this.chktotal.TabIndex = 64;
            this.chktotal.Text = "Exportar Todos";
            this.chktotal.UseVisualStyleBackColor = true;
            this.chktotal.CheckedChanged += new System.EventHandler(this.chktotal_CheckedChanged);
            // 
            // bw1
            // 
            this.bw1.WorkerReportsProgress = true;
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            this.bw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw1_ProgressChanged);
            // 
            // lblmensajeproceso
            // 
            this.lblmensajeproceso.AutoSize = true;
            this.lblmensajeproceso.Location = new System.Drawing.Point(339, 379);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 65;
            // 
            // frmReporteCargaCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 444);
            this.Controls.Add(this.lblmensajeproceso);
            this.Controls.Add(this.chktotal);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.ddlproducto);
            this.Controls.Add(this.ddltipoproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvprocesosCTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmReporteCargaCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES CARGA CTS";
            this.Load += new System.EventHandler(this.frmReporteCargaCTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.ComboBox ddlproducto;
        private System.Windows.Forms.ComboBox ddltipoproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvprocesosCTS;
        private System.Windows.Forms.CheckBox chktotal;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.Label lblmensajeproceso;
    }
}