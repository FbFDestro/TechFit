namespace TechFit
{
    partial class frmAdminPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminPrincipal));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBtnFunc = new System.Windows.Forms.Label();
            this.lblBtnEditarPerfil = new System.Windows.Forms.Label();
            this.lblBtnObservacoes = new System.Windows.Forms.Label();
            this.lblBtnFincanceiro = new System.Windows.Forms.Label();
            this.lblBtnAlunos = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.adminMenuPrincipal;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.menuStrip2);
            this.pnlCentro.Controls.Add(this.lblBtnFunc);
            this.pnlCentro.Controls.Add(this.lblBtnEditarPerfil);
            this.pnlCentro.Controls.Add(this.lblBtnObservacoes);
            this.pnlCentro.Controls.Add(this.lblBtnFincanceiro);
            this.pnlCentro.Controls.Add(this.lblBtnAlunos);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(502, 603);
            this.pnlCentro.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(502, 24);
            this.menuStrip2.TabIndex = 21;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblBtnFunc
            // 
            this.lblBtnFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnFunc.Location = new System.Drawing.Point(38, 286);
            this.lblBtnFunc.Name = "lblBtnFunc";
            this.lblBtnFunc.Size = new System.Drawing.Size(200, 56);
            this.lblBtnFunc.TabIndex = 9;
            this.lblBtnFunc.Click += new System.EventHandler(this.lblBtnFunc_Click);
            // 
            // lblBtnEditarPerfil
            // 
            this.lblBtnEditarPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEditarPerfil.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEditarPerfil.Location = new System.Drawing.Point(38, 499);
            this.lblBtnEditarPerfil.Name = "lblBtnEditarPerfil";
            this.lblBtnEditarPerfil.Size = new System.Drawing.Size(194, 56);
            this.lblBtnEditarPerfil.TabIndex = 8;
            this.lblBtnEditarPerfil.Click += new System.EventHandler(this.lblBtnEditarPerfil_Click);
            // 
            // lblBtnObservacoes
            // 
            this.lblBtnObservacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnObservacoes.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnObservacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnObservacoes.Location = new System.Drawing.Point(38, 429);
            this.lblBtnObservacoes.Name = "lblBtnObservacoes";
            this.lblBtnObservacoes.Size = new System.Drawing.Size(200, 56);
            this.lblBtnObservacoes.TabIndex = 7;
            this.lblBtnObservacoes.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblBtnFincanceiro
            // 
            this.lblBtnFincanceiro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnFincanceiro.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnFincanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnFincanceiro.Location = new System.Drawing.Point(38, 358);
            this.lblBtnFincanceiro.Name = "lblBtnFincanceiro";
            this.lblBtnFincanceiro.Size = new System.Drawing.Size(174, 56);
            this.lblBtnFincanceiro.TabIndex = 6;
            this.lblBtnFincanceiro.Click += new System.EventHandler(this.lblBtnFincanceiro_Click);
            // 
            // lblBtnAlunos
            // 
            this.lblBtnAlunos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnAlunos.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnAlunos.Location = new System.Drawing.Point(38, 218);
            this.lblBtnAlunos.Name = "lblBtnAlunos";
            this.lblBtnAlunos.Size = new System.Drawing.Size(144, 56);
            this.lblBtnAlunos.TabIndex = 4;
            this.lblBtnAlunos.Click += new System.EventHandler(this.lblBtnAlunos_Click);
            // 
            // frmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 603);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(518, 590);
            this.Name = "frmAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechFit  ..  Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminPrincipal_FormClosing);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnObservacoes;
        private System.Windows.Forms.Label lblBtnFincanceiro;
        private System.Windows.Forms.Label lblBtnAlunos;
        private System.Windows.Forms.Label lblBtnEditarPerfil;
        private System.Windows.Forms.Label lblBtnFunc;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}