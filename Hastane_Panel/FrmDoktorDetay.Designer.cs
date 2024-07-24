namespace Hastane_Panel
{
    partial class FrmDoktorDetay
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
            RchSikayet = new RichTextBox();
            label5 = new Label();
            groupBox3 = new GroupBox();
            BtnCikis = new Button();
            BtnDuyurular = new Button();
            BtnBilgiDuzenle = new Button();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTc);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 161);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Bilgileri";
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(178, 94);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(105, 32);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 94);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // LblTc
            // 
            LblTc.AutoSize = true;
            LblTc.Location = new Point(178, 44);
            LblTc.Name = "LblTc";
            LblTc.Size = new Size(157, 32);
            LblTc.TabIndex = 1;
            LblTc.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 44);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "Tc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RchSikayet);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(411, 317);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şikayet";
            // 
            // RchSikayet
            // 
            RchSikayet.Location = new Point(15, 70);
            RchSikayet.Name = "RchSikayet";
            RchSikayet.Size = new Size(390, 266);
            RchSikayet.TabIndex = 2;
            RchSikayet.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 35);
            label5.Name = "label5";
            label5.Size = new Size(101, 32);
            label5.TabIndex = 1;
            label5.Text = "Şikayet:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCikis);
            groupBox3.Controls.Add(BtnDuyurular);
            groupBox3.Controls.Add(BtnBilgiDuzenle);
            groupBox3.Location = new Point(12, 521);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(411, 214);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hızlı Erişimler";
            // 
            // BtnCikis
            // 
            BtnCikis.Location = new Point(15, 133);
            BtnCikis.Name = "BtnCikis";
            BtnCikis.Size = new Size(378, 51);
            BtnCikis.TabIndex = 2;
            BtnCikis.Text = "Çıkış";
            BtnCikis.UseVisualStyleBackColor = true;
            BtnCikis.Click += BtnCikis_Click;
            // 
            // BtnDuyurular
            // 
            BtnDuyurular.Location = new Point(217, 59);
            BtnDuyurular.Name = "BtnDuyurular";
            BtnDuyurular.Size = new Size(176, 59);
            BtnDuyurular.TabIndex = 1;
            BtnDuyurular.Text = "Duyurular";
            BtnDuyurular.UseVisualStyleBackColor = true;
            BtnDuyurular.Click += BtnDuyurular_Click;
            // 
            // BtnBilgiDuzenle
            // 
            BtnBilgiDuzenle.Location = new Point(15, 59);
            BtnBilgiDuzenle.Name = "BtnBilgiDuzenle";
            BtnBilgiDuzenle.Size = new Size(176, 59);
            BtnBilgiDuzenle.TabIndex = 0;
            BtnBilgiDuzenle.Text = "Bilgi Düzenle";
            BtnBilgiDuzenle.UseVisualStyleBackColor = true;
            BtnBilgiDuzenle.Click += BtnBilgiDuzenle_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(429, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(978, 723);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(972, 685);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1419, 747);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorDetay";
            Text = "Doktor Detay";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTc;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private GroupBox groupBox3;
        private RichTextBox RchSikayet;
        private Button BtnCikis;
        private Button BtnDuyurular;
        private Button BtnBilgiDuzenle;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}