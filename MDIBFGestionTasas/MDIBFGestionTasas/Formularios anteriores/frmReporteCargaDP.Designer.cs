namespace MDIBFGestionTasasDP
{
    partial class frmReporteCargaDP
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
            this.gvprocesosDP = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.lblproducto = new System.Windows.Forms.Label();
            this.ddlproducto = new System.Windows.Forms.ComboBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            this.chktotal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosDP)).BeginInit();
            this.SuspendLayout();
            // 
            // gvprocesosDP
            // 
            this.gvprocesosDP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprocesosDP.Location = new System.Drawing.Point(12, 110);
            this.gvprocesosDP.MultiSelect = false;
            this.gvprocesosDP.Name = "gvprocesosDP";
            this.gvprocesosDP.ReadOnly = true;
            this.gvprocesosDP.Size = new System.Drawing.Size(898, 250);
            this.gvprocesosDP.TabIndex = 41;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 81);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tipo de producto:";
            // 
            // ddltipoproducto
            // 
            this.ddltipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto.FormattingEnabled = true;
            this.ddltipoproducto.Location = new System.Drawing.Point(122, 10);
            this.ddltipoproducto.Name = "ddltipoproducto";
            this.ddltipoproducto.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto.TabIndex = 44;
            this.ddltipoproducto.SelectedIndexChanged += new System.EventHandler(this.ddltipoproducto_SelectedIndexChanged);
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(15, 49);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(53, 13);
            this.lblproducto.TabIndex = 46;
            this.lblproducto.Text = "Producto:";
            // 
            // ddlproducto
            // 
            this.ddlproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlproducto.FormattingEnabled = true;
            this.ddlproducto.Location = new System.Drawing.Point(122, 46);
            this.ddlproducto.Name = "ddlproducto";
            this.ddlproducto.Size = new System.Drawing.Size(237, 21);
            this.ddlproducto.TabIndex = 45;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(140, 369);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(95, 23);
            this.btnExportar.TabIndex = 47;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(241, 369);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 53;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 409);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(898, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 54;
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
            this.lblmensajeproceso.Location = new System.Drawing.Point(349, 374);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 55;
            // 
            // chktotal
            // 
            this.chktotal.AutoSize = true;
            this.chktotal.Location = new System.Drawing.Point(12, 373);
            this.chktotal.Name = "chktotal";
            this.chktotal.Size = new System.Drawing.Size(98, 17);
            this.chktotal.TabIndex = 56;
            this.chktotal.Text = "Exportar Todos";
            this.chktotal.UseVisualStyleBackColor = true;
            this.chktotal.CheckedChanged += new System.EventHandler(this.chktotal_CheckedChanged);
            // 
            // frmReporteCargaDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(922, 444);
            this.Controls.Add(this.chktotal);
            this.Controls.Add(this.lblmensajeproceso);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblproducto);
            this.Controls.Add(this.ddlproducto);
            this.Controls.Add(this.ddltipoproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gvprocesosDP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmReporteCargaDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTES CARGA DEPÓSITO A PLAZO (DP)";
            this.Load += new System.EventHandler(this.frmReporteCargaDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosDP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvprocesosDP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddltipoproducto;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.ComboBox ddlproducto;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.Label lblmensajeproceso;
        private System.Windows.Forms.CheckBox chktotal;
    }
}