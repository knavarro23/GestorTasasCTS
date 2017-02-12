namespace MDIBFGestionTasas
{
    partial class frmProcesoCargaCTS
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
            this.lblcts = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtcuentasueldoCTS = new System.Windows.Forms.TextBox();
            this.txtdatoscontactoCTS = new System.Windows.Forms.TextBox();
            this.lblcuentasueldoCTS = new System.Windows.Forms.Label();
            this.lbldatoscontactoCTS = new System.Windows.Forms.Label();
            this.btnDatosContactoCTS = new System.Windows.Forms.Button();
            this.txtmigracionCuentaCTS = new System.Windows.Forms.TextBox();
            this.btncuentasueldoCTS = new System.Windows.Forms.Button();
            this.lblmigracionCuentaCTS = new System.Windows.Forms.Label();
            this.btnmigracionCuentaCTS = new System.Windows.Forms.Button();
            this.txtabonoQuintaCTS = new System.Windows.Forms.TextBox();
            this.lblabonoQuintaCTS = new System.Windows.Forms.Label();
            this.btnabonoQuintaCTS = new System.Windows.Forms.Button();
            this.txtabono360CTS = new System.Windows.Forms.TextBox();
            this.lblabono360CTS = new System.Windows.Forms.Label();
            this.btnabono360CTS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chktotal = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.gvprocesosCTS = new System.Windows.Forms.DataGridView();
            this.lblproducto = new System.Windows.Forms.Label();
            this.ddlproducto = new System.Windows.Forms.ComboBox();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.sfd1 = new System.Windows.Forms.SaveFileDialog();
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcts
            // 
            this.lblcts.AutoSize = true;
            this.lblcts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcts.Location = new System.Drawing.Point(3, 9);
            this.lblcts.Name = "lblcts";
            this.lblcts.Size = new System.Drawing.Size(195, 13);
            this.lblcts.TabIndex = 93;
            this.lblcts.Text = "Carga de archivos auxiliares CTS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.btnProcesar);
            this.panel1.Controls.Add(this.txtcuentasueldoCTS);
            this.panel1.Controls.Add(this.txtdatoscontactoCTS);
            this.panel1.Controls.Add(this.lblcuentasueldoCTS);
            this.panel1.Controls.Add(this.lbldatoscontactoCTS);
            this.panel1.Controls.Add(this.btnDatosContactoCTS);
            this.panel1.Controls.Add(this.txtmigracionCuentaCTS);
            this.panel1.Controls.Add(this.btncuentasueldoCTS);
            this.panel1.Controls.Add(this.lblmigracionCuentaCTS);
            this.panel1.Controls.Add(this.btnmigracionCuentaCTS);
            this.panel1.Controls.Add(this.txtabonoQuintaCTS);
            this.panel1.Controls.Add(this.lblabonoQuintaCTS);
            this.panel1.Controls.Add(this.btnabonoQuintaCTS);
            this.panel1.Controls.Add(this.txtabono360CTS);
            this.panel1.Controls.Add(this.lblabono360CTS);
            this.panel1.Controls.Add(this.btnabono360CTS);
            this.panel1.Location = new System.Drawing.Point(6, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 227);
            this.panel1.TabIndex = 92;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(143, 190);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(674, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 120;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(13, 190);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 11;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            // 
            // txtcuentasueldoCTS
            // 
            this.txtcuentasueldoCTS.Enabled = false;
            this.txtcuentasueldoCTS.Location = new System.Drawing.Point(143, 22);
            this.txtcuentasueldoCTS.Name = "txtcuentasueldoCTS";
            this.txtcuentasueldoCTS.Size = new System.Drawing.Size(586, 20);
            this.txtcuentasueldoCTS.TabIndex = 1;
            // 
            // txtdatoscontactoCTS
            // 
            this.txtdatoscontactoCTS.Enabled = false;
            this.txtdatoscontactoCTS.Location = new System.Drawing.Point(143, 150);
            this.txtdatoscontactoCTS.Name = "txtdatoscontactoCTS";
            this.txtdatoscontactoCTS.Size = new System.Drawing.Size(586, 20);
            this.txtdatoscontactoCTS.TabIndex = 9;
            // 
            // lblcuentasueldoCTS
            // 
            this.lblcuentasueldoCTS.AutoSize = true;
            this.lblcuentasueldoCTS.Location = new System.Drawing.Point(10, 29);
            this.lblcuentasueldoCTS.Name = "lblcuentasueldoCTS";
            this.lblcuentasueldoCTS.Size = new System.Drawing.Size(104, 13);
            this.lblcuentasueldoCTS.TabIndex = 3;
            this.lblcuentasueldoCTS.Text = "Cuenta Sueldo CTS:";
            // 
            // lbldatoscontactoCTS
            // 
            this.lbldatoscontactoCTS.AutoSize = true;
            this.lbldatoscontactoCTS.Location = new System.Drawing.Point(11, 151);
            this.lbldatoscontactoCTS.Name = "lbldatoscontactoCTS";
            this.lbldatoscontactoCTS.Size = new System.Drawing.Size(108, 13);
            this.lbldatoscontactoCTS.TabIndex = 118;
            this.lbldatoscontactoCTS.Text = "Datos Contacto CTS:";
            // 
            // btnDatosContactoCTS
            // 
            this.btnDatosContactoCTS.Location = new System.Drawing.Point(756, 148);
            this.btnDatosContactoCTS.Name = "btnDatosContactoCTS";
            this.btnDatosContactoCTS.Size = new System.Drawing.Size(61, 23);
            this.btnDatosContactoCTS.TabIndex = 10;
            this.btnDatosContactoCTS.Text = "Agregar";
            this.btnDatosContactoCTS.UseVisualStyleBackColor = true;
            // 
            // txtmigracionCuentaCTS
            // 
            this.txtmigracionCuentaCTS.Enabled = false;
            this.txtmigracionCuentaCTS.Location = new System.Drawing.Point(143, 114);
            this.txtmigracionCuentaCTS.Name = "txtmigracionCuentaCTS";
            this.txtmigracionCuentaCTS.Size = new System.Drawing.Size(586, 20);
            this.txtmigracionCuentaCTS.TabIndex = 7;
            // 
            // btncuentasueldoCTS
            // 
            this.btncuentasueldoCTS.Location = new System.Drawing.Point(756, 19);
            this.btncuentasueldoCTS.Name = "btncuentasueldoCTS";
            this.btncuentasueldoCTS.Size = new System.Drawing.Size(61, 23);
            this.btncuentasueldoCTS.TabIndex = 2;
            this.btncuentasueldoCTS.Text = "Agregar";
            this.btncuentasueldoCTS.UseVisualStyleBackColor = true;
            // 
            // lblmigracionCuentaCTS
            // 
            this.lblmigracionCuentaCTS.AutoSize = true;
            this.lblmigracionCuentaCTS.Location = new System.Drawing.Point(10, 117);
            this.lblmigracionCuentaCTS.Name = "lblmigracionCuentaCTS";
            this.lblmigracionCuentaCTS.Size = new System.Drawing.Size(117, 13);
            this.lblmigracionCuentaCTS.TabIndex = 113;
            this.lblmigracionCuentaCTS.Text = "Migración Cuenta CTS:";
            // 
            // btnmigracionCuentaCTS
            // 
            this.btnmigracionCuentaCTS.Location = new System.Drawing.Point(756, 113);
            this.btnmigracionCuentaCTS.Name = "btnmigracionCuentaCTS";
            this.btnmigracionCuentaCTS.Size = new System.Drawing.Size(61, 23);
            this.btnmigracionCuentaCTS.TabIndex = 8;
            this.btnmigracionCuentaCTS.Text = "Agregar";
            this.btnmigracionCuentaCTS.UseVisualStyleBackColor = true;
            // 
            // txtabonoQuintaCTS
            // 
            this.txtabonoQuintaCTS.Enabled = false;
            this.txtabonoQuintaCTS.Location = new System.Drawing.Point(143, 51);
            this.txtabonoQuintaCTS.Name = "txtabonoQuintaCTS";
            this.txtabonoQuintaCTS.Size = new System.Drawing.Size(586, 20);
            this.txtabonoQuintaCTS.TabIndex = 3;
            // 
            // lblabonoQuintaCTS
            // 
            this.lblabonoQuintaCTS.AutoSize = true;
            this.lblabonoQuintaCTS.Location = new System.Drawing.Point(10, 56);
            this.lblabonoQuintaCTS.Name = "lblabonoQuintaCTS";
            this.lblabonoQuintaCTS.Size = new System.Drawing.Size(99, 13);
            this.lblabonoQuintaCTS.TabIndex = 111;
            this.lblabonoQuintaCTS.Text = "Abono Quinta CTS:";
            // 
            // btnabonoQuintaCTS
            // 
            this.btnabonoQuintaCTS.Location = new System.Drawing.Point(756, 48);
            this.btnabonoQuintaCTS.Name = "btnabonoQuintaCTS";
            this.btnabonoQuintaCTS.Size = new System.Drawing.Size(61, 23);
            this.btnabonoQuintaCTS.TabIndex = 4;
            this.btnabonoQuintaCTS.Text = "Agregar";
            this.btnabonoQuintaCTS.UseVisualStyleBackColor = true;
            // 
            // txtabono360CTS
            // 
            this.txtabono360CTS.Enabled = false;
            this.txtabono360CTS.Location = new System.Drawing.Point(143, 82);
            this.txtabono360CTS.Name = "txtabono360CTS";
            this.txtabono360CTS.Size = new System.Drawing.Size(586, 20);
            this.txtabono360CTS.TabIndex = 5;
            // 
            // lblabono360CTS
            // 
            this.lblabono360CTS.AutoSize = true;
            this.lblabono360CTS.Location = new System.Drawing.Point(10, 86);
            this.lblabono360CTS.Name = "lblabono360CTS";
            this.lblabono360CTS.Size = new System.Drawing.Size(110, 13);
            this.lblabono360CTS.TabIndex = 109;
            this.lblabono360CTS.Text = "Abono 360 días CTS:";
            // 
            // btnabono360CTS
            // 
            this.btnabono360CTS.Location = new System.Drawing.Point(756, 81);
            this.btnabono360CTS.Name = "btnabono360CTS";
            this.btnabono360CTS.Size = new System.Drawing.Size(61, 23);
            this.btnabono360CTS.TabIndex = 6;
            this.btnabono360CTS.Text = "Agregar";
            this.btnabono360CTS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chktotal);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnExportar);
            this.panel2.Controls.Add(this.gvprocesosCTS);
            this.panel2.Controls.Add(this.lblproducto);
            this.panel2.Controls.Add(this.ddlproducto);
            this.panel2.Controls.Add(this.ddltipoproducto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Location = new System.Drawing.Point(6, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 241);
            this.panel2.TabIndex = 121;
            // 
            // chktotal
            // 
            this.chktotal.AutoSize = true;
            this.chktotal.Location = new System.Drawing.Point(13, 211);
            this.chktotal.Name = "chktotal";
            this.chktotal.Size = new System.Drawing.Size(98, 17);
            this.chktotal.TabIndex = 16;
            this.chktotal.Text = "Exportar Todos";
            this.chktotal.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(117, 208);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(95, 23);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // gvprocesosCTS
            // 
            this.gvprocesosCTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvprocesosCTS.Location = new System.Drawing.Point(13, 72);
            this.gvprocesosCTS.MultiSelect = false;
            this.gvprocesosCTS.Name = "gvprocesosCTS";
            this.gvprocesosCTS.ReadOnly = true;
            this.gvprocesosCTS.Size = new System.Drawing.Size(803, 124);
            this.gvprocesosCTS.TabIndex = 66;
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(511, 16);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(53, 13);
            this.lblproducto.TabIndex = 65;
            this.lblproducto.Text = "Producto:";
            // 
            // ddlproducto
            // 
            this.ddlproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlproducto.FormattingEnabled = true;
            this.ddlproducto.Location = new System.Drawing.Point(580, 13);
            this.ddlproducto.Name = "ddlproducto";
            this.ddlproducto.Size = new System.Drawing.Size(237, 21);
            this.ddlproducto.TabIndex = 13;
            // 
            // ddltipoproducto
            // 
            this.ddltipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto.FormattingEnabled = true;
            this.ddltipoproducto.Location = new System.Drawing.Point(143, 10);
            this.ddltipoproducto.Name = "ddltipoproducto";
            this.ddltipoproducto.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Tipo de producto:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(13, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // bw1
            // 
            this.bw1.WorkerReportsProgress = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Reporte CTS";
            // 
            // lblmensajeproceso
            // 
            this.lblmensajeproceso.AutoSize = true;
            this.lblmensajeproceso.Location = new System.Drawing.Point(147, 276);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 123;
            // 
            // frmProcesoCargaCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(864, 558);
            this.Controls.Add(this.lblmensajeproceso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblcts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProcesoCargaCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga y Reporte CTS";
            this.Load += new System.EventHandler(this.frmProcesoCargaCTS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvprocesosCTS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtcuentasueldoCTS;
        private System.Windows.Forms.TextBox txtdatoscontactoCTS;
        private System.Windows.Forms.Label lblcuentasueldoCTS;
        private System.Windows.Forms.Label lbldatoscontactoCTS;
        private System.Windows.Forms.Button btnDatosContactoCTS;
        private System.Windows.Forms.TextBox txtmigracionCuentaCTS;
        private System.Windows.Forms.Button btncuentasueldoCTS;
        private System.Windows.Forms.Label lblmigracionCuentaCTS;
        private System.Windows.Forms.Button btnmigracionCuentaCTS;
        private System.Windows.Forms.TextBox txtabonoQuintaCTS;
        private System.Windows.Forms.Label lblabonoQuintaCTS;
        private System.Windows.Forms.Button btnabonoQuintaCTS;
        private System.Windows.Forms.TextBox txtabono360CTS;
        private System.Windows.Forms.Label lblabono360CTS;
        private System.Windows.Forms.Button btnabono360CTS;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.ComboBox ddlproducto;
        private System.Windows.Forms.ComboBox ddltipoproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvprocesosCTS;
        private System.Windows.Forms.CheckBox chktotal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog sfd1;
        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmensajeproceso;
    }
}