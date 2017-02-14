namespace MDIBFGestionTasas.Formularios
{
    partial class FrmInicio
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
            this.btnTarifario1 = new MetroFramework.Controls.MetroButton();
            this.btnTarifario2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnTarifario1
            // 
            this.btnTarifario1.Location = new System.Drawing.Point(58, 121);
            this.btnTarifario1.Name = "btnTarifario1";
            this.btnTarifario1.Size = new System.Drawing.Size(184, 65);
            this.btnTarifario1.TabIndex = 0;
            this.btnTarifario1.Text = "Tarifario CTS al 31-03-2017";
            this.btnTarifario1.UseSelectable = true;
            this.btnTarifario1.Click += new System.EventHandler(this.btnTarifario1_Click);
            // 
            // btnTarifario2
            // 
            this.btnTarifario2.Location = new System.Drawing.Point(263, 121);
            this.btnTarifario2.Name = "btnTarifario2";
            this.btnTarifario2.Size = new System.Drawing.Size(184, 65);
            this.btnTarifario2.TabIndex = 1;
            this.btnTarifario2.Text = "Tarifario CTS desde 01-04-2017";
            this.btnTarifario2.UseSelectable = true;
            this.btnTarifario2.Click += new System.EventHandler(this.btnTarifario2_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 251);
            this.Controls.Add(this.btnTarifario2);
            this.Controls.Add(this.btnTarifario1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicio";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Seleccionar Tarifario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInicio_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnTarifario1;
        private MetroFramework.Controls.MetroButton btnTarifario2;
    }
}