namespace TechFit
{
    partial class frmTelaSplash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaSplash));
            this.lblCarregando = new System.Windows.Forms.Label();
            this.pctrLoadGif = new System.Windows.Forms.PictureBox();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblBancoConectado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrLoadGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.BackColor = System.Drawing.Color.Transparent;
            this.lblCarregando.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.White;
            this.lblCarregando.Location = new System.Drawing.Point(374, 567);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(77, 13);
            this.lblCarregando.TabIndex = 0;
            this.lblCarregando.Text = "CARREGANDO";
            // 
            // pctrLoadGif
            // 
            this.pctrLoadGif.BackColor = System.Drawing.Color.Transparent;
            this.pctrLoadGif.Image = global::TechFit.Properties.Resources.load;
            this.pctrLoadGif.Location = new System.Drawing.Point(457, 564);
            this.pctrLoadGif.Name = "pctrLoadGif";
            this.pctrLoadGif.Size = new System.Drawing.Size(26, 22);
            this.pctrLoadGif.TabIndex = 1;
            this.pctrLoadGif.TabStop = false;
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Interval = 3000;
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // lblBancoConectado
            // 
            this.lblBancoConectado.AutoSize = true;
            this.lblBancoConectado.BackColor = System.Drawing.Color.Transparent;
            this.lblBancoConectado.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBancoConectado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblBancoConectado.Location = new System.Drawing.Point(11, 14);
            this.lblBancoConectado.Name = "lblBancoConectado";
            this.lblBancoConectado.Size = new System.Drawing.Size(0, 11);
            this.lblBancoConectado.TabIndex = 2;
            // 
            // frmTelaSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TechFit.Properties.Resources.splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.lblBancoConectado);
            this.Controls.Add(this.pctrLoadGif);
            this.Controls.Add(this.lblCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTelaSplash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrLoadGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarregando;
        private System.Windows.Forms.PictureBox pctrLoadGif;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblBancoConectado;
    }
}

