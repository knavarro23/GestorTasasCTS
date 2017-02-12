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
            this.pnlCenter = new MetroFramework.Controls.MetroPanel();
            this.mbtnCancelar = new MetroFramework.Controls.MetroButton();
            this.mbtnEntrar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtxtClave = new MetroFramework.Controls.MetroTextBox();
            this.mtxtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.pnlCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCenter.Controls.Add(this.mbtnCancelar);
            this.pnlCenter.Controls.Add(this.mbtnEntrar);
            this.pnlCenter.Controls.Add(this.pictureBox1);
            this.pnlCenter.Controls.Add(this.mtxtClave);
            this.pnlCenter.Controls.Add(this.mtxtUsuario);
            this.pnlCenter.HorizontalScrollbarBarColor = true;
            this.pnlCenter.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlCenter.HorizontalScrollbarSize = 10;
            this.pnlCenter.Location = new System.Drawing.Point(2, 88);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(635, 169);
            this.pnlCenter.TabIndex = 402;
            this.pnlCenter.VerticalScrollbarBarColor = true;
            this.pnlCenter.VerticalScrollbarHighlightOnWheel = false;
            this.pnlCenter.VerticalScrollbarSize = 10;
            // 
            // mbtnCancelar
            // 
            this.mbtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnCancelar.Location = new System.Drawing.Point(263, 111);
            this.mbtnCancelar.Name = "mbtnCancelar";
            this.mbtnCancelar.Size = new System.Drawing.Size(111, 28);
            this.mbtnCancelar.TabIndex = 4;
            this.mbtnCancelar.Text = "Cancelar";
            this.mbtnCancelar.Click += new System.EventHandler(this.mbtnCancelar_Click);
            // 
            // mbtnEntrar
            // 
            this.mbtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mbtnEntrar.Location = new System.Drawing.Point(134, 111);
            this.mbtnEntrar.Name = "mbtnEntrar";
            this.mbtnEntrar.Size = new System.Drawing.Size(111, 28);
            this.mbtnEntrar.TabIndex = 3;
            this.mbtnEntrar.Text = "Entrar";
            this.mbtnEntrar.Click += new System.EventHandler(this.mbtnEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(412, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // mtxtClave
            // 
            this.mtxtClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtClave.Location = new System.Drawing.Point(117, 66);
            this.mtxtClave.Name = "mtxtClave";
            this.mtxtClave.PasswordChar = '●';
            this.mtxtClave.PromptText = "Clave";
            this.mtxtClave.Size = new System.Drawing.Size(279, 28);
            this.mtxtClave.Style = MetroFramework.MetroColorStyle.Green;
            this.mtxtClave.TabIndex = 2;
            this.mtxtClave.UseSystemPasswordChar = true;
            this.mtxtClave.Enter += new System.EventHandler(this.mtxtClave_Enter);
            this.mtxtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtClave_KeyPress);
            // 
            // mtxtUsuario
            // 
            this.mtxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtxtUsuario.Location = new System.Drawing.Point(117, 32);
            this.mtxtUsuario.Name = "mtxtUsuario";
            this.mtxtUsuario.PromptText = "Usuario";
            this.mtxtUsuario.Size = new System.Drawing.Size(279, 28);
            this.mtxtUsuario.Style = MetroFramework.MetroColorStyle.Green;
            this.mtxtUsuario.TabIndex = 1;
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
            this.Text = "LIngreso Credenciales";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlCenter;
        private MetroFramework.Controls.MetroButton mbtnCancelar;
        private MetroFramework.Controls.MetroButton mbtnEntrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtxtClave;
        private MetroFramework.Controls.MetroTextBox mtxtUsuario;
    }
}