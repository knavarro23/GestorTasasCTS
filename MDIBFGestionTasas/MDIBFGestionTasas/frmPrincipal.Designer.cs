namespace MDIBFGestionTasas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnucargainicial = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoIngresoNetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoSaldoNetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaStockBFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnucargainicial,
            this.procesosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(527, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnucargainicial
            // 
            this.mnucargainicial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.mantenimientoIngresoNetoToolStripMenuItem,
            this.mantenimientoSaldoNetoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.mnucargainicial.Name = "mnucargainicial";
            this.mnucargainicial.Size = new System.Drawing.Size(101, 20);
            this.mnucargainicial.Text = "Mantenimiento";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento Producto CTS";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // mantenimientoIngresoNetoToolStripMenuItem
            // 
            this.mantenimientoIngresoNetoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoIngresoNetoToolStripMenuItem.Image")));
            this.mantenimientoIngresoNetoToolStripMenuItem.Name = "mantenimientoIngresoNetoToolStripMenuItem";
            this.mantenimientoIngresoNetoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mantenimientoIngresoNetoToolStripMenuItem.Text = "Mantenimiento Ingreso Neto CTS";
            this.mantenimientoIngresoNetoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoIngresoNetoToolStripMenuItem_Click);
            // 
            // mantenimientoSaldoNetoToolStripMenuItem
            // 
            this.mantenimientoSaldoNetoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoSaldoNetoToolStripMenuItem.Image")));
            this.mantenimientoSaldoNetoToolStripMenuItem.Name = "mantenimientoSaldoNetoToolStripMenuItem";
            this.mantenimientoSaldoNetoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mantenimientoSaldoNetoToolStripMenuItem.Text = "Mantenimiento Saldo en Cuenta CTS";
            this.mantenimientoSaldoNetoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoSaldoNetoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem1.Image")));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoDeCargaStockBFToolStripMenuItem,
            this.procesoDeCargaDPToolStripMenuItem,
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
            // procesoDeCargaDPToolStripMenuItem
            // 
            this.procesoDeCargaDPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaDPToolStripMenuItem.Image")));
            this.procesoDeCargaDPToolStripMenuItem.Name = "procesoDeCargaDPToolStripMenuItem";
            this.procesoDeCargaDPToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaDPToolStripMenuItem.Text = "Proceso de Carga DP";
            this.procesoDeCargaDPToolStripMenuItem.Click += new System.EventHandler(this.procesoDeCargaDPToolStripMenuItem_Click);
            // 
            // procesoDeCargaCTSToolStripMenuItem
            // 
            this.procesoDeCargaCTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaCTSToolStripMenuItem.Image")));
            this.procesoDeCargaCTSToolStripMenuItem.Name = "procesoDeCargaCTSToolStripMenuItem";
            this.procesoDeCargaCTSToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaCTSToolStripMenuItem.Text = "Proceso de Carga CTS";
            this.procesoDeCargaCTSToolStripMenuItem.Click += new System.EventHandler(this.procesoDeCargaCTSToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 261);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "GESTIÓN DE CTS y DP";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnucargainicial;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaStockBFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaCTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoIngresoNetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoSaldoNetoToolStripMenuItem;
    }
}