namespace programa_teleferico.Tela
{
    partial class tela_abertura_catraca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_abertura_catraca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtInicialCatraca = new System.Windows.Forms.TextBox();
            this.txt_codigoCatraca = new System.Windows.Forms.TextBox();
            this.rdbP1 = new System.Windows.Forms.RadioButton();
            this.rdbP2 = new System.Windows.Forms.RadioButton();
            this.msk_dataCatraca = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbbOperador = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.txtInicialCatraca);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 100);
            this.groupBox1.TabIndex = 659;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Número inicial da roleta";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(55, 21);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 677;
            this.metroLabel5.Text = "Inicial:";
            // 
            // txtInicialCatraca
            // 
            this.txtInicialCatraca.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicialCatraca.Location = new System.Drawing.Point(31, 44);
            this.txtInicialCatraca.Multiline = true;
            this.txtInicialCatraca.Name = "txtInicialCatraca";
            this.txtInicialCatraca.Size = new System.Drawing.Size(92, 36);
            this.txtInicialCatraca.TabIndex = 4;
            // 
            // txt_codigoCatraca
            // 
            this.txt_codigoCatraca.Location = new System.Drawing.Point(62, 82);
            this.txt_codigoCatraca.Name = "txt_codigoCatraca";
            this.txt_codigoCatraca.Size = new System.Drawing.Size(90, 20);
            this.txt_codigoCatraca.TabIndex = 0;
            // 
            // rdbP1
            // 
            this.rdbP1.AutoSize = true;
            this.rdbP1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbP1.Location = new System.Drawing.Point(64, 238);
            this.rdbP1.Name = "rdbP1";
            this.rdbP1.Size = new System.Drawing.Size(37, 18);
            this.rdbP1.TabIndex = 3;
            this.rdbP1.TabStop = true;
            this.rdbP1.Text = "P1";
            this.rdbP1.UseVisualStyleBackColor = true;
            // 
            // rdbP2
            // 
            this.rdbP2.AutoSize = true;
            this.rdbP2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbP2.Location = new System.Drawing.Point(115, 238);
            this.rdbP2.Name = "rdbP2";
            this.rdbP2.Size = new System.Drawing.Size(37, 18);
            this.rdbP2.TabIndex = 670;
            this.rdbP2.TabStop = true;
            this.rdbP2.Text = "P2";
            this.rdbP2.UseVisualStyleBackColor = true;
            // 
            // msk_dataCatraca
            // 
            this.msk_dataCatraca.HideSelection = false;
            this.msk_dataCatraca.Location = new System.Drawing.Point(62, 184);
            this.msk_dataCatraca.Mask = "00/00/0000";
            this.msk_dataCatraca.Name = "msk_dataCatraca";
            this.msk_dataCatraca.Size = new System.Drawing.Size(64, 20);
            this.msk_dataCatraca.TabIndex = 2;
            this.msk_dataCatraca.ValidatingType = typeof(System.DateTime);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(62, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 673;
            this.metroLabel1.Text = "Código:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(62, 106);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 674;
            this.metroLabel2.Text = "Nome Operador:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 675;
            this.metroLabel3.Text = "Data:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(62, 216);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 676;
            this.metroLabel4.Text = "Plataforma:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(62, 417);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 26);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Salvar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cbbOperador
            // 
            this.cbbOperador.FormattingEnabled = true;
            this.cbbOperador.ItemHeight = 23;
            this.cbbOperador.Location = new System.Drawing.Point(64, 128);
            this.cbbOperador.Name = "cbbOperador";
            this.cbbOperador.Size = new System.Drawing.Size(189, 29);
            this.cbbOperador.TabIndex = 1;
            this.cbbOperador.UseSelectable = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::programa_teleferico.Properties.Resources.logo_log1;
            this.pictureBox2.Location = new System.Drawing.Point(350, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 679;
            this.pictureBox2.TabStop = false;
            // 
            // tela_abertura_catraca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(467, 535);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbbOperador);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.msk_dataCatraca);
            this.Controls.Add(this.rdbP2);
            this.Controls.Add(this.rdbP1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_codigoCatraca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_abertura_catraca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de catraca";
            this.Load += new System.EventHandler(this.tela_abertura_catraca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInicialCatraca;
        private System.Windows.Forms.TextBox txt_codigoCatraca;
        private System.Windows.Forms.RadioButton rdbP1;
        private System.Windows.Forms.RadioButton rdbP2;
        private System.Windows.Forms.MaskedTextBox msk_dataCatraca;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cbbOperador;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}