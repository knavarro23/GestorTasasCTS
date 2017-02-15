namespace MDIBFGestionTasas.Formularios
{
    partial class FrmCargaStockBF
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
            this.pntotal = new System.Windows.Forms.Panel();
            this.txtproceso = new System.Windows.Forms.TextBox();
            this.lblproceso = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblfechacarga23 = new System.Windows.Forms.Label();
            this.lblfechacarga = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txttipocambio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gvlistado = new System.Windows.Forms.DataGridView();
            this.lbllog = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pntotal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistado)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pntotal
            // 
            this.pntotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pntotal.Controls.Add(this.txtproceso);
            this.pntotal.Controls.Add(this.lblproceso);
            this.pntotal.Controls.Add(this.btnAgregar);
            this.pntotal.Location = new System.Drawing.Point(17, 46);
            this.pntotal.Name = "pntotal";
            this.pntotal.Size = new System.Drawing.Size(820, 46);
            this.pntotal.TabIndex = 92;
            // 
            // txtproceso
            // 
            this.txtproceso.Enabled = false;
            this.txtproceso.Location = new System.Drawing.Point(164, 15);
            this.txtproceso.Name = "txtproceso";
            this.txtproceso.Size = new System.Drawing.Size(539, 20);
            this.txtproceso.TabIndex = 1;
            // 
            // lblproceso
            // 
            this.lblproceso.AutoSize = true;
            this.lblproceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproceso.Location = new System.Drawing.Point(7, 15);
            this.lblproceso.Name = "lblproceso";
            this.lblproceso.Size = new System.Drawing.Size(151, 13);
            this.lblproceso.TabIndex = 67;
            this.lblproceso.Text = "Stock BF para DP / CTS:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(729, 10);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarDP_Click);
            // 
            // lblfechacarga23
            // 
            this.lblfechacarga23.AutoSize = true;
            this.lblfechacarga23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfechacarga23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacarga23.Location = new System.Drawing.Point(677, 15);
            this.lblfechacarga23.Name = "lblfechacarga23";
            this.lblfechacarga23.Size = new System.Drawing.Size(2, 15);
            this.lblfechacarga23.TabIndex = 91;
            // 
            // lblfechacarga
            // 
            this.lblfechacarga.AutoSize = true;
            this.lblfechacarga.Location = new System.Drawing.Point(586, 15);
            this.lblfechacarga.Name = "lblfechacarga";
            this.lblfechacarga.Size = new System.Drawing.Size(74, 13);
            this.lblfechacarga.TabIndex = 90;
            this.lblfechacarga.Text = "Fecha y Hora:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txttipocambio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 46);
            this.panel1.TabIndex = 93;
            // 
            // txttipocambio
            // 
            this.txttipocambio.Location = new System.Drawing.Point(164, 12);
            this.txttipocambio.MaxLength = 10;
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.Size = new System.Drawing.Size(79, 20);
            this.txttipocambio.TabIndex = 1;
            this.txttipocambio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttipocambio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tipo de cambio SOLES:";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(592, 194);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 94;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(762, 194);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 95;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // gvlistado
            // 
            this.gvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvlistado.Location = new System.Drawing.Point(17, 297);
            this.gvlistado.MultiSelect = false;
            this.gvlistado.Name = "gvlistado";
            this.gvlistado.ReadOnly = true;
            this.gvlistado.Size = new System.Drawing.Size(395, 111);
            this.gvlistado.TabIndex = 99;
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(19, 269);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(88, 13);
            this.lbllog.TabIndex = 98;
            this.lbllog.Text = "Log Stock BF:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(673, 194);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 23);
            this.btnLimpiar.TabIndex = 96;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 232);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(820, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 97;
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
            this.lblmensajeproceso.Location = new System.Drawing.Point(11, 216);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 100;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.gvlistado);
            this.metroPanel1.Controls.Add(this.pntotal);
            this.metroPanel1.Controls.Add(this.lbllog);
            this.metroPanel1.Controls.Add(this.lblfechacarga);
            this.metroPanel1.Controls.Add(this.btnLimpiar);
            this.metroPanel1.Controls.Add(this.lblfechacarga23);
            this.metroPanel1.Controls.Add(this.progressBar1);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.btnSalir);
            this.metroPanel1.Controls.Add(this.btnProcesar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(14, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(855, 422);
            this.metroPanel1.TabIndex = 101;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // FrmCargaStockBF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 497);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblmensajeproceso);
            this.Name = "FrmCargaStockBF";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Carga Stock BF";
            this.Load += new System.EventHandler(this.frmCargaStockBF_Load);
            this.pntotal.ResumeLayout(false);
            this.pntotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistado)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntotal;
        private System.Windows.Forms.TextBox txtproceso;
        private System.Windows.Forms.Label lblproceso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblfechacarga23;
        private System.Windows.Forms.Label lblfechacarga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txttipocambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView gvlistado;
        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label lblmensajeproceso;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}