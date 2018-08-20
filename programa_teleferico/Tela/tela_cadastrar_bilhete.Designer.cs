namespace programa_teleferico.Tela
{
    partial class tela_cadastrar_bilhete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_cadastrar_bilhete));
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txt_qtde = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbbTipoBilhete = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(112, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Quantidade Total:";
            // 
            // txt_qtde
            // 
            // 
            // 
            // 
            this.txt_qtde.CustomButton.Image = null;
            this.txt_qtde.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txt_qtde.CustomButton.Name = "";
            this.txt_qtde.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_qtde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_qtde.CustomButton.TabIndex = 1;
            this.txt_qtde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_qtde.CustomButton.UseSelectable = true;
            this.txt_qtde.CustomButton.Visible = false;
            this.txt_qtde.Lines = new string[0];
            this.txt_qtde.Location = new System.Drawing.Point(32, 232);
            this.txt_qtde.MaxLength = 32767;
            this.txt_qtde.Name = "txt_qtde";
            this.txt_qtde.PasswordChar = '\0';
            this.txt_qtde.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_qtde.SelectedText = "";
            this.txt_qtde.SelectionLength = 0;
            this.txt_qtde.SelectionStart = 0;
            this.txt_qtde.ShortcutsEnabled = true;
            this.txt_qtde.Size = new System.Drawing.Size(143, 23);
            this.txt_qtde.TabIndex = 6;
            this.txt_qtde.UseSelectable = true;
            this.txt_qtde.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_qtde.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 156);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Tipo de blihete:";
            // 
            // cbbTipoBilhete
            // 
            this.cbbTipoBilhete.FormattingEnabled = true;
            this.cbbTipoBilhete.ItemHeight = 23;
            this.cbbTipoBilhete.Items.AddRange(new object[] {
            "Ida/ Verde",
            "Ida-Volta/ Verde",
            "Ida/ Vermelho",
            "Ida-Volta/ Vermelho"});
            this.cbbTipoBilhete.Location = new System.Drawing.Point(32, 178);
            this.cbbTipoBilhete.Name = "cbbTipoBilhete";
            this.cbbTipoBilhete.Size = new System.Drawing.Size(189, 29);
            this.cbbTipoBilhete.TabIndex = 4;
            this.cbbTipoBilhete.UseSelectable = true;
            this.cbbTipoBilhete.SelectedIndexChanged += new System.EventHandler(this.cbbTipoBilhete_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(32, 281);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // tela_cadastrar_bilhete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txt_qtde);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbTipoBilhete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_cadastrar_bilhete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro entrada de  bilhetes:";
            this.Load += new System.EventHandler(this.tela_cadastrar_bilhete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txt_qtde;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroComboBox cbbTipoBilhete;
        private MetroFramework.Controls.MetroButton metroButton1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
    }
}