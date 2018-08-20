namespace programa_teleferico.Tela
{
    partial class tela_consulta_bilhetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_consulta_bilhetes));
            this.cbbTipoBilhete = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtQtde = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
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
            this.cbbTipoBilhete.Location = new System.Drawing.Point(23, 139);
            this.cbbTipoBilhete.Name = "cbbTipoBilhete";
            this.cbbTipoBilhete.Size = new System.Drawing.Size(189, 29);
            this.cbbTipoBilhete.TabIndex = 0;
            this.cbbTipoBilhete.UseSelectable = true;
            this.cbbTipoBilhete.SelectedIndexChanged += new System.EventHandler(this.cbbTipoBilhete_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Tipo de blihete:";
            // 
            // txtQtde
            // 
            // 
            // 
            // 
            this.txtQtde.CustomButton.Image = null;
            this.txtQtde.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtQtde.CustomButton.Name = "";
            this.txtQtde.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQtde.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQtde.CustomButton.TabIndex = 1;
            this.txtQtde.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQtde.CustomButton.UseSelectable = true;
            this.txtQtde.CustomButton.Visible = false;
            this.txtQtde.Lines = new string[0];
            this.txtQtde.Location = new System.Drawing.Point(23, 254);
            this.txtQtde.MaxLength = 32767;
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.PasswordChar = '\0';
            this.txtQtde.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQtde.SelectedText = "";
            this.txtQtde.SelectionLength = 0;
            this.txtQtde.SelectionStart = 0;
            this.txtQtde.ShortcutsEnabled = true;
            this.txtQtde.Size = new System.Drawing.Size(143, 23);
            this.txtQtde.TabIndex = 2;
            this.txtQtde.UseSelectable = true;
            this.txtQtde.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQtde.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 232);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(143, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Quantidade disponível:";
            // 
            // tela_consulta_bilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 490);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbbTipoBilhete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_consulta_bilhetes";
            this.Text = "Consulta de Bilhetes";
            this.Load += new System.EventHandler(this.tela_consulta_bilhetes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbbTipoBilhete;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtQtde;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}