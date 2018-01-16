namespace TechFit
{
    partial class frmAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlunos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.gvExibir = new System.Windows.Forms.DataGridView();
            this.lblBtnExcluir = new System.Windows.Forms.Label();
            this.lblBtnEditar = new System.Windows.Forms.Label();
            this.lblBtnAdicionar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCentro.BackgroundImage")));
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.lblTitulo);
            this.pnlCentro.Controls.Add(this.pctVoltar);
            this.pnlCentro.Controls.Add(this.gvExibir);
            this.pnlCentro.Controls.Add(this.lblBtnExcluir);
            this.pnlCentro.Controls.Add(this.lblBtnEditar);
            this.pnlCentro.Controls.Add(this.lblBtnAdicionar);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 634);
            this.pnlCentro.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(85, 128);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(596, 40);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "ALUNOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pctVoltar
            // 
            this.pctVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pctVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVoltar.Image = global::TechFit.Properties.Resources.voltar;
            this.pctVoltar.Location = new System.Drawing.Point(701, 547);
            this.pctVoltar.Name = "pctVoltar";
            this.pctVoltar.Size = new System.Drawing.Size(100, 34);
            this.pctVoltar.TabIndex = 109;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // gvExibir
            // 
            this.gvExibir.AllowUserToAddRows = false;
            this.gvExibir.AllowUserToDeleteRows = false;
            this.gvExibir.AllowUserToResizeRows = false;
            this.gvExibir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvExibir.BackgroundColor = System.Drawing.Color.White;
            this.gvExibir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibir.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibir.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gvExibir.Location = new System.Drawing.Point(45, 213);
            this.gvExibir.MultiSelect = false;
            this.gvExibir.Name = "gvExibir";
            this.gvExibir.ReadOnly = true;
            this.gvExibir.RowHeadersWidth = 58;
            this.gvExibir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvExibir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibir.Size = new System.Drawing.Size(756, 296);
            this.gvExibir.TabIndex = 13;
            this.gvExibir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibir_CellClick_1);
            // 
            // lblBtnExcluir
            // 
            this.lblBtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnExcluir.Location = new System.Drawing.Point(404, 525);
            this.lblBtnExcluir.Name = "lblBtnExcluir";
            this.lblBtnExcluir.Size = new System.Drawing.Size(157, 58);
            this.lblBtnExcluir.TabIndex = 6;
            this.lblBtnExcluir.Click += new System.EventHandler(this.lblBtnExcluir_Click);
            // 
            // lblBtnEditar
            // 
            this.lblBtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEditar.Location = new System.Drawing.Point(243, 525);
            this.lblBtnEditar.Name = "lblBtnEditar";
            this.lblBtnEditar.Size = new System.Drawing.Size(139, 58);
            this.lblBtnEditar.TabIndex = 5;
            this.lblBtnEditar.Click += new System.EventHandler(this.lblBtnEditar_Click);
            // 
            // lblBtnAdicionar
            // 
            this.lblBtnAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnAdicionar.Location = new System.Drawing.Point(44, 523);
            this.lblBtnAdicionar.Name = "lblBtnAdicionar";
            this.lblBtnAdicionar.Size = new System.Drawing.Size(176, 58);
            this.lblBtnAdicionar.TabIndex = 4;
            this.lblBtnAdicionar.Click += new System.EventHandler(this.lblBtnAdicionar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(548, 180);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(215, 27);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            // 
            // frmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 634);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 672);
            this.Name = "frmAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlunos_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminAlunos_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblBtnExcluir;
        private System.Windows.Forms.Label lblBtnEditar;
        private System.Windows.Forms.Label lblBtnAdicionar;
        private System.Windows.Forms.DataGridView gvExibir;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.Label lblTitulo;
    }
}