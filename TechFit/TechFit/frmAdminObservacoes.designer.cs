namespace TechFit
{
    partial class frmAdminObservacoes
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
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.mnOpcoes = new System.Windows.Forms.MenuStrip();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblBtnAdicionar = new System.Windows.Forms.Label();
            this.gvExibirObs = new System.Windows.Forms.DataGridView();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.adminObservacoesLista;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.gvExibirObs);
            this.pnlCentro.Controls.Add(this.mnOpcoes);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnAdicionar);
            this.pnlCentro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 632);
            this.pnlCentro.TabIndex = 4;
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
            this.lblBtnPesquisar.Location = new System.Drawing.Point(767, 179);
            this.lblBtnPesquisar.Name = "lblBtnPesquisar";
            this.lblBtnPesquisar.Size = new System.Drawing.Size(34, 27);
            this.lblBtnPesquisar.TabIndex = 8;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(548, 178);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(215, 27);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.Text = "PESQUISAR";
            // 
            // lblBtnAdicionar
            // 
            this.lblBtnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnAdicionar.Location = new System.Drawing.Point(45, 523);
            this.lblBtnAdicionar.Name = "lblBtnAdicionar";
            this.lblBtnAdicionar.Size = new System.Drawing.Size(176, 58);
            this.lblBtnAdicionar.TabIndex = 7;
            this.lblBtnAdicionar.Click += new System.EventHandler(this.lblBtnAdicionar_Click);
            // 
            // gvExibirObs
            // 
            this.gvExibirObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvExibirObs.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvExibirObs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExibirObs.Location = new System.Drawing.Point(46, 214);
            this.gvExibirObs.Name = "gvExibirObs";
            this.gvExibirObs.Size = new System.Drawing.Size(755, 295);
            this.gvExibirObs.TabIndex = 10;
            // 
            // frmAdminObservacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 632);
            this.Controls.Add(this.pnlCentro);
            this.MinimumSize = new System.Drawing.Size(860, 650);
            this.Name = "frmAdminObservacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminObservacoes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminObservacoes_FormClosed);
            this.Load += new System.EventHandler(this.frmAdminObservacoes_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBtnAdicionar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.MenuStrip mnOpcoes;
        private System.Windows.Forms.DataGridView gvExibirObs;

    }
}