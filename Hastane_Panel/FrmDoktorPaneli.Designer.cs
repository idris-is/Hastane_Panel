namespace Hastane_Panel
{
    partial class FrmDoktorPaneli
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
            CmbBrans = new ComboBox();
            MskTc = new MaskedTextBox();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(52, 32);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 147);
            label3.Name = "label3";
            label3.Size = new Size(83, 32);
            label3.TabIndex = 2;
            label3.Text = "Branş:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 202);
            label4.Name = "label4";
            label4.Size = new Size(44, 32);
            label4.TabIndex = 3;
            label4.Text = "Tc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 261);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 4;
            label5.Text = "Şifre:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(108, 38);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(198, 39);
            TxtAd.TabIndex = 0;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(108, 90);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(198, 39);
            TxtSoyad.TabIndex = 1;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(108, 254);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(198, 39);
            TxtSifre.TabIndex = 4;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(109, 144);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(197, 40);
            CmbBrans.TabIndex = 2;
            // 
            // MskTc
            // 
            MskTc.Location = new Point(108, 199);
            MskTc.Mask = "00000000000";
            MskTc.Name = "MskTc";
            MskTc.Size = new Size(198, 39);
            MskTc.TabIndex = 3;
            MskTc.ValidatingType = typeof(int);
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(109, 311);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(92, 50);
            BtnEkle.TabIndex = 5;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(213, 311);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(93, 50);
            BtnSil.TabIndex = 6;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(108, 367);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(198, 46);
            BtnGuncelle.TabIndex = 7;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(333, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(1018, 375);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1363, 457);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(MskTc);
            Controls.Add(CmbBrans);
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
            MaximizeBox = false;
            Name = "FrmDoktorPaneli";
            Text = "Doktor Paneli";
            Load += FrmDoktorPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ComboBox CmbBrans;
        private MaskedTextBox MskTc;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
        private DataGridView dataGridView1;
    }
}