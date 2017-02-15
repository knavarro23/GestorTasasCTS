namespace MDIBFGestionTasas.Formularios
{
    partial class FrmPrincipalCts1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalCts1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnucargainicial = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaStockBFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolUsuario});
            this.statusStrip.Location = new System.Drawing.Point(20, 411);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolUsuario
            // 
            this.toolUsuario.Name = "toolUsuario";
            this.toolUsuario.Size = new System.Drawing.Size(42, 17);
            this.toolUsuario.Text = "Estado";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucargainicial,
            this.procesosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnucargainicial
            // 
            this.mnucargainicial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem1});
            this.mnucargainicial.Name = "mnucargainicial";
            this.mnucargainicial.Size = new System.Drawing.Size(101, 20);
            this.mnucargainicial.Text = "Mantenimiento";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento Producto CTS";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem1.Image")));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoDeCargaStockBFToolStripMenuItem,
            this.procesoDeCargaCTSToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // procesoDeCargaStockBFToolStripMenuItem
            // 
            this.procesoDeCargaStockBFToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaStockBFToolStripMenuItem.Image")));
            this.procesoDeCargaStockBFToolStripMenuItem.Name = "procesoDeCargaStockBFToolStripMenuItem";
            this.procesoDeCargaStockBFToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaStockBFToolStripMenuItem.Text = "Proceso de Carga Stock BF";
            this.procesoDeCargaStockBFToolStripMenuItem.Click += new System.EventHandler(this.procesoDeCargaStockBFToolStripMenuItem_Click);
            // 
            // procesoDeCargaCTSToolStripMenuItem
            // 
            this.procesoDeCargaCTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaCTSToolStripMenuItem.Image")));
            this.procesoDeCargaCTSToolStripMenuItem.Name = "procesoDeCargaCTSToolStripMenuItem";
            this.procesoDeCargaCTSToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaCTSToolStripMenuItem.Text = "Proceso de Carga CTS";
            this.procesoDeCargaCTSToolStripMenuItem.Click += new System.EventHandler(this.procesoDeCargaCTSToolStripMenuItem_Click);
            // 
            // FrmPrincipalCts1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipalCts1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "GESTIÓN CTS hasta 31-03-2017";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnucargainicial;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaStockBFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}



