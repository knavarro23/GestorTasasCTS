namespace MDIBFGestionTasas.Formularios
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCargaProceso = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCargaPuntos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCorreoExcluido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCelularesExcluidos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReporteEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReporteSms = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.procesoDeCargaCTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProceso,
            this.menuReportes});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(592, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // menuProceso
            // 
            this.menuProceso.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCargaProceso,
            this.menuItemCargaPuntos,
            this.menuItemCorreoExcluido,
            this.menuItemCelularesExcluidos,
            this.toolStripSeparator3,
            this.menuItemSalir});
            this.menuProceso.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuProceso.Name = "menuProceso";
            this.menuProceso.Size = new System.Drawing.Size(101, 20);
            this.menuProceso.Text = "Mantenimiento";
            // 
            // menuItemCargaProceso
            // 
            this.menuItemCargaProceso.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemCargaProceso.Name = "menuItemCargaProceso";
            this.menuItemCargaProceso.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemCargaProceso.ShowShortcutKeys = false;
            this.menuItemCargaProceso.Size = new System.Drawing.Size(225, 22);
            this.menuItemCargaProceso.Text = "Mantenimiento Producto CTS";
            this.menuItemCargaProceso.Click += new System.EventHandler(this.menuItemCargaProceso_Click);
            // 
            // menuItemCargaPuntos
            // 
            this.menuItemCargaPuntos.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemCargaPuntos.Name = "menuItemCargaPuntos";
            this.menuItemCargaPuntos.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemCargaPuntos.ShowShortcutKeys = false;
            this.menuItemCargaPuntos.Size = new System.Drawing.Size(244, 22);
            this.menuItemCargaPuntos.Text = "Mantenimiento Ingreso Neto CTS";
            this.menuItemCargaPuntos.Click += new System.EventHandler(this.menuItemCargaPuntos_Click);
            // 
            // menuItemCorreoExcluido
            // 
            this.menuItemCorreoExcluido.Name = "menuItemCorreoExcluido";
            this.menuItemCorreoExcluido.Size = new System.Drawing.Size(174, 22);
            this.menuItemCorreoExcluido.Text = "Correos Excluidos";
            this.menuItemCorreoExcluido.Click += new System.EventHandler(this.menuItemCorreoExcluido_Click);
            // 
            // menuItemCelularesExcluidos
            // 
            this.menuItemCelularesExcluidos.Name = "menuItemCelularesExcluidos";
            this.menuItemCelularesExcluidos.Size = new System.Drawing.Size(269, 22);
            this.menuItemCelularesExcluidos.Text = "Mantenimiento Saldo en Cuenta CTS";
            this.menuItemCelularesExcluidos.Click += new System.EventHandler(this.celularesExcluidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // menuItemSalir
            // 
            this.menuItemSalir.Name = "menuItemSalir";
            this.menuItemSalir.Size = new System.Drawing.Size(174, 22);
            this.menuItemSalir.Text = "&Salir";
            this.menuItemSalir.Click += new System.EventHandler(this.menuItemSalir_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReporteEmail,
            this.menuItemReporteSms,
            this.procesoDeCargaCTSToolStripMenuItem});
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Size = new System.Drawing.Size(66, 20);
            this.menuReportes.Text = "Procesos";
            // 
            // menuItemReporteEmail
            // 
            this.menuItemReporteEmail.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemReporteEmail.Name = "menuItemReporteEmail";
            this.menuItemReporteEmail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemReporteEmail.ShowShortcutKeys = false;
            this.menuItemReporteEmail.Size = new System.Drawing.Size(207, 22);
            this.menuItemReporteEmail.Text = "Proceso de Carga Stock BF";
            this.menuItemReporteEmail.Click += new System.EventHandler(this.menuItemReporteEmail_Click);
            // 
            // menuItemReporteSms
            // 
            this.menuItemReporteSms.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuItemReporteSms.Name = "menuItemReporteSms";
            this.menuItemReporteSms.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemReporteSms.ShowShortcutKeys = false;
            this.menuItemReporteSms.Size = new System.Drawing.Size(207, 22);
            this.menuItemReporteSms.Text = "Proceso de Carga DP";
            this.menuItemReporteSms.Click += new System.EventHandler(this.menuItemReporteSms_Click);
            // 
            // procesoDeCargaCTSToolStripMenuItem
            // 
            this.procesoDeCargaCTSToolStripMenuItem.Name = "procesoDeCargaCTSToolStripMenuItem";
            this.procesoDeCargaCTSToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.procesoDeCargaCTSToolStripMenuItem.Text = "Proceso de Carga CTS";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "GESTIÓN DE CTS y DP";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuProceso;
        private System.Windows.Forms.ToolStripMenuItem menuItemCargaProceso;
        private System.Windows.Forms.ToolStripMenuItem menuItemCargaPuntos;
        private System.Windows.Forms.ToolStripMenuItem menuItemSalir;
        private System.Windows.Forms.ToolStripMenuItem menuReportes;
        private System.Windows.Forms.ToolStripMenuItem menuItemReporteEmail;
        private System.Windows.Forms.ToolStripMenuItem menuItemReporteSms;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem menuItemCorreoExcluido;
        private System.Windows.Forms.ToolStripMenuItem menuItemCelularesExcluidos;
        private System.Windows.Forms.ToolStripMenuItem procesoDeCargaCTSToolStripMenuItem;
    }
}