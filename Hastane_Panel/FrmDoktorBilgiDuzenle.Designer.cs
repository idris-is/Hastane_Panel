namespace Hastane_Panel
{
    partial class FrmDoktorBilgiDuzenle
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
            TxtAd = new TextBox();
            TxtSoyad = new TextBox();
            TxtSifre = new TextBox();
            MskTc = new MaskedTextBox();
            CmbBrans = new ComboBox();
            BtnGuncelle = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 116);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 165);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 219);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 2;
            label3.Text = "Tc:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 270);
            label4.Name = "label4";
            label4.Size = new Size(83, 32);
            label4.TabIndex = 3;
            label4.Text = "Branş:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 320);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(201, 113);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(192, 39);
            TxtAd.TabIndex = 5;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(201, 162);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(192, 39);
            TxtSoyad.TabIndex = 6;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(201, 317);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(192, 39);
            TxtSifre.TabIndex = 7;
            TxtSifre.TextChanged += textBox3_TextChanged;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(202, 216);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(191, 39);
            MskTc.TabIndex = 8;
            MskTc.ValidatingType = typeof(int);
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(201, 267);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(191, 40);
            CmbBrans.TabIndex = 9;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(202, 378);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(190, 49);
            BtnGuncelle.TabIndex = 10;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 22.195488F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(62, 21);
            label6.Name = "label6";
            label6.Size = new Size(395, 53);
            label6.TabIndex = 11;
            label6.Text = "Bilgileri Güncelle";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            AcceptButton = BtnGuncelle;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(526, 453);
            Controls.Add(label6);
            Controls.Add(BtnGuncelle);
            Controls.Add(CmbBrans);
            Controls.Add(MskTc);
            Controls.Add(TxtSifre);
            Controls.Add(TxtSoyad);
            Controls.Add(TxtAd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MinimizeBox = false;
            Name = "FrmDoktorBilgiDuzenle";
            Text = "Doktor Bilgilerini Güncelleme Paneli";
            Load += FrmDoktorBilgiDuzenle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtAd;
        private TextBox TxtSoyad;
        private TextBox TxtSifre;
        private MaskedTextBox MskTc;
        private ComboBox CmbBrans;
        private Button BtnGuncelle;
        private Label label6;
    }
}