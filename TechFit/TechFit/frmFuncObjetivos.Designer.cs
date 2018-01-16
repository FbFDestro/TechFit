namespace TechFit
{
    partial class frmFuncObjetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncObjetivos));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pctVoltar = new System.Windows.Forms.PictureBox();
            this.gvExibirObjetivos = new System.Windows.Forms.DataGridView();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblBtnDefinirEditar = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObjetivos)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.funcObjetivos;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.pctVoltar);
            this.pnlCentro.Controls.Add(this.gvExibirObjetivos);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnDefinirEditar);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(828, 606);
            this.pnlCentro.TabIndex = 10;
            // 
            // pctVoltar
            // 
            this.pctVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pctVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVoltar.Image = global::TechFit.Properties.Resources.voltar;
            this.pctVoltar.Location = new System.Drawing.Point(702, 533);
            this.pctVoltar.Name = "pctVoltar";
            this.pctVoltar.Size = new System.Drawing.Size(100, 34);
            this.pctVoltar.TabIndex = 110;
            this.pctVoltar.TabStop = false;
            this.pctVoltar.Click += new System.EventHandler(this.pctVoltar_Click);
            // 
            // gvExibirObjetivos
            // 
            this.gvExibirObjetivos.AllowUserToAddRows = false;
            this.gvExibirObjetivos.AllowUserToDeleteRows = false;
            this.gvExibirObjetivos.AllowUserToResizeRows = false;
            this.gvExibirObjetivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvExibirObjetivos.BackgroundColor = System.Drawing.Color.White;
            this.gvExibirObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirObjetivos.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirObjetivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gvExibirObjetivos.Location = new System.Drawing.Point(34, 200);
            this.gvExibirObjetivos.MultiSelect = false;
            this.gvExibirObjetivos.Name = "gvExibirObjetivos";
            this.gvExibirObjetivos.ReadOnly = true;
            this.gvExibirObjetivos.RowHeadersWidth = 58;
            this.gvExibirObjetivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvExibirObjetivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirObjetivos.Size = new System.Drawing.Size(768, 296);
            this.gvExibirObjetivos.TabIndex = 53;
            this.gvExibirObjetivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvExibirObjetivos_CellClick);
            // 
            // lblBtnPesquisar
            // 
            this.lblBtnPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnPesquisar.Location = new System.Drawing.Point(766, 166);
            this.lblBtnPesquisar.Name = "lblBtnPesquisar";
            this.lblBtnPesquisar.Size = new System.Drawing.Size(34, 27);
            this.lblBtnPesquisar.TabIndex = 11;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisar.Location = new System.Drawing.Point(541, 165);
            this.txtPesquisar.Multiline = true;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(215, 27);
            this.txtPesquisar.TabIndex = 10;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter_1);
            // 
            // lblBtnDefinirEditar
            // 
            this.lblBtnDefinirEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnDefinirEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnDefinirEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnDefinirEditar.Location = new System.Drawing.Point(37, 509);
            this.lblBtnDefinirEditar.Name = "lblBtnDefinirEditar";
            this.lblBtnDefinirEditar.Size = new System.Drawing.Size(386, 58);
            this.lblBtnDefinirEditar.TabIndex = 48;
            this.lblBtnDefinirEditar.Click += new System.EventHandler(this.lblBtnDefinirEditar_Click);
            // 
            // frmFuncObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(828, 606);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(844, 645);
            this.Name = "frmFuncObjetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionário - Objetivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFuncObjetivos_FormClosing);
            this.Load += new System.EventHandler(this.frmFuncObjetivos_Load_1);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObjetivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.PictureBox pctVoltar;
        private System.Windows.Forms.DataGridView gvExibirObjetivos;
        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblBtnDefinirEditar;
    }
}