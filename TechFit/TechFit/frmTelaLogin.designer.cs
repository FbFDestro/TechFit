namespace TechFit
{
    partial class frmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pctrAlertTipo = new System.Windows.Forms.PictureBox();
            this.pctrAlertSenha = new System.Windows.Forms.PictureBox();
            this.pctrAlertUsuario = new System.Windows.Forms.PictureBox();
            this.rdFuncionario = new System.Windows.Forms.RadioButton();
            this.rdAdmin = new System.Windows.Forms.RadioButton();
            this.lblBtnEntrar = new System.Windows.Forms.Label();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.login;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.pctrAlertTipo);
            this.pnlCentro.Controls.Add(this.pctrAlertSenha);
            this.pnlCentro.Controls.Add(this.pctrAlertUsuario);
            this.pnlCentro.Controls.Add(this.rdFuncionario);
            this.pnlCentro.Controls.Add(this.rdAdmin);
            this.pnlCentro.Controls.Add(this.lblBtnEntrar);
            this.pnlCentro.Controls.Add(this.txtLoginSenha);
            this.pnlCentro.Controls.Add(this.txtLoginUsuario);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(519, 562);
            this.pnlCentro.TabIndex = 1;
            // 
            // pctrAlertTipo
            // 
            this.pctrAlertTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAlertTipo.BackColor = System.Drawing.Color.Transparent;
            this.pctrAlertTipo.Image = ((System.Drawing.Image)(resources.GetObject("pctrAlertTipo.Image")));
            this.pctrAlertTipo.Location = new System.Drawing.Point(256, 186);
            this.pctrAlertTipo.Name = "pctrAlertTipo";
            this.pctrAlertTipo.Size = new System.Drawing.Size(26, 24);
            this.pctrAlertTipo.TabIndex = 90;
            this.pctrAlertTipo.TabStop = false;
            this.pctrAlertTipo.Visible = false;
            // 
            // pctrAlertSenha
            // 
            this.pctrAlertSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAlertSenha.BackColor = System.Drawing.Color.Transparent;
            this.pctrAlertSenha.Image = ((System.Drawing.Image)(resources.GetObject("pctrAlertSenha.Image")));
            this.pctrAlertSenha.Location = new System.Drawing.Point(253, 294);
            this.pctrAlertSenha.Name = "pctrAlertSenha";
            this.pctrAlertSenha.Size = new System.Drawing.Size(26, 24);
            this.pctrAlertSenha.TabIndex = 89;
            this.pctrAlertSenha.TabStop = false;
            this.pctrAlertSenha.Visible = false;
            // 
            // pctrAlertUsuario
            // 
            this.pctrAlertUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAlertUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pctrAlertUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pctrAlertUsuario.Image")));
            this.pctrAlertUsuario.Location = new System.Drawing.Point(253, 238);
            this.pctrAlertUsuario.Name = "pctrAlertUsuario";
            this.pctrAlertUsuario.Size = new System.Drawing.Size(26, 24);
            this.pctrAlertUsuario.TabIndex = 88;
            this.pctrAlertUsuario.TabStop = false;
            this.pctrAlertUsuario.Visible = false;
            // 
            // rdFuncionario
            // 
            this.rdFuncionario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdFuncionario.AutoSize = true;
            this.rdFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.rdFuncionario.Location = new System.Drawing.Point(165, 188);
            this.rdFuncionario.Name = "rdFuncionario";
            this.rdFuncionario.Size = new System.Drawing.Size(92, 20);
            this.rdFuncionario.TabIndex = 4;
            this.rdFuncionario.TabStop = true;
            this.rdFuncionario.Text = "Funcionário";
            this.rdFuncionario.UseVisualStyleBackColor = false;
            this.rdFuncionario.CheckedChanged += new System.EventHandler(this.rdFuncionario_CheckedChanged);
            // 
            // rdAdmin
            // 
            this.rdAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.BackColor = System.Drawing.Color.Transparent;
            this.rdAdmin.Checked = true;
            this.rdAdmin.Location = new System.Drawing.Point(53, 188);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(106, 20);
            this.rdAdmin.TabIndex = 3;
            this.rdAdmin.TabStop = true;
            this.rdAdmin.Text = "Administrador";
            this.rdAdmin.UseVisualStyleBackColor = false;
            this.rdAdmin.CheckedChanged += new System.EventHandler(this.rdAdmin_CheckedChanged);
            // 
            // lblBtnEntrar
            // 
            this.lblBtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEntrar.Location = new System.Drawing.Point(53, 333);
            this.lblBtnEntrar.Name = "lblBtnEntrar";
            this.lblBtnEntrar.Size = new System.Drawing.Size(100, 32);
            this.lblBtnEntrar.TabIndex = 6;
            this.lblBtnEntrar.Click += new System.EventHandler(this.lblBtnEntrar_Click);
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.Location = new System.Drawing.Point(53, 291);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(227, 29);
            this.txtLoginSenha.TabIndex = 2;
            this.txtLoginSenha.UseSystemPasswordChar = true;
            this.txtLoginSenha.TextChanged += new System.EventHandler(this.txtLoginSenha_TextChanged);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.Location = new System.Drawing.Point(54, 235);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(227, 29);
            this.txtLoginUsuario.TabIndex = 1;
            this.txtLoginUsuario.TextChanged += new System.EventHandler(this.txtLoginUsuario_TextChanged);
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(519, 562);
            this.Controls.Add(this.pnlCentro);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(535, 600);
            this.Name = "frmTelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechFit  ..  Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTelaLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmTelaLogin_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnEntrar;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.RadioButton rdFuncionario;
        private System.Windows.Forms.RadioButton rdAdmin;
        private System.Windows.Forms.PictureBox pctrAlertTipo;
        private System.Windows.Forms.PictureBox pctrAlertSenha;
        private System.Windows.Forms.PictureBox pctrAlertUsuario;

    }
}