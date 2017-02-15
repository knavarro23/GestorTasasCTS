namespace MDIBFGestionTasas.Formularios
{
    partial class FrmInicioCts
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
            this.btnCts1 = new MetroFramework.Controls.MetroButton();
            this.btnCts2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnCts1
            // 
            this.btnCts1.Location = new System.Drawing.Point(58, 121);
            this.btnCts1.Name = "btnCts1";
            this.btnCts1.Size = new System.Drawing.Size(184, 65);
            this.btnCts1.TabIndex = 0;
            this.btnCts1.Text = "HASTA 31-03-2017";
            this.btnCts1.UseSelectable = true;
            this.btnCts1.Click += new System.EventHandler(this.btnCts1_Click);
            // 
            // btnCts2
            // 
            this.btnCts2.Location = new System.Drawing.Point(263, 121);
            this.btnCts2.Name = "btnCts2";
            this.btnCts2.Size = new System.Drawing.Size(184, 65);
            this.btnCts2.TabIndex = 1;
            this.btnCts2.Text = "DESDE 01-04-2017";
            this.btnCts2.UseSelectable = true;
            this.btnCts2.Click += new System.EventHandler(this.btnCts2_Click);
            // 
            // FrmInicioCts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 251);
            this.Controls.Add(this.btnCts2);
            this.Controls.Add(this.btnCts1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInicioCts";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Seleccionar CTS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmInicio_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCts1;
        private MetroFramework.Controls.MetroButton btnCts2;
    }
}