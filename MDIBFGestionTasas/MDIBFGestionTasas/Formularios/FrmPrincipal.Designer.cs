﻿namespace MDIBFGestionTasas.Formularios
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(20, 411);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(592, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
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
            // 
            // mantenimientoSaldoNetoToolStripMenuItem
            // 
            this.mantenimientoSaldoNetoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoSaldoNetoToolStripMenuItem.Image")));
            this.mantenimientoSaldoNetoToolStripMenuItem.Name = "mantenimientoSaldoNetoToolStripMenuItem";
            this.mantenimientoSaldoNetoToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.mantenimientoSaldoNetoToolStripMenuItem.Text = "Mantenimiento Saldo en Cuenta CTS";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem1.Image")));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
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
            // 
            // procesoDeCargaDPToolStripMenuItem
            // 
            this.procesoDeCargaDPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaDPToolStripMenuItem.Image")));
            this.procesoDeCargaDPToolStripMenuItem.Name = "procesoDeCargaDPToolStripMenuItem";
            this.procesoDeCargaDPToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaDPToolStripMenuItem.Text = "Proceso de Carga DP";
            // 
            // procesoDeCargaCTSToolStripMenuItem
            // 
            this.procesoDeCargaCTSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesoDeCargaCTSToolStripMenuItem.Image")));
            this.procesoDeCargaCTSToolStripMenuItem.Name = "procesoDeCargaCTSToolStripMenuItem";
            this.procesoDeCargaCTSToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.procesoDeCargaCTSToolStripMenuItem.Text = "Proceso de Carga CTS";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "GESTIÓN DE CTS y DP";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnucargainicial;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoIngresoNetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoSaldoNetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaStockBFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaCTSToolStripMenuItem;
    }
}



