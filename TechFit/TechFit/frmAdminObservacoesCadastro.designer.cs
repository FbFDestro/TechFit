namespace TechFit
{
    partial class frmAdminObservacoesCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminObservacoesCadastro));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pbAobservacao = new System.Windows.Forms.PictureBox();
            this.pbAprioridade = new System.Windows.Forms.PictureBox();
            this.pbAassunto = new System.Windows.Forms.PictureBox();
            this.cmbPrioridade = new System.Windows.Forms.ComboBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.lblBtnCadastrar = new System.Windows.Forms.Label();
            this.mnOpcoes = new System.Windows.Forms.MenuStrip();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAobservacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAprioridade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAassunto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.adminObsCadastro;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.pbAobservacao);
            this.pnlCentro.Controls.Add(this.pbAprioridade);
            this.pnlCentro.Controls.Add(this.pbAassunto);
            this.pnlCentro.Controls.Add(this.cmbPrioridade);
            this.pnlCentro.Controls.Add(this.txtObs);
            this.pnlCentro.Controls.Add(this.txtAssunto);
            this.pnlCentro.Controls.Add(this.lblBtnCadastrar);
            this.pnlCentro.Controls.Add(this.mnOpcoes);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 632);
            this.pnlCentro.TabIndex = 5;
            // 
            // pbAobservacao
            // 
            this.pbAobservacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAobservacao.BackColor = System.Drawing.Color.Transparent;
            this.pbAobservacao.Image = ((System.Drawing.Image)(resources.GetObject("pbAobservacao.Image")));
            this.pbAobservacao.Location = new System.Drawing.Point(756, 292);
            this.pbAobservacao.Name = "pbAobservacao";
            this.pbAobservacao.Size = new System.Drawing.Size(26, 24);
            this.pbAobservacao.TabIndex = 88;
            this.pbAobservacao.TabStop = false;
            this.pbAobservacao.Visible = false;
            // 
            // pbAprioridade
            // 
            this.pbAprioridade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAprioridade.BackColor = System.Drawing.Color.Transparent;
            this.pbAprioridade.Image = ((System.Drawing.Image)(resources.GetObject("pbAprioridade.Image")));
            this.pbAprioridade.Location = new System.Drawing.Point(742, 226);
            this.pbAprioridade.Name = "pbAprioridade";
            this.pbAprioridade.Size = new System.Drawing.Size(26, 24);
            this.pbAprioridade.TabIndex = 87;
            this.pbAprioridade.TabStop = false;
            this.pbAprioridade.Visible = false;
            // 
            // pbAassunto
            // 
            this.pbAassunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbAassunto.BackColor = System.Drawing.Color.Transparent;
            this.pbAassunto.Image = ((System.Drawing.Image)(resources.GetObject("pbAassunto.Image")));
            this.pbAassunto.Location = new System.Drawing.Point(398, 226);
            this.pbAassunto.Name = "pbAassunto";
            this.pbAassunto.Size = new System.Drawing.Size(26, 24);
            this.pbAassunto.TabIndex = 86;
            this.pbAassunto.TabStop = false;
            this.pbAassunto.Visible = false;
            // 
            // cmbPrioridade
            // 
            this.cmbPrioridade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbPrioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridade.FormattingEnabled = true;
            this.cmbPrioridade.Items.AddRange(new object[] {
            "Normal",
            "Urgente"});
            this.cmbPrioridade.Location = new System.Drawing.Point(570, 222);
            this.cmbPrioridade.Name = "cmbPrioridade";
            this.cmbPrioridade.Size = new System.Drawing.Size(217, 32);
            this.cmbPrioridade.TabIndex = 2;
            this.cmbPrioridade.SelectedIndexChanged += new System.EventHandler(this.cmbPrioridade_SelectedIndexChanged);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(58, 288);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(729, 212);
            this.txtObs.TabIndex = 3;
            this.txtObs.TextChanged += new System.EventHandler(this.txtObs_TextChanged);
            // 
            // txtAssunto
            // 
            this.txtAssunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssunto.Location = new System.Drawing.Point(153, 223);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(273, 29);
            this.txtAssunto.TabIndex = 1;
            this.txtAssunto.TextChanged += new System.EventHandler(this.txtAssunto_TextChanged);
            // 
            // lblBtnCadastrar
            // 
            this.lblBtnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCadastrar.Location = new System.Drawing.Point(43, 525);
            this.lblBtnCadastrar.Name = "lblBtnCadastrar";
            this.lblBtnCadastrar.Size = new System.Drawing.Size(191, 58);
            this.lblBtnCadastrar.TabIndex = 4;
            this.lblBtnCadastrar.Click += new System.EventHandler(this.lblBtnCadastrar_Click);
            // 
            // mnOpcoes
            // 
            this.mnOpcoes.BackColor = System.Drawing.Color.White;
            this.mnOpcoes.Location = new System.Drawing.Point(0, 0);
            this.mnOpcoes.Name = "mnOpcoes";
            this.mnOpcoes.Size = new System.Drawing.Size(844, 24);
            this.mnOpcoes.TabIndex = 9;
            this.mnOpcoes.Text = "menuStrip1";
            // 
            // lblBtnPesquisar
            // 
            this.lblBtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnPesquisar.Location = new System.Drawing.Point(767, 155);
            this.lblBtnPesquisar.Name = "lblBtnPesquisar";
            this.lblBtnPesquisar.Size = new System.Drawing.Size(34, 27);
            this.lblBtnPesquisar.TabIndex = 8;
            // 
            // frmAdminObservacoesCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 632);
            this.Controls.Add(this.pnlCentro);
            this.MinimumSize = new System.Drawing.Size(860, 650);
            this.Name = "frmAdminObservacoesCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminObservacoesCadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAobservacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAprioridade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAassunto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.MenuStrip mnOpcoes;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnCadastrar;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.ComboBox cmbPrioridade;
        private System.Windows.Forms.PictureBox pbAobservacao;
        private System.Windows.Forms.PictureBox pbAprioridade;
        private System.Windows.Forms.PictureBox pbAassunto;

    }
}