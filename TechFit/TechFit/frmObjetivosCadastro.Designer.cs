namespace TechFit
{
    partial class frmObjetivosCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmObjetivosCadastro));
            this.pnlCentro = new System.Windows.Forms.Panel();
            this.cmbEstilo = new System.Windows.Forms.ComboBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.pctEstilo = new System.Windows.Forms.PictureBox();
            this.lblMetaPeso = new System.Windows.Forms.Label();
            this.pctMetaPeso = new System.Windows.Forms.PictureBox();
            this.txtMetaPeso = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.pctAltura = new System.Windows.Forms.PictureBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblBtnCancelar = new System.Windows.Forms.Label();
            this.pctPeso = new System.Windows.Forms.PictureBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblBtnEntrar = new System.Windows.Forms.Label();
            this.pnlCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstilo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMetaPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCentro
            // 
            this.pnlCentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.pnlCentro.BackgroundImage = global::TechFit.Properties.Resources.objetivosCad;
            this.pnlCentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlCentro.Controls.Add(this.cmbEstilo);
            this.pnlCentro.Controls.Add(this.lblEstilo);
            this.pnlCentro.Controls.Add(this.pctEstilo);
            this.pnlCentro.Controls.Add(this.lblMetaPeso);
            this.pnlCentro.Controls.Add(this.pctMetaPeso);
            this.pnlCentro.Controls.Add(this.txtMetaPeso);
            this.pnlCentro.Controls.Add(this.lblAltura);
            this.pnlCentro.Controls.Add(this.pctAltura);
            this.pnlCentro.Controls.Add(this.txtAltura);
            this.pnlCentro.Controls.Add(this.lblPeso);
            this.pnlCentro.Controls.Add(this.lblBtnCancelar);
            this.pnlCentro.Controls.Add(this.pctPeso);
            this.pnlCentro.Controls.Add(this.txtPeso);
            this.pnlCentro.Controls.Add(this.lblBtnEntrar);
            this.pnlCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentro.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCentro.Location = new System.Drawing.Point(0, 0);
            this.pnlCentro.Name = "pnlCentro";
            this.pnlCentro.Size = new System.Drawing.Size(500, 500);
            this.pnlCentro.TabIndex = 6;
            // 
            // cmbEstilo
            // 
            this.cmbEstilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbEstilo.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstilo.FormattingEnabled = true;
            this.cmbEstilo.Items.AddRange(new object[] {
            "Hipertrofia",
            "Saúde",
            "Resistência"});
            this.cmbEstilo.Location = new System.Drawing.Point(102, 336);
            this.cmbEstilo.Name = "cmbEstilo";
            this.cmbEstilo.Size = new System.Drawing.Size(228, 29);
            this.cmbEstilo.TabIndex = 100;
            this.cmbEstilo.SelectedIndexChanged += new System.EventHandler(this.cmbEstilo_SelectedIndexChanged);
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstilo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstilo.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstilo.Location = new System.Drawing.Point(45, 337);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(58, 24);
            this.lblEstilo.TabIndex = 99;
            this.lblEstilo.Text = "Estilo";
            // 
            // pctEstilo
            // 
            this.pctEstilo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctEstilo.BackColor = System.Drawing.Color.Transparent;
            this.pctEstilo.Image = ((System.Drawing.Image)(resources.GetObject("pctEstilo.Image")));
            this.pctEstilo.Location = new System.Drawing.Point(336, 340);
            this.pctEstilo.Name = "pctEstilo";
            this.pctEstilo.Size = new System.Drawing.Size(26, 24);
            this.pctEstilo.TabIndex = 98;
            this.pctEstilo.TabStop = false;
            this.pctEstilo.Visible = false;
            // 
            // lblMetaPeso
            // 
            this.lblMetaPeso.AutoSize = true;
            this.lblMetaPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblMetaPeso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetaPeso.ForeColor = System.Drawing.Color.DimGray;
            this.lblMetaPeso.Location = new System.Drawing.Point(45, 290);
            this.lblMetaPeso.Name = "lblMetaPeso";
            this.lblMetaPeso.Size = new System.Drawing.Size(154, 24);
            this.lblMetaPeso.TabIndex = 96;
            this.lblMetaPeso.Text = "Meta de peso";
            // 
            // pctMetaPeso
            // 
            this.pctMetaPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctMetaPeso.BackColor = System.Drawing.Color.Transparent;
            this.pctMetaPeso.Image = ((System.Drawing.Image)(resources.GetObject("pctMetaPeso.Image")));
            this.pctMetaPeso.Location = new System.Drawing.Point(349, 293);
            this.pctMetaPeso.Name = "pctMetaPeso";
            this.pctMetaPeso.Size = new System.Drawing.Size(26, 24);
            this.pctMetaPeso.TabIndex = 95;
            this.pctMetaPeso.TabStop = false;
            this.pctMetaPeso.Visible = false;
            // 
            // txtMetaPeso
            // 
            this.txtMetaPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMetaPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetaPeso.Location = new System.Drawing.Point(200, 290);
            this.txtMetaPeso.Name = "txtMetaPeso";
            this.txtMetaPeso.Size = new System.Drawing.Size(147, 29);
            this.txtMetaPeso.TabIndex = 94;
            this.txtMetaPeso.TextChanged += new System.EventHandler(this.txtMetaPeso_TextChanged);
            this.txtMetaPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMetaPeso_KeyPress);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.Transparent;
            this.lblAltura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.ForeColor = System.Drawing.Color.DimGray;
            this.lblAltura.Location = new System.Drawing.Point(45, 241);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(70, 24);
            this.lblAltura.TabIndex = 93;
            this.lblAltura.Text = "Altura";
            // 
            // pctAltura
            // 
            this.pctAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctAltura.BackColor = System.Drawing.Color.Transparent;
            this.pctAltura.Image = ((System.Drawing.Image)(resources.GetObject("pctAltura.Image")));
            this.pctAltura.Location = new System.Drawing.Point(346, 246);
            this.pctAltura.Name = "pctAltura";
            this.pctAltura.Size = new System.Drawing.Size(26, 24);
            this.pctAltura.TabIndex = 92;
            this.pctAltura.TabStop = false;
            this.pctAltura.Visible = false;
            // 
            // txtAltura
            // 
            this.txtAltura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(117, 242);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(227, 29);
            this.txtAltura.TabIndex = 91;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.Color.DimGray;
            this.lblPeso.Location = new System.Drawing.Point(45, 192);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(58, 24);
            this.lblPeso.TabIndex = 90;
            this.lblPeso.Text = "Peso";
            // 
            // lblBtnCancelar
            // 
            this.lblBtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnCancelar.Location = new System.Drawing.Point(179, 453);
            this.lblBtnCancelar.Name = "lblBtnCancelar";
            this.lblBtnCancelar.Size = new System.Drawing.Size(74, 23);
            this.lblBtnCancelar.TabIndex = 89;
            this.lblBtnCancelar.Click += new System.EventHandler(this.lblBtnCancelar_Click);
            // 
            // pctPeso
            // 
            this.pctPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctPeso.BackColor = System.Drawing.Color.Transparent;
            this.pctPeso.Image = ((System.Drawing.Image)(resources.GetObject("pctPeso.Image")));
            this.pctPeso.Location = new System.Drawing.Point(349, 196);
            this.pctPeso.Name = "pctPeso";
            this.pctPeso.Size = new System.Drawing.Size(26, 24);
            this.pctPeso.TabIndex = 85;
            this.pctPeso.TabStop = false;
            this.pctPeso.Visible = false;
            // 
            // txtPeso
            // 
            this.txtPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(104, 193);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(239, 29);
            this.txtPeso.TabIndex = 17;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblBtnEntrar
            // 
            this.lblBtnEntrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBtnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.lblBtnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBtnEntrar.Location = new System.Drawing.Point(41, 452);
            this.lblBtnEntrar.Name = "lblBtnEntrar";
            this.lblBtnEntrar.Size = new System.Drawing.Size(103, 25);
            this.lblBtnEntrar.TabIndex = 15;
            this.lblBtnEntrar.Click += new System.EventHandler(this.lblBtnEntrar_Click);
            // 
            // frmObjetivosCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnlCentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmObjetivosCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmObjetivosCadastro";
            this.Load += new System.EventHandler(this.frmObjetivosCadastro_Load);
            this.pnlCentro.ResumeLayout(false);
            this.pnlCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctEstilo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMetaPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPeso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCentro;
        private System.Windows.Forms.ComboBox cmbEstilo;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.PictureBox pctEstilo;
        private System.Windows.Forms.Label lblMetaPeso;
        private System.Windows.Forms.PictureBox pctMetaPeso;
        private System.Windows.Forms.TextBox txtMetaPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.PictureBox pctAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblBtnCancelar;
        private System.Windows.Forms.PictureBox pctPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblBtnEntrar;

    }
}