namespace Hastane_Panel
{
    partial class FrmSekreterDetay
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
            groupBox1 = new GroupBox();
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTc = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOlustur = new Button();
            RchDuyuru = new RichTextBox();
            groupBox3 = new GroupBox();
            ChcDurum = new CheckBox();
            MskTc = new MaskedTextBox();
            CmbDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            MskSaat = new MaskedTextBox();
            BtnKaydet = new Button();
            MskTarih = new MaskedTextBox();
            Txtid = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox4 = new GroupBox();
            BtnDuyurular = new Button();
            BtnRandevuListesi = new Button();
            BtnBransPaneli = new Button();
            BtnDoktorPaneli = new Button();
            groupBox5 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox6 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTc);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(384, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Bilgi";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(163, 114);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(97, 32);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "null null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 114);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // LblTc
            // 
            LblTc.AutoSize = true;
            LblTc.Location = new Point(163, 57);
            LblTc.Name = "LblTc";
            LblTc.Size = new Size(157, 32);
            LblTc.TabIndex = 1;
            LblTc.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 57);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "Tc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOlustur);
            groupBox2.Controls.Add(RchDuyuru);
            groupBox2.Location = new Point(14, 216);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(384, 335);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // BtnOlustur
            // 
            BtnOlustur.Location = new Point(8, 269);
            BtnOlustur.Name = "BtnOlustur";
            BtnOlustur.Size = new Size(368, 58);
            BtnOlustur.TabIndex = 1;
            BtnOlustur.Text = "Oluştur";
            BtnOlustur.UseVisualStyleBackColor = true;
            BtnOlustur.Click += BtnOlustur_Click;
            // 
            // RchDuyuru
            // 
            RchDuyuru.Location = new Point(8, 47);
            RchDuyuru.Name = "RchDuyuru";
            RchDuyuru.Size = new Size(368, 216);
            RchDuyuru.TabIndex = 0;
            RchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ChcDurum);
            groupBox3.Controls.Add(MskTc);
            groupBox3.Controls.Add(CmbDoktor);
            groupBox3.Controls.Add(CmbBrans);
            groupBox3.Controls.Add(MskSaat);
            groupBox3.Controls.Add(BtnKaydet);
            groupBox3.Controls.Add(MskTarih);
            groupBox3.Controls.Add(Txtid);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(408, 14);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(372, 537);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Paneli";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // ChcDurum
            // 
            ChcDurum.AutoSize = true;
            ChcDurum.Location = new Point(173, 369);
            ChcDurum.Name = "ChcDurum";
            ChcDurum.Size = new Size(110, 36);
            ChcDurum.TabIndex = 5;
            ChcDurum.Text = "Durum";
            ChcDurum.UseVisualStyleBackColor = true;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(171, 324);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(166, 39);
            MskTc.TabIndex = 4;
            MskTc.ValidatingType = typeof(int);
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(171, 270);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(168, 40);
            CmbDoktor.TabIndex = 3;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(171, 210);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(168, 40);
            CmbBrans.TabIndex = 2;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // MskSaat
            // 
            MskSaat.Location = new Point(173, 153);
            MskSaat.Mask = "00:00";
            MskSaat.Name = "MskSaat";
            MskSaat.Size = new Size(166, 39);
            MskSaat.TabIndex = 1;
            MskSaat.ValidatingType = typeof(DateTime);
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(94, 443);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(243, 49);
            BtnKaydet.TabIndex = 6;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // MskTarih
            // 
            MskTarih.Location = new Point(171, 95);
            MskTarih.Mask = "00/00/0000";
            MskTarih.Name = "MskTarih";
            MskTarih.Size = new Size(166, 39);
            MskTarih.TabIndex = 0;
            MskTarih.ValidatingType = typeof(DateTime);
            // 
            // Txtid
            // 
            Txtid.Location = new Point(171, 40);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(166, 39);
            Txtid.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(116, 327);
            label10.Name = "label10";
            label10.Size = new Size(44, 32);
            label10.TabIndex = 5;
            label10.Text = "Tc:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 273);
            label9.Name = "label9";
            label9.Size = new Size(97, 32);
            label9.TabIndex = 4;
            label9.Text = "Doktor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 213);
            label8.Name = "label8";
            label8.Size = new Size(83, 32);
            label8.TabIndex = 3;
            label8.Text = "Branş:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(90, 156);
            label7.Name = "label7";
            label7.Size = new Size(70, 32);
            label7.TabIndex = 2;
            label7.Text = "Saat:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 98);
            label6.Name = "label6";
            label6.Size = new Size(75, 32);
            label6.TabIndex = 1;
            label6.Text = "Tarih:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 43);
            label5.Name = "label5";
            label5.Size = new Size(41, 32);
            label5.TabIndex = 0;
            label5.Text = "id:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnDuyurular);
            groupBox4.Controls.Add(BtnRandevuListesi);
            groupBox4.Controls.Add(BtnBransPaneli);
            groupBox4.Controls.Add(BtnDoktorPaneli);
            groupBox4.Location = new Point(14, 561);
            groupBox4.Margin = new Padding(5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(5);
            groupBox4.Size = new Size(766, 161);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hızlı Erişim";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(558, 73);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(173, 58);
            BtnDuyurular.TabIndex = 11;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.TextImageRelation = TextImageRelation.TextAboveImage;
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // BtnRandevuListesi
            // 
            BtnRandevuListesi.Location = new Point(379, 73);
            BtnRandevuListesi.Name = "BtnRandevuListesi";
            BtnRandevuListesi.Size = new Size(173, 58);
            BtnRandevuListesi.TabIndex = 10;
            BtnRandevuListesi.Text = "Randevu Listesi";
            BtnRandevuListesi.UseVisualStyleBackColor = true;
            BtnRandevuListesi.Click += BtnRandevuListesi_Click;
            // 
            // BtnBransPaneli
            // 
            BtnBransPaneli.Location = new Point(200, 73);
            BtnBransPaneli.Name = "BtnBransPaneli";
            BtnBransPaneli.Size = new Size(173, 58);
            BtnBransPaneli.TabIndex = 9;
            BtnBransPaneli.Text = "Branş Paneli";
            BtnBransPaneli.UseVisualStyleBackColor = true;
            BtnBransPaneli.Click += BtnBransPaneli_Click;
            // 
            // BtnDoktorPaneli
            // 
            BtnDoktorPaneli.Location = new Point(21, 73);
            BtnDoktorPaneli.Name = "BtnDoktorPaneli";
            BtnDoktorPaneli.Size = new Size(173, 58);
            BtnDoktorPaneli.TabIndex = 8;
            BtnDoktorPaneli.Text = "Doktor Paneli";
            BtnDoktorPaneli.UseVisualStyleBackColor = true;
            BtnDoktorPaneli.Click += BtnDoktorPaneli_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridView1);
            groupBox5.Location = new Point(790, 14);
            groupBox5.Margin = new Padding(5);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(5);
            groupBox5.Size = new Size(648, 348);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(5, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(638, 306);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView2);
            groupBox6.Location = new Point(790, 372);
            groupBox6.Margin = new Padding(5);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(5);
            groupBox6.Size = new Size(648, 350);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(5, 37);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 57;
            dataGridView2.Size = new Size(638, 308);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1447, 737);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            Text = "Sekreter Detay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTc;
        private Label label1;
        private Button BtnOlustur;
        private RichTextBox RchDuyuru;
        private MaskedTextBox MskTarih;
        private TextBox Txtid;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button BtnRandevuListesi;
        private Button BtnBransPaneli;
        private Button BtnDoktorPaneli;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private MaskedTextBox MskTc;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private MaskedTextBox MskSaat;
        private Button BtnKaydet;
        private CheckBox ChcDurum;
        private Button BtnDuyurular;
    }
}