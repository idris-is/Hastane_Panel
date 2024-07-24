namespace Hastane_Panel
{
    partial class FrmHastaKayitPaneli
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
            label7 = new Label();
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            MskTc = new MaskedTextBox();
            TxtSifre = new TextBox();
            CmbCinsiyet = new ComboBox();
            MskTelefon = new MaskedTextBox();
            BtnKayitOl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 22.195488F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(452, 53);
            label1.TabIndex = 0;
            label1.Text = "Hasta Kayıt Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 99);
            label2.Name = "label2";
            label2.Size = new Size(52, 32);
            label2.TabIndex = 1;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 164);
            label3.Name = "label3";
            label3.Size = new Size(88, 32);
            label3.TabIndex = 2;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(115, 236);
            label4.Name = "label4";
            label4.Size = new Size(44, 32);
            label4.TabIndex = 3;
            label4.Text = "Tc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 296);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 4;
            label5.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 361);
            label6.Name = "label6";
            label6.Size = new Size(71, 32);
            label6.TabIndex = 5;
            label6.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 423);
            label7.Name = "label7";
            label7.Size = new Size(107, 32);
            label7.TabIndex = 6;
            label7.Text = "Cinsiyet:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(165, 96);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(188, 39);
            TxtAd.TabIndex = 0;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(165, 161);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(188, 39);
            TxtSoyad.TabIndex = 1;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(165, 233);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(188, 39);
            MskTc.TabIndex = 2;
            MskTc.ValidatingType = typeof(int);
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(165, 358);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(188, 39);
            TxtSifre.TabIndex = 4;
            // 
            // CmbCinsiyet
            // 
            CmbCinsiyet.FormattingEnabled = true;
            CmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            CmbCinsiyet.Location = new Point(165, 420);
            CmbCinsiyet.Name = "CmbCinsiyet";
            CmbCinsiyet.Size = new Size(188, 40);
            CmbCinsiyet.TabIndex = 5;
            // 
            // MskTelefon
            // 
            MskTelefon.Location = new Point(165, 293);
            MskTelefon.Mask = "(999) 000-0000";
            MskTelefon.Name = "MskTelefon";
            MskTelefon.Size = new Size(188, 39);
            MskTelefon.TabIndex = 3;
            // 
            // BtnKayitOl
            // 
            BtnKayitOl.Location = new Point(165, 487);
            BtnKayitOl.Name = "BtnKayitOl";
            BtnKayitOl.Size = new Size(188, 56);
            BtnKayitOl.TabIndex = 6;
            BtnKayitOl.Text = "Kayıt Ol";
            BtnKayitOl.UseVisualStyleBackColor = true;
            BtnKayitOl.Click += BtnKayitOl_Click;
            // 
            // FrmHastaKayitPaneli
            // 
            AcceptButton = BtnKayitOl;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(495, 555);
            Controls.Add(BtnKayitOl);
            Controls.Add(MskTelefon);
            Controls.Add(CmbCinsiyet);
            Controls.Add(TxtSifre);
            Controls.Add(MskTc);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaKayitPaneli";
            Text = "Hasta Kayıt Paneli";
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
        private Label label7;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private MaskedTextBox MskTc;
        private TextBox TxtSifre;
        private ComboBox CmbCinsiyet;
        private MaskedTextBox MskTelefon;
        private Button BtnKayitOl;
    }
}