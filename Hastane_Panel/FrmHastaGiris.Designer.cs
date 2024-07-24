namespace Hastane_Panel
{
    partial class FrmHastaGiris
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
            BtnGirisYap = new Button();
            TxtSifre = new TextBox();
            MskTc = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            LinkLblKayitOl = new LinkLabel();
            SuspendLayout();
            // 
            // BtnGirisYap
            // 
            BtnGirisYap.Location = new Point(139, 252);
            BtnGirisYap.Name = "BtnGirisYap";
            BtnGirisYap.Size = new Size(163, 45);
            BtnGirisYap.TabIndex = 11;
            BtnGirisYap.Text = "Giriş Yap";
            BtnGirisYap.UseVisualStyleBackColor = true;
            BtnGirisYap.Click += BtnGirisYap_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(139, 187);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(163, 39);
            TxtSifre.TabIndex = 10;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(139, 142);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(163, 39);
            MskTc.TabIndex = 9;
            MskTc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 190);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 8;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 145);
            label2.Name = "label2";
            label2.Size = new Size(44, 32);
            label2.TabIndex = 7;
            label2.Text = "Tc:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 20.0300751F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(389, 48);
            label1.TabIndex = 6;
            label1.Text = "Hasta Giriş Paneli";
            // 
            // LinkLblKayitOl
            // 
            LinkLblKayitOl.AutoSize = true;
            LinkLblKayitOl.Location = new Point(172, 335);
            LinkLblKayitOl.Name = "LinkLblKayitOl";
            LinkLblKayitOl.Size = new Size(99, 32);
            LinkLblKayitOl.TabIndex = 12;
            LinkLblKayitOl.TabStop = true;
            LinkLblKayitOl.Text = "Kayıt Ol";
            LinkLblKayitOl.LinkClicked += LinkLblKayitOl_LinkClicked;
            // 
            // FrmHastaGiris
            // 
            AcceptButton = BtnGirisYap;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(426, 437);
            Controls.Add(LinkLblKayitOl);
            Controls.Add(BtnGirisYap);
            Controls.Add(TxtSifre);
            Controls.Add(MskTc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "Hasta Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGirisYap;
        private TextBox TxtSifre;
        private MaskedTextBox MskTc;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel LinkLblKayitOl;
    }
}