namespace TechFit
{
    partial class frmCadastroLucro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroLucro));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.lblBtnCancelar = new System.Windows.Forms.Label();
            this.pctrAlertValor = new System.Windows.Forms.PictureBox();
            this.pctrAlertDescricao = new System.Windows.Forms.PictureBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblBtnEntrar = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertDescricao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.cadasrtrarLucros;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.lblBtnCancelar);
            this.pnlCentro.Controls.Add(this.pctrAlertValor);
            this.pnlCentro.Controls.Add(this.pctrAlertDescricao);
            this.pnlCentro.Controls.Add(this.txtValor);
            this.pnlCentro.Controls.Add(this.lblBtnEntrar);
            this.pnlCentro.Controls.Add(this.txtDescricao);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(500, 487);
            this.pnlCentro.TabIndex = 3;
            // 
            // lblBtnCancelar
            // 
            this.lblBtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCancelar.Location = new System.Drawing.Point(198, 436);
            this.lblBtnCancelar.Name = "lblBtnCancelar";
            this.lblBtnCancelar.Size = new System.Drawing.Size(74, 23);
            this.lblBtnCancelar.TabIndex = 89;
            this.lblBtnCancelar.Click += new System.EventHandler(this.lblBtnCancelar_Click);
            // 
            // pctrAlertValor
            // 
            this.pctrAlertValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAlertValor.BackColor = System.Drawing.Color.Transparent;
            this.pctrAlertValor.Image = ((System.Drawing.Image)(resources.GetObject("pctrAlertValor.Image")));
            this.pctrAlertValor.Location = new System.Drawing.Point(244, 388);
            this.pctrAlertValor.Name = "pctrAlertValor";
            this.pctrAlertValor.Size = new System.Drawing.Size(26, 24);
            this.pctrAlertValor.TabIndex = 88;
            this.pctrAlertValor.TabStop = false;
            this.pctrAlertValor.Visible = false;
            // 
            // pctrAlertDescricao
            // 
            this.pctrAlertDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrAlertDescricao.BackColor = System.Drawing.Color.Transparent;
            this.pctrAlertDescricao.Image = ((System.Drawing.Image)(resources.GetObject("pctrAlertDescricao.Image")));
            this.pctrAlertDescricao.Location = new System.Drawing.Point(424, 218);
            this.pctrAlertDescricao.Name = "pctrAlertDescricao";
            this.pctrAlertDescricao.Size = new System.Drawing.Size(26, 24);
            this.pctrAlertDescricao.TabIndex = 85;
            this.pctrAlertDescricao.TabStop = false;
            this.pctrAlertDescricao.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(44, 385);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(227, 29);
            this.txtValor.TabIndex = 17;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // lblBtnEntrar
            // 
            this.lblBtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEntrar.Location = new System.Drawing.Point(42, 434);
            this.lblBtnEntrar.Name = "lblBtnEntrar";
            this.lblBtnEntrar.Size = new System.Drawing.Size(131, 25);
            this.lblBtnEntrar.TabIndex = 15;
            this.lblBtnEntrar.Click += new System.EventHandler(this.lblBtnEntrar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(45, 215);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(407, 146);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // frmCadastroLucro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(76)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(500, 487);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroLucro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroLucro";
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrAlertDescricao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.Label lblBtnCancelar;
        private System.Windows.Forms.PictureBox pctrAlertValor;
        private System.Windows.Forms.PictureBox pctrAlertDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblBtnEntrar;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}