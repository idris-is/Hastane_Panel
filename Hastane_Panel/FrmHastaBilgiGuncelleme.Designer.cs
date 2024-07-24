namespace Hastane_Panel
{
    partial class FrmHastaBilgiGuncelleme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            MskTc = new MaskedTextBox();
            MskTelefon = new MaskedTextBox();
            CmbCinsiyet = new ComboBox();
            BtnGuncelle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 61);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 120);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 171);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 233);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 288);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 4;
            label5.Text = "Şifre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 337);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 5;
            label6.Text = "Cinsiyet:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(172, 58);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(180, 39);
            TxtAd.TabIndex = 0;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(172, 117);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(180, 39);
            TxtSoyad.TabIndex = 1;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(172, 285);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(180, 39);
            TxtSifre.TabIndex = 4;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(172, 168);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(180, 39);
            MskTc.TabIndex = 2;
            MskTc.ValidatingType = typeof(int);
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(172, 230);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(180, 39);
            MskTelefon.TabIndex = 3;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbCinsiyet.Location = new Point(172, 334);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(180, 40);
            CmbCinsiyet.TabIndex = 5;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(172, 401);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(180, 48);
            BtnGuncelle.TabIndex = 6;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // FrmHastaBilgiGuncelleme
            // 
            AcceptButton = BtnGuncelle;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(473, 527);
            Controls.Add(BtnGuncelle);
            Controls.Add(CmbCinsiyet);
            Controls.Add(MskTelefon);
            Controls.Add(MskTc);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaBilgiGuncelleme";
            Text = "Hasta Bilgilerini Güncelleme Paneli";
            Load += FrmHastaBilgiGuncelleme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private MaskedTextBox MskTc;
        private MaskedTextBox MskTelefon;
        private ComboBox CmbCinsiyet;
        private Button BtnGuncelle;
    }
}