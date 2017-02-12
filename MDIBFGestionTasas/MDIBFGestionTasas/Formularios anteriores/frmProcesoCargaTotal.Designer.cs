namespace MDIBFGestionTasasDP
{
    partial class frmProcesoCargaTotal
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
            this.bw1 = new System.ComponentModel.BackgroundWorker();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblresponsable = new System.Windows.Forms.Label();
            this.ddlresponsable = new System.Windows.Forms.ComboBox();
            this.lblmensajeproceso = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.pnDP = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteCMRDP = new System.Windows.Forms.TextBox();
            this.lblClienteCMR = new System.Windows.Forms.Label();
            this.btnClienteCMRDP = new System.Windows.Forms.Button();
            this.txtCuentaSueldoDP = new System.Windows.Forms.TextBox();
            this.lblcuentasueldo = new System.Windows.Forms.Label();
            this.btnCuentaSueldoDP = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gvlistado = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pntotal = new System.Windows.Forms.Panel();
            this.txtprocesoDP = new System.Windows.Forms.TextBox();
            this.lblproceso = new System.Windows.Forms.Label();
            this.btnAgregarDP = new System.Windows.Forms.Button();
            this.lblfechacarga23 = new System.Windows.Forms.Label();
            this.lblfechacarga = new System.Windows.Forms.Label();
            this.pnDP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistado)).BeginInit();
            this.pntotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // bw1
            // 
            this.bw1.WorkerReportsProgress = true;
            this.bw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw1_DoWork);
            this.bw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw1_ProgressChanged);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(12, 395);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 17;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 424);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(831, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 50;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(271, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblresponsable
            // 
            this.lblresponsable.AutoSize = true;
            this.lblresponsable.Location = new System.Drawing.Point(12, 18);
            this.lblresponsable.Name = "lblresponsable";
            this.lblresponsable.Size = new System.Drawing.Size(72, 13);
            this.lblresponsable.TabIndex = 57;
            this.lblresponsable.Text = "Responsable:";
            // 
            // ddlresponsable
            // 
            this.ddlresponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlresponsable.FormattingEnabled = true;
            this.ddlresponsable.Location = new System.Drawing.Point(114, 13);
            this.ddlresponsable.Name = "ddlresponsable";
            this.ddlresponsable.Size = new System.Drawing.Size(199, 21);
            this.ddlresponsable.TabIndex = 0;
            // 
            // lblmensajeproceso
            // 
            this.lblmensajeproceso.AutoSize = true;
            this.lblmensajeproceso.Location = new System.Drawing.Point(372, 400);
            this.lblmensajeproceso.Name = "lblmensajeproceso";
            this.lblmensajeproceso.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeproceso.TabIndex = 64;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 395);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 23);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // pnDP
            // 
            this.pnDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDP.Controls.Add(this.label1);
            this.pnDP.Controls.Add(this.txtClienteCMRDP);
            this.pnDP.Controls.Add(this.lblClienteCMR);
            this.pnDP.Controls.Add(this.btnClienteCMRDP);
            this.pnDP.Controls.Add(this.txtCuentaSueldoDP);
            this.pnDP.Controls.Add(this.lblcuentasueldo);
            this.pnDP.Controls.Add(this.btnCuentaSueldoDP);
            this.pnDP.Location = new System.Drawing.Point(12, 115);
            this.pnDP.Name = "pnDP";
            this.pnDP.Size = new System.Drawing.Size(831, 79);
            this.pnDP.TabIndex = 88;
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
            this.btnClienteCMRDP.Click += new System.EventHandler(this.btnClienteCMRDP_Click);
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
            this.btnCuentaSueldoDP.Click += new System.EventHandler(this.btnCuentaSueldoDP_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.panel1.Location = new System.Drawing.Point(12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 176);
            this.panel1.TabIndex = 90;
            // 
            // txtcuentasueldoCTS
            // 
            this.txtcuentasueldoCTS.Enabled = false;
            this.txtcuentasueldoCTS.Location = new System.Drawing.Point(143, 9);
            this.txtcuentasueldoCTS.Name = "txtcuentasueldoCTS";
            this.txtcuentasueldoCTS.Size = new System.Drawing.Size(586, 20);
            this.txtcuentasueldoCTS.TabIndex = 7;
            // 
            // txtdatoscontactoCTS
            // 
            this.txtdatoscontactoCTS.Enabled = false;
            this.txtdatoscontactoCTS.Location = new System.Drawing.Point(143, 137);
            this.txtdatoscontactoCTS.Name = "txtdatoscontactoCTS";
            this.txtdatoscontactoCTS.Size = new System.Drawing.Size(586, 20);
            this.txtdatoscontactoCTS.TabIndex = 15;
            // 
            // lblcuentasueldoCTS
            // 
            this.lblcuentasueldoCTS.AutoSize = true;
            this.lblcuentasueldoCTS.Location = new System.Drawing.Point(10, 16);
            this.lblcuentasueldoCTS.Name = "lblcuentasueldoCTS";
            this.lblcuentasueldoCTS.Size = new System.Drawing.Size(104, 13);
            this.lblcuentasueldoCTS.TabIndex = 3;
            this.lblcuentasueldoCTS.Text = "Cuenta Sueldo CTS:";
            // 
            // lbldatoscontactoCTS
            // 
            this.lbldatoscontactoCTS.AutoSize = true;
            this.lbldatoscontactoCTS.Location = new System.Drawing.Point(11, 138);
            this.lbldatoscontactoCTS.Name = "lbldatoscontactoCTS";
            this.lbldatoscontactoCTS.Size = new System.Drawing.Size(108, 13);
            this.lbldatoscontactoCTS.TabIndex = 118;
            this.lbldatoscontactoCTS.Text = "Datos Contacto CTS:";
            // 
            // btnDatosContactoCTS
            // 
            this.btnDatosContactoCTS.Location = new System.Drawing.Point(756, 135);
            this.btnDatosContactoCTS.Name = "btnDatosContactoCTS";
            this.btnDatosContactoCTS.Size = new System.Drawing.Size(61, 23);
            this.btnDatosContactoCTS.TabIndex = 16;
            this.btnDatosContactoCTS.Text = "Agregar";
            this.btnDatosContactoCTS.UseVisualStyleBackColor = true;
            this.btnDatosContactoCTS.Click += new System.EventHandler(this.btnDatosContactoCTS_Click);
            // 
            // txtmigracionCuentaCTS
            // 
            this.txtmigracionCuentaCTS.Enabled = false;
            this.txtmigracionCuentaCTS.Location = new System.Drawing.Point(143, 101);
            this.txtmigracionCuentaCTS.Name = "txtmigracionCuentaCTS";
            this.txtmigracionCuentaCTS.Size = new System.Drawing.Size(586, 20);
            this.txtmigracionCuentaCTS.TabIndex = 13;
            // 
            // btncuentasueldoCTS
            // 
            this.btncuentasueldoCTS.Location = new System.Drawing.Point(756, 6);
            this.btncuentasueldoCTS.Name = "btncuentasueldoCTS";
            this.btncuentasueldoCTS.Size = new System.Drawing.Size(61, 23);
            this.btncuentasueldoCTS.TabIndex = 8;
            this.btncuentasueldoCTS.Text = "Agregar";
            this.btncuentasueldoCTS.UseVisualStyleBackColor = true;
            this.btncuentasueldoCTS.Click += new System.EventHandler(this.btncuentasueldoCTS_Click);
            // 
            // lblmigracionCuentaCTS
            // 
            this.lblmigracionCuentaCTS.AutoSize = true;
            this.lblmigracionCuentaCTS.Location = new System.Drawing.Point(10, 104);
            this.lblmigracionCuentaCTS.Name = "lblmigracionCuentaCTS";
            this.lblmigracionCuentaCTS.Size = new System.Drawing.Size(117, 13);
            this.lblmigracionCuentaCTS.TabIndex = 113;
            this.lblmigracionCuentaCTS.Text = "Migración Cuenta CTS:";
            // 
            // btnmigracionCuentaCTS
            // 
            this.btnmigracionCuentaCTS.Location = new System.Drawing.Point(756, 100);
            this.btnmigracionCuentaCTS.Name = "btnmigracionCuentaCTS";
            this.btnmigracionCuentaCTS.Size = new System.Drawing.Size(61, 23);
            this.btnmigracionCuentaCTS.TabIndex = 14;
            this.btnmigracionCuentaCTS.Text = "Agregar";
            this.btnmigracionCuentaCTS.UseVisualStyleBackColor = true;
            this.btnmigracionCuentaCTS.Click += new System.EventHandler(this.btnmigracionCuentaCTS_Click);
            // 
            // txtabonoQuintaCTS
            // 
            this.txtabonoQuintaCTS.Enabled = false;
            this.txtabonoQuintaCTS.Location = new System.Drawing.Point(143, 38);
            this.txtabonoQuintaCTS.Name = "txtabonoQuintaCTS";
            this.txtabonoQuintaCTS.Size = new System.Drawing.Size(586, 20);
            this.txtabonoQuintaCTS.TabIndex = 9;
            // 
            // lblabonoQuintaCTS
            // 
            this.lblabonoQuintaCTS.AutoSize = true;
            this.lblabonoQuintaCTS.Location = new System.Drawing.Point(10, 43);
            this.lblabonoQuintaCTS.Name = "lblabonoQuintaCTS";
            this.lblabonoQuintaCTS.Size = new System.Drawing.Size(99, 13);
            this.lblabonoQuintaCTS.TabIndex = 111;
            this.lblabonoQuintaCTS.Text = "Abono Quinta CTS:";
            // 
            // btnabonoQuintaCTS
            // 
            this.btnabonoQuintaCTS.Location = new System.Drawing.Point(756, 35);
            this.btnabonoQuintaCTS.Name = "btnabonoQuintaCTS";
            this.btnabonoQuintaCTS.Size = new System.Drawing.Size(61, 23);
            this.btnabonoQuintaCTS.TabIndex = 10;
            this.btnabonoQuintaCTS.Text = "Agregar";
            this.btnabonoQuintaCTS.UseVisualStyleBackColor = true;
            this.btnabonoQuintaCTS.Click += new System.EventHandler(this.btnabonoQuintaCTS_Click);
            // 
            // txtabono360CTS
            // 
            this.txtabono360CTS.Enabled = false;
            this.txtabono360CTS.Location = new System.Drawing.Point(143, 69);
            this.txtabono360CTS.Name = "txtabono360CTS";
            this.txtabono360CTS.Size = new System.Drawing.Size(586, 20);
            this.txtabono360CTS.TabIndex = 11;
            // 
            // lblabono360CTS
            // 
            this.lblabono360CTS.AutoSize = true;
            this.lblabono360CTS.Location = new System.Drawing.Point(10, 73);
            this.lblabono360CTS.Name = "lblabono360CTS";
            this.lblabono360CTS.Size = new System.Drawing.Size(110, 13);
            this.lblabono360CTS.TabIndex = 109;
            this.lblabono360CTS.Text = "Abono 360 días CTS:";
            // 
            // btnabono360CTS
            // 
            this.btnabono360CTS.Location = new System.Drawing.Point(756, 68);
            this.btnabono360CTS.Name = "btnabono360CTS";
            this.btnabono360CTS.Size = new System.Drawing.Size(61, 23);
            this.btnabono360CTS.TabIndex = 12;
            this.btnabono360CTS.Text = "Agregar";
            this.btnabono360CTS.UseVisualStyleBackColor = true;
            this.btnabono360CTS.Click += new System.EventHandler(this.btnabono360CTS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "CTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Depósito a Plazo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "Archivos cargados:";
            // 
            // gvlistado
            // 
            this.gvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvlistado.Location = new System.Drawing.Point(12, 469);
            this.gvlistado.MultiSelect = false;
            this.gvlistado.Name = "gvlistado";
            this.gvlistado.ReadOnly = true;
            this.gvlistado.Size = new System.Drawing.Size(831, 111);
            this.gvlistado.TabIndex = 94;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(182, 395);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(83, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Verificar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pntotal
            // 
            this.pntotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pntotal.Controls.Add(this.txtprocesoDP);
            this.pntotal.Controls.Add(this.lblproceso);
            this.pntotal.Controls.Add(this.btnAgregarDP);
            this.pntotal.Location = new System.Drawing.Point(10, 50);
            this.pntotal.Name = "pntotal";
            this.pntotal.Size = new System.Drawing.Size(833, 46);
            this.pntotal.TabIndex = 95;
            // 
            // txtprocesoDP
            // 
            this.txtprocesoDP.Enabled = false;
            this.txtprocesoDP.Location = new System.Drawing.Point(164, 15);
            this.txtprocesoDP.Name = "txtprocesoDP";
            this.txtprocesoDP.Size = new System.Drawing.Size(539, 20);
            this.txtprocesoDP.TabIndex = 1;
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
            // btnAgregarDP
            // 
            this.btnAgregarDP.Location = new System.Drawing.Point(758, 10);
            this.btnAgregarDP.Name = "btnAgregarDP";
            this.btnAgregarDP.Size = new System.Drawing.Size(61, 23);
            this.btnAgregarDP.TabIndex = 2;
            this.btnAgregarDP.Text = "Agregar";
            this.btnAgregarDP.UseVisualStyleBackColor = true;
            // 
            // lblfechacarga23
            // 
            this.lblfechacarga23.AutoSize = true;
            this.lblfechacarga23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblfechacarga23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacarga23.Location = new System.Drawing.Point(737, 14);
            this.lblfechacarga23.Name = "lblfechacarga23";
            this.lblfechacarga23.Size = new System.Drawing.Size(2, 15);
            this.lblfechacarga23.TabIndex = 97;
            // 
            // lblfechacarga
            // 
            this.lblfechacarga.AutoSize = true;
            this.lblfechacarga.Location = new System.Drawing.Point(640, 13);
            this.lblfechacarga.Name = "lblfechacarga";
            this.lblfechacarga.Size = new System.Drawing.Size(74, 13);
            this.lblfechacarga.TabIndex = 96;
            this.lblfechacarga.Text = "Fecha y Hora:";
            // 
            // frmProcesoCargaTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 587);
            this.Controls.Add(this.lblfechacarga23);
            this.Controls.Add(this.lblfechacarga);
            this.Controls.Add(this.pntotal);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.gvlistado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDP);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblmensajeproceso);
            this.Controls.Add(this.lblresponsable);
            this.Controls.Add(this.ddlresponsable);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmProcesoCargaTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCESO CARGA DP Y CTS";
            this.Load += new System.EventHandler(this.frmProcesoCargaDP_Load);
            this.pnDP.ResumeLayout(false);
            this.pnDP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvlistado)).EndInit();
            this.pntotal.ResumeLayout(false);
            this.pntotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bw1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblresponsable;
        private System.Windows.Forms.ComboBox ddlresponsable;
        private System.Windows.Forms.Label lblmensajeproceso;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteCMRDP;
        private System.Windows.Forms.Label lblClienteCMR;
        private System.Windows.Forms.Button btnClienteCMRDP;
        private System.Windows.Forms.TextBox txtCuentaSueldoDP;
        private System.Windows.Forms.Label lblcuentasueldo;
        private System.Windows.Forms.Button btnCuentaSueldoDP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdatoscontactoCTS;
        private System.Windows.Forms.Label lbldatoscontactoCTS;
        private System.Windows.Forms.Button btnDatosContactoCTS;
        private System.Windows.Forms.Button btncuentasueldoCTS;
        private System.Windows.Forms.TextBox txtmigracionCuentaCTS;
        private System.Windows.Forms.Label lblmigracionCuentaCTS;
        private System.Windows.Forms.Button btnmigracionCuentaCTS;
        private System.Windows.Forms.TextBox txtabonoQuintaCTS;
        private System.Windows.Forms.Label lblabonoQuintaCTS;
        private System.Windows.Forms.Button btnabonoQuintaCTS;
        private System.Windows.Forms.TextBox txtabono360CTS;
        private System.Windows.Forms.Label lblabono360CTS;
        private System.Windows.Forms.Button btnabono360CTS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvlistado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtcuentasueldoCTS;
        private System.Windows.Forms.Label lblcuentasueldoCTS;
        private System.Windows.Forms.Panel pntotal;
        private System.Windows.Forms.TextBox txtprocesoDP;
        private System.Windows.Forms.Label lblproceso;
        private System.Windows.Forms.Button btnAgregarDP;
        private System.Windows.Forms.Label lblfechacarga23;
        private System.Windows.Forms.Label lblfechacarga;
    }
}