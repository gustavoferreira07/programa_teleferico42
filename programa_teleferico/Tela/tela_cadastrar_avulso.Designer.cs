namespace programa_teleferico.Tela
{
    partial class tela_cadastrar_avulso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_cadastrar_avulso));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbbContrato = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtConta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAgencia = new MetroFramework.Controls.MetroTextBox();
            this.cbbBanco = new MetroFramework.Controls.MetroComboBox();
            this.mskCel = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ttEndereco = new MetroFramework.Controls.MetroTextBox();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(217, 241);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 396);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(61, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Contrato";
            // 
            // cbbContrato
            // 
            this.cbbContrato.FormattingEnabled = true;
            this.cbbContrato.ItemHeight = 23;
            this.cbbContrato.Items.AddRange(new object[] {
            "Registrado",
            "Avulso"});
            this.cbbContrato.Location = new System.Drawing.Point(23, 418);
            this.cbbContrato.Name = "cbbContrato";
            this.cbbContrato.Size = new System.Drawing.Size(170, 29);
            this.cbbContrato.TabIndex = 8;
            this.cbbContrato.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 487);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 9;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 222);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 33;
            this.metroLabel7.Text = "Banco:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 332);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(47, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Conta:";
            // 
            // txtConta
            // 
            // 
            // 
            // 
            this.txtConta.CustomButton.Image = null;
            this.txtConta.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtConta.CustomButton.Name = "";
            this.txtConta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConta.CustomButton.TabIndex = 1;
            this.txtConta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConta.CustomButton.UseSelectable = true;
            this.txtConta.CustomButton.Visible = false;
            this.txtConta.Lines = new string[0];
            this.txtConta.Location = new System.Drawing.Point(23, 354);
            this.txtConta.MaxLength = 32767;
            this.txtConta.Name = "txtConta";
            this.txtConta.PasswordChar = '\0';
            this.txtConta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConta.SelectedText = "";
            this.txtConta.SelectionLength = 0;
            this.txtConta.SelectionStart = 0;
            this.txtConta.ShortcutsEnabled = true;
            this.txtConta.Size = new System.Drawing.Size(170, 23);
            this.txtConta.TabIndex = 7;
            this.txtConta.UseSelectable = true;
            this.txtConta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 278);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 30;
            this.metroLabel5.Text = "Agência:";
            // 
            // txtAgencia
            // 
            // 
            // 
            // 
            this.txtAgencia.CustomButton.Image = null;
            this.txtAgencia.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtAgencia.CustomButton.Name = "";
            this.txtAgencia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAgencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAgencia.CustomButton.TabIndex = 1;
            this.txtAgencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAgencia.CustomButton.UseSelectable = true;
            this.txtAgencia.CustomButton.Visible = false;
            this.txtAgencia.Lines = new string[0];
            this.txtAgencia.Location = new System.Drawing.Point(23, 300);
            this.txtAgencia.MaxLength = 32767;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.PasswordChar = '\0';
            this.txtAgencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAgencia.SelectedText = "";
            this.txtAgencia.SelectionLength = 0;
            this.txtAgencia.SelectionStart = 0;
            this.txtAgencia.ShortcutsEnabled = true;
            this.txtAgencia.Size = new System.Drawing.Size(170, 23);
            this.txtAgencia.TabIndex = 6;
            this.txtAgencia.UseSelectable = true;
            this.txtAgencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAgencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbbBanco
            // 
            this.cbbBanco.FormattingEnabled = true;
            this.cbbBanco.ItemHeight = 23;
            this.cbbBanco.Items.AddRange(new object[] {
            "Bradesco",
            "Itáu",
            "Caixa",
            "Santander",
            "Banco do Brasil"});
            this.cbbBanco.Location = new System.Drawing.Point(23, 244);
            this.cbbBanco.Name = "cbbBanco";
            this.cbbBanco.Size = new System.Drawing.Size(170, 29);
            this.cbbBanco.TabIndex = 5;
            this.cbbBanco.UseSelectable = true;
            this.cbbBanco.SelectedIndexChanged += new System.EventHandler(this.cbbBanco_SelectedIndexChanged_1);
            // 
            // mskCel
            // 
            this.mskCel.Location = new System.Drawing.Point(139, 138);
            this.mskCel.Mask = "(00) 00000-0000";
            this.mskCel.Name = "mskCel";
            this.mskCel.Size = new System.Drawing.Size(100, 20);
            this.mskCel.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(139, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Celular:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 169);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Endereço:";
            // 
            // ttEndereco
            // 
            // 
            // 
            // 
            this.ttEndereco.CustomButton.Image = null;
            this.ttEndereco.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.ttEndereco.CustomButton.Name = "";
            this.ttEndereco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ttEndereco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ttEndereco.CustomButton.TabIndex = 1;
            this.ttEndereco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ttEndereco.CustomButton.UseSelectable = true;
            this.ttEndereco.CustomButton.Visible = false;
            this.ttEndereco.Lines = new string[0];
            this.ttEndereco.Location = new System.Drawing.Point(23, 191);
            this.ttEndereco.MaxLength = 32767;
            this.ttEndereco.Name = "ttEndereco";
            this.ttEndereco.PasswordChar = '\0';
            this.ttEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ttEndereco.SelectedText = "";
            this.ttEndereco.SelectionLength = 0;
            this.ttEndereco.SelectionStart = 0;
            this.ttEndereco.ShortcutsEnabled = true;
            this.ttEndereco.Size = new System.Drawing.Size(265, 23);
            this.ttEndereco.TabIndex = 4;
            this.ttEndereco.UseSelectable = true;
            this.ttEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ttEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(23, 138);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(100, 20);
            this.mskCpf.TabIndex = 1;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 116);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(36, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "CPF:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 65);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Nome:";
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(23, 87);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(265, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cadastro de funcionário";
            // 
            // tela_cadastrar_avulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(454, 566);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.cbbContrato);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.cbbBanco);
            this.Controls.Add(this.mskCel);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ttEndereco);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_cadastrar_avulso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro ";
            this.Load += new System.EventHandler(this.tela_cadastrar_avulso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbbContrato;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtConta;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtAgencia;
        private MetroFramework.Controls.MetroComboBox cbbBanco;
        private System.Windows.Forms.MaskedTextBox mskCel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox ttEndereco;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.Label label3;
    }
}