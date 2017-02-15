namespace MDIBFGestionTasas.Formularios
{
    partial class FrmProductoCTS
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gvProducto = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.lbltipoproducto = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblmensajeCTS1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblasterisco = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.lblactivo = new System.Windows.Forms.Label();
            this.chkactivo = new System.Windows.Forms.CheckBox();
            this.txtclase = new System.Windows.Forms.TextBox();
            this.lblclase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.ddlmoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltasa = new System.Windows.Forms.Label();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.lblnombre2 = new System.Windows.Forms.Label();
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.ddltipoproducto2 = new System.Windows.Forms.ComboBox();
            this.lbltipoproducto2 = new System.Windows.Forms.Label();
            this.lblcodigo2 = new System.Windows.Forms.Label();
            this.txtcodigo2 = new System.Windows.Forms.TextBox();
            this.lblmensajeCTS2 = new System.Windows.Forms.Label();
            this.pntotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pntotal
            // 
            this.pntotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pntotal.Controls.Add(this.btnNuevo);
            this.pntotal.Controls.Add(this.gvProducto);
            this.pntotal.Controls.Add(this.lblnombre);
            this.pntotal.Controls.Add(this.txtnombre);
            this.pntotal.Controls.Add(this.ddltipoproducto);
            this.pntotal.Controls.Add(this.lbltipoproducto);
            this.pntotal.Controls.Add(this.lblcodigo);
            this.pntotal.Controls.Add(this.txtcodigo);
            this.pntotal.Controls.Add(this.btnBuscar);
            this.pntotal.Location = new System.Drawing.Point(18, 91);
            this.pntotal.Name = "pntotal";
            this.pntotal.Size = new System.Drawing.Size(833, 220);
            this.pntotal.TabIndex = 96;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(742, 55);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gvProducto
            // 
            this.gvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducto.Location = new System.Drawing.Point(14, 84);
            this.gvProducto.MultiSelect = false;
            this.gvProducto.Name = "gvProducto";
            this.gvProducto.ReadOnly = true;
            this.gvProducto.Size = new System.Drawing.Size(803, 124);
            this.gvProducto.TabIndex = 97;
            this.gvProducto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvProducto_CellMouseClick);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(474, 19);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 79;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(527, 16);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // ddltipoproducto
            // 
            this.ddltipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto.FormattingEnabled = true;
            this.ddltipoproducto.Location = new System.Drawing.Point(123, 11);
            this.ddltipoproducto.Name = "ddltipoproducto";
            this.ddltipoproducto.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto.TabIndex = 77;
            // 
            // lbltipoproducto
            // 
            this.lbltipoproducto.AutoSize = true;
            this.lbltipoproducto.Location = new System.Drawing.Point(6, 11);
            this.lbltipoproducto.Name = "lbltipoproducto";
            this.lbltipoproducto.Size = new System.Drawing.Size(91, 13);
            this.lbltipoproducto.TabIndex = 76;
            this.lbltipoproducto.Text = "Tipo de producto:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(6, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 75;
            this.lblcodigo.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(123, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(661, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblmensajeCTS1
            // 
            this.lblmensajeCTS1.AutoSize = true;
            this.lblmensajeCTS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajeCTS1.Location = new System.Drawing.Point(18, 66);
            this.lblmensajeCTS1.Name = "lblmensajeCTS1";
            this.lblmensajeCTS1.Size = new System.Drawing.Size(151, 13);
            this.lblmensajeCTS1.TabIndex = 97;
            this.lblmensajeCTS1.Text = "Búsqueda productos CTS";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblasterisco);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btngrabar);
            this.panel1.Controls.Add(this.lblactivo);
            this.panel1.Controls.Add(this.chkactivo);
            this.panel1.Controls.Add(this.txtclase);
            this.panel1.Controls.Add(this.lblclase);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdescripcion);
            this.panel1.Controls.Add(this.ddlmoneda);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbltasa);
            this.panel1.Controls.Add(this.txttasa);
            this.panel1.Controls.Add(this.lblnombre2);
            this.panel1.Controls.Add(this.txtnombre2);
            this.panel1.Controls.Add(this.ddltipoproducto2);
            this.panel1.Controls.Add(this.lbltipoproducto2);
            this.panel1.Controls.Add(this.lblcodigo2);
            this.panel1.Controls.Add(this.txtcodigo2);
            this.panel1.Location = new System.Drawing.Point(18, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 201);
            this.panel1.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(357, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "(obligatorio)";
            // 
            // lblasterisco
            // 
            this.lblasterisco.AutoSize = true;
            this.lblasterisco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblasterisco.ForeColor = System.Drawing.Color.Red;
            this.lblasterisco.Location = new System.Drawing.Point(240, 53);
            this.lblasterisco.Name = "lblasterisco";
            this.lblasterisco.Size = new System.Drawing.Size(74, 13);
            this.lblasterisco.TabIndex = 90;
            this.lblasterisco.Text = "(obligatorio)";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(736, 156);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Location = new System.Drawing.Point(655, 156);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 11;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // lblactivo
            // 
            this.lblactivo.AutoSize = true;
            this.lblactivo.Location = new System.Drawing.Point(448, 114);
            this.lblactivo.Name = "lblactivo";
            this.lblactivo.Size = new System.Drawing.Size(40, 13);
            this.lblactivo.TabIndex = 89;
            this.lblactivo.Text = "Activo:";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Location = new System.Drawing.Point(520, 115);
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Size = new System.Drawing.Size(15, 14);
            this.chkactivo.TabIndex = 10;
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // txtclase
            // 
            this.txtclase.Location = new System.Drawing.Point(520, 79);
            this.txtclase.Name = "txtclase";
            this.txtclase.Size = new System.Drawing.Size(290, 20);
            this.txtclase.TabIndex = 8;
            // 
            // lblclase
            // 
            this.lblclase.AutoSize = true;
            this.lblclase.Location = new System.Drawing.Point(448, 79);
            this.lblclase.Name = "lblclase";
            this.lblclase.Size = new System.Drawing.Size(36, 13);
            this.lblclase.TabIndex = 86;
            this.lblclase.Text = "Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Descripción:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(520, 50);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(290, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // ddlmoneda
            // 
            this.ddlmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlmoneda.FormattingEnabled = true;
            this.ddlmoneda.Location = new System.Drawing.Point(687, 18);
            this.ddlmoneda.Name = "ddlmoneda";
            this.ddlmoneda.Size = new System.Drawing.Size(124, 21);
            this.ddlmoneda.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Moneda:";
            // 
            // lbltasa
            // 
            this.lbltasa.AutoSize = true;
            this.lbltasa.Location = new System.Drawing.Point(12, 110);
            this.lbltasa.Name = "lbltasa";
            this.lbltasa.Size = new System.Drawing.Size(34, 13);
            this.lbltasa.TabIndex = 81;
            this.lbltasa.Text = "Tasa:";
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(124, 110);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 9;
            // 
            // lblnombre2
            // 
            this.lblnombre2.AutoSize = true;
            this.lblnombre2.Location = new System.Drawing.Point(12, 82);
            this.lblnombre2.Name = "lblnombre2";
            this.lblnombre2.Size = new System.Drawing.Size(47, 13);
            this.lblnombre2.TabIndex = 79;
            this.lblnombre2.Text = "Nombre:";
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(124, 81);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(227, 20);
            this.txtnombre2.TabIndex = 7;
            // 
            // ddltipoproducto2
            // 
            this.ddltipoproducto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddltipoproducto2.FormattingEnabled = true;
            this.ddltipoproducto2.Location = new System.Drawing.Point(123, 15);
            this.ddltipoproducto2.Name = "ddltipoproducto2";
            this.ddltipoproducto2.Size = new System.Drawing.Size(158, 21);
            this.ddltipoproducto2.TabIndex = 77;
            // 
            // lbltipoproducto2
            // 
            this.lbltipoproducto2.AutoSize = true;
            this.lbltipoproducto2.Location = new System.Drawing.Point(13, 15);
            this.lbltipoproducto2.Name = "lbltipoproducto2";
            this.lbltipoproducto2.Size = new System.Drawing.Size(91, 13);
            this.lbltipoproducto2.TabIndex = 76;
            this.lbltipoproducto2.Text = "Tipo de producto:";
            // 
            // lblcodigo2
            // 
            this.lblcodigo2.AutoSize = true;
            this.lblcodigo2.Location = new System.Drawing.Point(13, 52);
            this.lblcodigo2.Name = "lblcodigo2";
            this.lblcodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo2.TabIndex = 75;
            this.lblcodigo2.Text = "Código:";
            // 
            // txtcodigo2
            // 
            this.txtcodigo2.Location = new System.Drawing.Point(124, 50);
            this.txtcodigo2.MaxLength = 4;
            this.txtcodigo2.Name = "txtcodigo2";
            this.txtcodigo2.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo2.TabIndex = 5;
            this.txtcodigo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo2_KeyPress);
            // 
            // lblmensajeCTS2
            // 
            this.lblmensajeCTS2.AutoSize = true;
            this.lblmensajeCTS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensajeCTS2.Location = new System.Drawing.Point(18, 326);
            this.lblmensajeCTS2.Name = "lblmensajeCTS2";
            this.lblmensajeCTS2.Size = new System.Drawing.Size(0, 13);
            this.lblmensajeCTS2.TabIndex = 99;
            // 
            // FrmProductoCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(871, 572);
            this.Controls.Add(this.lblmensajeCTS2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblmensajeCTS1);
            this.Controls.Add(this.pntotal);
            this.Name = "FrmProductoCTS";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Mantenimiento productos CTS";
            this.Load += new System.EventHandler(this.frmProductoCTS_Load);
            this.pntotal.ResumeLayout(false);
            this.pntotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pntotal;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox ddltipoproducto;
        private System.Windows.Forms.Label lbltipoproducto;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView gvProducto;
        private System.Windows.Forms.Label lblmensajeCTS1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnombre2;
        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.ComboBox ddltipoproducto2;
        private System.Windows.Forms.Label lbltipoproducto2;
        private System.Windows.Forms.Label lblcodigo2;
        private System.Windows.Forms.TextBox txtcodigo2;
        private System.Windows.Forms.Label lblmensajeCTS2;
        private System.Windows.Forms.Label lbltasa;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.ComboBox ddlmoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Label lblactivo;
        private System.Windows.Forms.CheckBox chkactivo;
        private System.Windows.Forms.TextBox txtclase;
        private System.Windows.Forms.Label lblclase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblasterisco;
    }
}