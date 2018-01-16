namespace TechFit
{
    partial class frmFinanceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceiro));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.gvExibirLucrosDespesas = new System.Windows.Forms.DataGridView();
            this.lblBtnOpcoes = new System.Windows.Forms.Label();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.lblBtnCadastrarDespesas = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblBtnCadastrarLucros = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirLucrosDespesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.adminFinanceiro;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.lblTitulo);
            this.pnlCentro.Controls.Add(this.pctVoltar);
            this.pnlCentro.Controls.Add(this.gvExibirLucrosDespesas);
            this.pnlCentro.Controls.Add(this.lblBtnOpcoes);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnCadastrarDespesas);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnCadastrarLucros);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 644);
            this.pnlCentro.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(84, 131);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(596, 40);
            this.lblTitulo.TabIndex = 111;
            this.lblTitulo.Text = "FINANCEIRO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctVoltar
            // 
            this.pctVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pctVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVoltar.Image = global::TechFit.Properties.Resources.voltar;
            this.pctVoltar.Location = new System.Drawing.Point(702, 551);
            this.pctVoltar.Name = "pctVoltar";
            this.pctVoltar.Size = new System.Drawing.Size(100, 34);
            this.pctVoltar.TabIndex = 110;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // gvExibirLucrosDespesas
            // 
            this.gvExibirLucrosDespesas.AllowUserToAddRows = false;
            this.gvExibirLucrosDespesas.AllowUserToDeleteRows = false;
            this.gvExibirLucrosDespesas.AllowUserToResizeRows = false;
            this.gvExibirLucrosDespesas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvExibirLucrosDespesas.BackgroundColor = System.Drawing.Color.White;
            this.gvExibirLucrosDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirLucrosDespesas.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirLucrosDespesas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gvExibirLucrosDespesas.Location = new System.Drawing.Point(42, 219);
            this.gvExibirLucrosDespesas.MultiSelect = false;
            this.gvExibirLucrosDespesas.Name = "gvExibirLucrosDespesas";
            this.gvExibirLucrosDespesas.ReadOnly = true;
            this.gvExibirLucrosDespesas.RowHeadersWidth = 58;
            this.gvExibirLucrosDespesas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvExibirLucrosDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirLucrosDespesas.Size = new System.Drawing.Size(756, 296);
            this.gvExibirLucrosDespesas.TabIndex = 53;
            // 
            // lblBtnOpcoes
            // 
            this.lblBtnOpcoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnOpcoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnOpcoes.Location = new System.Drawing.Point(416, 527);
            this.lblBtnOpcoes.Name = "lblBtnOpcoes";
            this.lblBtnOpcoes.Size = new System.Drawing.Size(154, 58);
            this.lblBtnOpcoes.TabIndex = 50;
            this.lblBtnOpcoes.Click += new System.EventHandler(this.lblBtnOpcoes_Click);
            // 
            // lblBtnPesquisar
            // 
            this.lblBtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnPesquisar.Location = new System.Drawing.Point(768, 155);
            this.lblBtnPesquisar.Name = "lblBtnPesquisar";
            this.lblBtnPesquisar.Size = new System.Drawing.Size(34, 27);
            this.lblBtnPesquisar.TabIndex = 11;
            // 
            // lblBtnCadastrarDespesas
            // 
            this.lblBtnCadastrarDespesas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnCadastrarDespesas.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCadastrarDespesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCadastrarDespesas.Location = new System.Drawing.Point(222, 529);
            this.lblBtnCadastrarDespesas.Name = "lblBtnCadastrarDespesas";
            this.lblBtnCadastrarDespesas.Size = new System.Drawing.Size(173, 58);
            this.lblBtnCadastrarDespesas.TabIndex = 49;
            this.lblBtnCadastrarDespesas.Click += new System.EventHandler(this.lblBtnCadastrarDespesas_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(549, 184);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(215, 27);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            // 
            // lblBtnCadastrarLucros
            // 
            this.lblBtnCadastrarLucros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnCadastrarLucros.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCadastrarLucros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCadastrarLucros.Location = new System.Drawing.Point(45, 528);
            this.lblBtnCadastrarLucros.Name = "lblBtnCadastrarLucros";
            this.lblBtnCadastrarLucros.Size = new System.Drawing.Size(147, 58);
            this.lblBtnCadastrarLucros.TabIndex = 48;
            this.lblBtnCadastrarLucros.Click += new System.EventHandler(this.lblBtnCadastrarLucros_Click);
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 644);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 650);
            this.Name = "frmFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financeiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFinanceiro_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminFinanceiro_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirLucrosDespesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnCadastrarDespesas;
        private System.Windows.Forms.Label lblBtnCadastrarLucros;
        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblBtnOpcoes;
        private System.Windows.Forms.DataGridView gvExibirLucrosDespesas;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.Label lblTitulo;

    }
}