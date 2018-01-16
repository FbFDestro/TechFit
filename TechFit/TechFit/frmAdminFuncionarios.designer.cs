namespace TechFit
{
    partial class frmAdminFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminFuncionarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.gvFunc = new System.Windows.Forms.DataGridView();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.lblBtnDeletar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblBtnEditar = new System.Windows.Forms.Label();
            this.lblBtnAdicionar = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCentro.BackgroundImage")));
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.pctVoltar);
            this.pnlCentro.Controls.Add(this.gvFunc);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnDeletar);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnEditar);
            this.pnlCentro.Controls.Add(this.lblBtnAdicionar);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 634);
            this.pnlCentro.TabIndex = 3;
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
            this.pctVoltar.TabIndex = 111;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // gvFunc
            // 
            this.gvFunc.AllowUserToAddRows = false;
            this.gvFunc.AllowUserToDeleteRows = false;
            this.gvFunc.AllowUserToResizeRows = false;
            this.gvFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvFunc.BackgroundColor = System.Drawing.Color.White;
            this.gvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFunc.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvFunc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gvFunc.Location = new System.Drawing.Point(45, 214);
            this.gvFunc.MultiSelect = false;
            this.gvFunc.Name = "gvFunc";
            this.gvFunc.ReadOnly = true;
            this.gvFunc.RowHeadersWidth = 58;
            this.gvFunc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFunc.Size = new System.Drawing.Size(756, 296);
            this.gvFunc.TabIndex = 11;
            this.gvFunc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFunc_CellClick);
            // 
            // lblBtnPesquisar
            // 
            this.lblBtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnPesquisar.Location = new System.Drawing.Point(767, 180);
            this.lblBtnPesquisar.Name = "lblBtnPesquisar";
            this.lblBtnPesquisar.Size = new System.Drawing.Size(34, 27);
            this.lblBtnPesquisar.TabIndex = 10;
            // 
            // lblBtnDeletar
            // 
            this.lblBtnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnDeletar.Location = new System.Drawing.Point(405, 525);
            this.lblBtnDeletar.Name = "lblBtnDeletar";
            this.lblBtnDeletar.Size = new System.Drawing.Size(157, 58);
            this.lblBtnDeletar.TabIndex = 9;
            this.lblBtnDeletar.Click += new System.EventHandler(this.lblBtnDeletar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(548, 180);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(215, 27);
            this.txtPesquisar.TabIndex = 5;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            // 
            // lblBtnEditar
            // 
            this.lblBtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEditar.Location = new System.Drawing.Point(244, 525);
            this.lblBtnEditar.Name = "lblBtnEditar";
            this.lblBtnEditar.Size = new System.Drawing.Size(139, 58);
            this.lblBtnEditar.TabIndex = 8;
            this.lblBtnEditar.Click += new System.EventHandler(this.lblBtnEditar_Click);
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
            // frmAdminFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 634);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 672);
            this.Name = "frmAdminFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador - Funcionários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdminFuncionarios_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminFuncionarios_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblBtnDeletar;
        private System.Windows.Forms.Label lblBtnEditar;
        private System.Windows.Forms.Label lblBtnAdicionar;
        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.DataGridView gvFunc;
        private System.Windows.Forms.PictureBox pctVoltar;
    }
}