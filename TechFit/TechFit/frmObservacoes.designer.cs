namespace TechFit
{
    partial class Observações
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Observações));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.pctVoltarObs = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvExibirObs = new System.Windows.Forms.DataGridView();
            this.lblBtnPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblBtnAdicionar = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltarObs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.adminObservacoesLista;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.pctVoltarObs);
            this.pnlCentro.Controls.Add(this.label1);
            this.pnlCentro.Controls.Add(this.gvExibirObs);
            this.pnlCentro.Controls.Add(this.lblBtnPesquisar);
            this.pnlCentro.Controls.Add(this.txtPesquisar);
            this.pnlCentro.Controls.Add(this.lblBtnAdicionar);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(844, 632);
            this.pnlCentro.TabIndex = 4;
            // 
            // pctVoltarObs
            // 
            this.pctVoltarObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctVoltarObs.BackColor = System.Drawing.Color.Transparent;
            this.pctVoltarObs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctVoltarObs.Image = global::TechFit.Properties.Resources.voltar;
            this.pctVoltarObs.Location = new System.Drawing.Point(701, 547);
            this.pctVoltarObs.Name = "pctVoltarObs";
            this.pctVoltarObs.Size = new System.Drawing.Size(100, 34);
            this.pctVoltarObs.TabIndex = 17;
            this.pctVoltarObs.TabStop = false;
            this.pctVoltarObs.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(87, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "OBSERVAÇÕES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gvExibirObs
            // 
            this.gvExibirObs.AllowUserToAddRows = false;
            this.gvExibirObs.AllowUserToDeleteRows = false;
            this.gvExibirObs.AllowUserToResizeRows = false;
            this.gvExibirObs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvExibirObs.BackgroundColor = System.Drawing.Color.White;
            this.gvExibirObs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvExibirObs.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvExibirObs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.gvExibirObs.Location = new System.Drawing.Point(46, 212);
            this.gvExibirObs.MultiSelect = false;
            this.gvExibirObs.Name = "gvExibirObs";
            this.gvExibirObs.ReadOnly = true;
            this.gvExibirObs.RowHeadersWidth = 58;
            this.gvExibirObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvExibirObs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExibirObs.Size = new System.Drawing.Size(756, 296);
            this.gvExibirObs.TabIndex = 14;
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
            this.txtPesquisar.Text = "Pesquisar";
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
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
            // Observações
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 632);
            this.Controls.Add(this.pnlCentro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(860, 650);
            this.Name = "Observações";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdminObservacoes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmObservacoes_FormClosing);
            this.Load += new System.EventHandler(this.frmAdminObservacoes_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVoltarObs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExibirObs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBtnAdicionar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnPesquisar;
        private System.Windows.Forms.DataGridView gvExibirObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctVoltarObs;

    }
}