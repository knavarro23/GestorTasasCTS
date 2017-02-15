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
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaStockBFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoDeCargaDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(527, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesoDeCargaStockBFToolStripMenuItem,
            this.procesoDeCargaDPToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolMenuSalir});
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
            // toolMenuSalir
            // 
            this.toolMenuSalir.Name = "toolMenuSalir";
            this.toolMenuSalir.Size = new System.Drawing.Size(214, 22);
            this.toolMenuSalir.Text = "Salir";
            this.toolMenuSalir.Click += new System.EventHandler(this.toolMenuSalir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
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
            this.Text = "GESTIÓN DEPÓSITO A PLAZO";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaStockBFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSalir;
    }
}