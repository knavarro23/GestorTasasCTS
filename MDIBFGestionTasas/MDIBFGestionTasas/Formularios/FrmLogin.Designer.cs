namespace MDIBFGestionTasas.Formularios
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mbtnEntrar = new MetroFramework.Controls.MetroButton();
            this.mtxtClave = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.Controls.Add(this.pictureBox1);
            this.pnlCenter.Controls.Add(this.mbtnCancelar);
            this.pnlCenter.Controls.Add(this.mbtnEntrar);
            this.pnlCenter.Controls.Add(this.mtxtClave);
            this.pnlCenter.Controls.Add(this.mtxtUsuario);
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(2, 83);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(635, 169);
            this.pnlCenter.TabIndex = 403;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(391, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnCancelar.Location = new System.Drawing.Point(232, 111);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(111, 28);
            this.mbtnCancelar.TabIndex = 4;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.UseSelectable = true;
            this.mbtnCancelar.Click += new System.EventHandler(this.mbtnCancelar_Click);
            // 
            // mbtnEntrar
            // 
            this.mbtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnEntrar.Location = new System.Drawing.Point(103, 111);
            this.mbtnEntrar.Name = "mbtnEntrar";
            this.mbtnEntrar.Size = new System.Drawing.Size(111, 28);
            this.mbtnEntrar.TabIndex = 3;
            this.mbtnEntrar.Text = "Entrar";
            this.mbtnEntrar.UseSelectable = true;
            this.mbtnEntrar.Click += new System.EventHandler(this.mbtnEntrar_Click);
            // 
            // mtxtClave
            // 
            this.mtxtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.mtxtClave.CustomButton.Image = null;
            this.mtxtClave.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.mtxtClave.CustomButton.Name = "";
            this.mtxtClave.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtClave.CustomButton.TabIndex = 1;
            this.mtxtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtClave.CustomButton.UseSelectable = true;
            this.mtxtClave.CustomButton.Visible = false;
            this.mtxtClave.DisplayIcon = true;
            this.mtxtClave.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtClave.Icon")));
            this.mtxtClave.Lines = new string[0];
            this.mtxtClave.Location = new System.Drawing.Point(86, 66);
            this.mtxtClave.MaxLength = 32767;
            this.mtxtClave.Name = "mtxtClave";
            this.mtxtClave.PasswordChar = '●';
            this.mtxtClave.PromptText = "Clave";
            this.mtxtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtClave.SelectedText = "";
            this.mtxtClave.SelectionLength = 0;
            this.mtxtClave.SelectionStart = 0;
            this.mtxtClave.ShortcutsEnabled = true;
            this.mtxtClave.Size = new System.Drawing.Size(279, 28);
            this.mtxtClave.Style = MetroFramework.MetroColorStyle.Green;
            this.mtxtClave.TabIndex = 2;
            this.mtxtClave.UseSelectable = true;
            this.mtxtClave.UseSystemPasswordChar = true;
            this.mtxtClave.WaterMark = "Clave";
            this.mtxtClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtxtClave.Click += new System.EventHandler(this.mtxtClave_Enter);
            this.mtxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtClave_KeyPress);
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.mtxtUsuario.CustomButton.Image = null;
            this.mtxtUsuario.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.mtxtUsuario.CustomButton.Name = "";
            this.mtxtUsuario.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtxtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsuario.CustomButton.TabIndex = 1;
            this.mtxtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsuario.CustomButton.UseSelectable = true;
            this.mtxtUsuario.CustomButton.Visible = false;
            this.mtxtUsuario.DisplayIcon = true;
            this.mtxtUsuario.Icon = ((System.Drawing.Image)(resources.GetObject("mtxtUsuario.Icon")));
            this.mtxtUsuario.Lines = new string[0];
            this.mtxtUsuario.Location = new System.Drawing.Point(86, 32);
            this.mtxtUsuario.MaxLength = 32767;
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PasswordChar = '\0';
            this.mtxtUsuario.PromptText = "Usuario";
            this.mtxtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsuario.SelectedText = "";
            this.mtxtUsuario.SelectionLength = 0;
            this.mtxtUsuario.SelectionStart = 0;
            this.mtxtUsuario.ShortcutsEnabled = true;
            this.mtxtUsuario.Size = new System.Drawing.Size(279, 28);
            this.mtxtUsuario.Style = MetroFramework.MetroColorStyle.Green;
            this.mtxtUsuario.TabIndex = 1;
            this.mtxtUsuario.UseSelectable = true;
            this.mtxtUsuario.WaterMark = "Usuario";
            this.mtxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 295);
            this.Controls.Add(this.pnlCenter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Gestión de Tasas DP y CTS";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlCenter;
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroButton mbtnEntrar;
        private MetroFramework.Controls.MetroTextBox mtxtClave;
        private MetroFramework.Controls.MetroTextBox mtxtUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}