namespace MDIBFGestionTasas
{
    partial class frmProcesoCargaDP
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
            this.lbldp = new System.Windows.Forms.Label();
            this.pnDP = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteCMRDP = new System.Windows.Forms.TextBox();
            this.lblClienteCMR = new System.Windows.Forms.Label();
            this.btnClienteCMRDP = new System.Windows.Forms.Button();
            this.txtCuentaSueldoDP = new System.Windows.Forms.TextBox();
            this.lblcuentasueldo = new System.Windows.Forms.Label();
            this.btnCuentaSueldoDP = new System.Windows.Forms.Button();
            this.lblreporteDP = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chktotal = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gvprocesosCTS = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblproducto = new System.Windows.Forms.Label();
            this.ddlproducto = new System.Windows.Forms.ComboBox();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.pnDP.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldp
            // 
            this.lbldp.AutoSize = true;
            this.lbldp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldp.Location = new System.Drawing.Point(12, 9);
            this.lbldp.Name = "lbldp";
            this.lbldp.Size = new System.Drawing.Size(188, 13);
            this.lbldp.TabIndex = 94;
            this.lbldp.Text = "Carga de archivos auxiliares DP";
            // 
            // pnDP
            // 
            this.pnDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDP.Controls.Add(this.btnLimpiar);
            this.pnDP.Controls.Add(this.progressBar1);
            this.pnDP.Controls.Add(this.btnProcesar);
            this.pnDP.Controls.Add(this.label1);
            this.pnDP.Controls.Add(this.txtClienteCMRDP);
            this.pnDP.Controls.Add(this.lblClienteCMR);
            this.pnDP.Controls.Add(this.btnClienteCMRDP);
            this.pnDP.Controls.Add(this.txtCuentaSueldoDP);
            this.pnDP.Controls.Add(this.lblcuentasueldo);
            this.pnDP.Controls.Add(this.btnCuentaSueldoDP);
            this.pnDP.Location = new System.Drawing.Point(12, 38);
            this.pnDP.Name = "pnDP";
            this.pnDP.Size = new System.Drawing.Size(831, 110);
            this.pnDP.TabIndex = 95;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(304, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(513, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 124;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(143, 74);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 123;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Cuenta Sueldo DP:";
            // 
            // txtClienteCMRDP
            // 
            this.txtClienteCMRDP.Enabled = false;
            this.txtClienteCMRDP.Location = new System.Drawing.Point(143, 45);
            this.txtClienteCMRDP.Name = "txtClienteCMRDP";
            this.txtClienteCMRDP.Size = new System.Drawing.Size(586, 20);
            this.txtClienteCMRDP.TabIndex = 5;
            // 
            // lblClienteCMR
            // 
            this.lblClienteCMR.AutoSize = true;
            this.lblClienteCMR.Location = new System.Drawing.Point(10, 45);
            this.lblClienteCMR.Name = "lblClienteCMR";
            this.lblClienteCMR.Size = new System.Drawing.Size(87, 13);
            this.lblClienteCMR.TabIndex = 73;
            this.lblClienteCMR.Text = "Cliente CMR DP:";
            // 
            // btnClienteCMRDP
            // 
            this.btnClienteCMRDP.Location = new System.Drawing.Point(756, 45);
            this.btnClienteCMRDP.Name = "btnClienteCMRDP";
            this.btnClienteCMRDP.Size = new System.Drawing.Size(61, 23);
            this.btnClienteCMRDP.TabIndex = 6;
            this.btnClienteCMRDP.Text = "Agregar";
            this.btnClienteCMRDP.UseVisualStyleBackColor = true;
            // 
            // txtCuentaSueldoDP
            // 
            this.txtCuentaSueldoDP.Enabled = false;
            this.txtCuentaSueldoDP.Location = new System.Drawing.Point(143, 15);
            this.txtCuentaSueldoDP.Name = "txtCuentaSueldoDP";
            this.txtCuentaSueldoDP.Size = new System.Drawing.Size(586, 20);
            this.txtCuentaSueldoDP.TabIndex = 3;
            // 
            // lblcuentasueldo
            // 
            this.lblcuentasueldo.AutoSize = true;
            this.lblcuentasueldo.Location = new System.Drawing.Point(-188, 44);
            this.lblcuentasueldo.Name = "lblcuentasueldo";
            this.lblcuentasueldo.Size = new System.Drawing.Size(80, 13);
            this.lblcuentasueldo.TabIndex = 70;
            this.lblcuentasueldo.Text = "Cuenta Sueldo:";
            // 
            // btnCuentaSueldoDP
            // 
            this.btnCuentaSueldoDP.Location = new System.Drawing.Point(756, 14);
            this.btnCuentaSueldoDP.Name = "btnCuentaSueldoDP";
            this.btnCuentaSueldoDP.Size = new System.Drawing.Size(61, 23);
            this.btnCuentaSueldoDP.TabIndex = 4;
            this.btnCuentaSueldoDP.Text = "Agregar";
            this.btnCuentaSueldoDP.UseVisualStyleBackColor = true;
            // 
            // lblreporteDP
            // 
            this.lblreporteDP.AutoSize = true;
            this.lblreporteDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreporteDP.Location = new System.Drawing.Point(12, 162);
            this.lblreporteDP.Name = "lblreporteDP";
            this.lblreporteDP.Size = new System.Drawing.Size(73, 13);
            this.lblreporteDP.TabIndex = 123;
            this.lblreporteDP.Text = "Reporte DP";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(254, 226);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 124;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chktotal);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.gvprocesosCTS);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblproducto);
            this.panel2.Controls.Add(this.ddlproducto);
            this.panel2.Controls.Add(this.ddltipoproducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 216);
            this.panel2.TabIndex = 129;
            // 
            // chktotal
            // 
            this.chktotal.AutoSize = true;
            this.chktotal.Location = new System.Drawing.Point(13, 190);
            this.chktotal.Name = "chktotal";
            this.chktotal.Size = new System.Drawing.Size(98, 17);
            this.chktotal.TabIndex = 134;
            this.chktotal.Text = "Exportar Todos";
            this.chktotal.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 187);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 136;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(117, 187);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(95, 23);
            this.btnExportar.TabIndex = 135;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // gvprocesosCTS
            // 
            this.gvprocesosCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprocesosCTS.Location = new System.Drawing.Point(13, 51);
            this.gvprocesosCTS.MultiSelect = false;
            this.gvprocesosCTS.Name = "gvprocesosCTS";
            this.gvprocesosCTS.ReadOnly = true;
            this.gvprocesosCTS.Size = new System.Drawing.Size(803, 124);
            this.gvprocesosCTS.TabIndex = 137;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, -23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 133;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(500, 15);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(53, 13);
            this.lblproducto.TabIndex = 132;
            this.lblproducto.Text = "Producto:";
            // 
            // ddlproducto
            // 
            this.ddlproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlproducto.FormattingEnabled = true;
            this.ddlproducto.Location = new System.Drawing.Point(580, 15);
            this.ddlproducto.Name = "ddlproducto";
            this.ddlproducto.Size = new System.Drawing.Size(237, 21);
            this.ddlproducto.TabIndex = 131;
            // 
            // ddltipoproducto
            // 
            this.ddltipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto.FormattingEnabled = true;
            this.ddltipoproducto.Location = new System.Drawing.Point(143, 12);
            this.ddltipoproducto.Name = "ddltipoproducto";
            this.ddltipoproducto.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "Tipo de producto:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(223, 74);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 125;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblmensajeproceso
            // 
            this.lblmensajeproceso.AutoSize = true;
            this.lblmensajeproceso.Location = new System.Drawing.Point(153, 162);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 130;
            // 
            // bw1
            // 
            this.bw1.WorkerReportsProgress = true;
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            // 
            // frmProcesoCargaDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 416);
            this.Controls.Add(this.lblmensajeproceso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblreporteDP);
            this.Controls.Add(this.pnDP);
            this.Controls.Add(this.lbldp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProcesoCargaDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga y Reporte DP";
            this.pnDP.ResumeLayout(false);
            this.pnDP.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldp;
        private System.Windows.Forms.Panel pnDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteCMRDP;
        private System.Windows.Forms.Label lblClienteCMR;
        private System.Windows.Forms.Button btnClienteCMRDP;
        private System.Windows.Forms.TextBox txtCuentaSueldoDP;
        private System.Windows.Forms.Label lblcuentasueldo;
        private System.Windows.Forms.Button btnCuentaSueldoDP;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblreporteDP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.ComboBox ddlproducto;
        private System.Windows.Forms.ComboBox ddltipoproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chktotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView gvprocesosCTS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblmensajeproceso;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}