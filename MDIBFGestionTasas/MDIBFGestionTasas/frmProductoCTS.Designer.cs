namespace MDIBFGestionTasas
{
    partial class frmProductoCTS
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
            this.gvProducto = new System.Windows.Forms.DataGridView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.ddltipoproducto = new System.Windows.Forms.ComboBox();
            this.lbltipoproducto = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbldp = new System.Windows.Forms.Label();
            this.pntotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // pntotal
            // 
            this.pntotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pntotal.Controls.Add(this.gvProducto);
            this.pntotal.Controls.Add(this.lblnombre);
            this.pntotal.Controls.Add(this.txtnombre);
            this.pntotal.Controls.Add(this.ddltipoproducto);
            this.pntotal.Controls.Add(this.lbltipoproducto);
            this.pntotal.Controls.Add(this.lblcodigo);
            this.pntotal.Controls.Add(this.txtcodigo);
            this.pntotal.Controls.Add(this.btnBuscar);
            this.pntotal.Location = new System.Drawing.Point(12, 34);
            this.pntotal.Name = "pntotal";
            this.pntotal.Size = new System.Drawing.Size(833, 228);
            this.pntotal.TabIndex = 96;
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
            this.btnBuscar.Location = new System.Drawing.Point(742, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbldp
            // 
            this.lbldp.AutoSize = true;
            this.lbldp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldp.Location = new System.Drawing.Point(12, 9);
            this.lbldp.Name = "lbldp";
            this.lbldp.Size = new System.Drawing.Size(151, 13);
            this.lbldp.TabIndex = 97;
            this.lbldp.Text = "Búsqueda productos CTS";
            // 
            // frmProductoCTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(855, 380);
            this.Controls.Add(this.lbldp);
            this.Controls.Add(this.pntotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmProductoCTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento productos CTS";
            this.Load += new System.EventHandler(this.frmProductoCTS_Load);
            this.pntotal.ResumeLayout(false);
            this.pntotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducto)).EndInit();
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
        private System.Windows.Forms.Label lbldp;
    }
}