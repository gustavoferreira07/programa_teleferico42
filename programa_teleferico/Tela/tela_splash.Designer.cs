namespace programa_teleferico.Tela
{
    partial class tela_splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_splash));
            this.pgbTeleferico = new System.Windows.Forms.ProgressBar();
            this.lblPor = new System.Windows.Forms.Label();
            this.tmr_telef = new System.Windows.Forms.Timer(this.components);
            this.tmr_por = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pgbTeleferico
            // 
            this.pgbTeleferico.Location = new System.Drawing.Point(33, 334);
            this.pgbTeleferico.Name = "pgbTeleferico";
            this.pgbTeleferico.Size = new System.Drawing.Size(490, 22);
            this.pgbTeleferico.TabIndex = 0;
            // 
            // lblPor
            // 
            this.lblPor.AutoSize = true;
            this.lblPor.Location = new System.Drawing.Point(38, 312);
            this.lblPor.Name = "lblPor";
            this.lblPor.Size = new System.Drawing.Size(0, 13);
            this.lblPor.TabIndex = 1;
            // 
            // tmr_telef
            // 
            this.tmr_telef.Enabled = true;
            this.tmr_telef.Tick += new System.EventHandler(this.tmr_telef_Tick);
            // 
            // tmr_por
            // 
            this.tmr_por.Enabled = true;
            this.tmr_por.Tick += new System.EventHandler(this.tmr_por_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::programa_teleferico.Properties.Resources.logo_log1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tela_splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(567, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPor);
            this.Controls.Add(this.pgbTeleferico);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log 1";
            this.Load += new System.EventHandler(this.tela_splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbTeleferico;
        private System.Windows.Forms.Label lblPor;
        private System.Windows.Forms.Timer tmr_telef;
        private System.Windows.Forms.Timer tmr_por;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}