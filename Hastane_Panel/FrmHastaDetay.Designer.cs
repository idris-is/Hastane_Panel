namespace Hastane_Panel
{
    partial class FrmHastaDetay
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
            LinkLblBilgileriDuzenle = new LinkLabel();
            LblAdSoyad = new Label();
            label3 = new Label();
            LblTc = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Txtid = new TextBox();
            label2 = new Label();
            BtnRandevuAl = new Button();
            RchTxtSikayet = new RichTextBox();
            CmbDoktor = new ComboBox();
            CmbBrans = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LinkLblBilgileriDuzenle);
            groupBox1.Controls.Add(LblAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LblTc);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 242);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgi";
            // 
            // LinkLblBilgileriDuzenle
            // 
            LinkLblBilgileriDuzenle.AutoSize = true;
            LinkLblBilgileriDuzenle.Location = new Point(40, 189);
            LinkLblBilgileriDuzenle.Name = "LinkLblBilgileriDuzenle";
            LinkLblBilgileriDuzenle.Size = new Size(188, 32);
            LinkLblBilgileriDuzenle.TabIndex = 4;
            LinkLblBilgileriDuzenle.TabStop = true;
            LinkLblBilgileriDuzenle.Text = "Bilgileri Düzenle";
            LinkLblBilgileriDuzenle.LinkClicked += LinkLblBilgileriDuzenle_LinkClicked_1;
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Location = new Point(151, 130);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(105, 32);
            LblAdSoyad.TabIndex = 3;
            LblAdSoyad.Text = "Null Null";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 130);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad:";
            // 
            // LblTc
            // 
            LblTc.AutoSize = true;
            LblTc.Location = new Point(151, 74);
            LblTc.Name = "LblTc";
            LblTc.Size = new Size(157, 32);
            LblTc.TabIndex = 1;
            LblTc.Text = "00000000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 74);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "Tc:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Txtid);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(BtnRandevuAl);
            groupBox2.Controls.Add(RchTxtSikayet);
            groupBox2.Controls.Add(CmbDoktor);
            groupBox2.Controls.Add(CmbBrans);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(439, 476);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Paneli";
            // 
            // Txtid
            // 
            Txtid.Enabled = false;
            Txtid.Location = new Point(129, 45);
            Txtid.Name = "Txtid";
            Txtid.Size = new Size(260, 39);
            Txtid.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 48);
            label2.Name = "label2";
            label2.Size = new Size(41, 32);
            label2.TabIndex = 7;
            label2.Text = "id:";
            // 
            // BtnRandevuAl
            // 
            BtnRandevuAl.Location = new Point(129, 399);
            BtnRandevuAl.Name = "BtnRandevuAl";
            BtnRandevuAl.Size = new Size(260, 59);
            BtnRandevuAl.TabIndex = 6;
            BtnRandevuAl.Text = "Randevu Al";
            BtnRandevuAl.UseVisualStyleBackColor = true;
            BtnRandevuAl.Click += BtnRandevuAl_Click;
            // 
            // RchTxtSikayet
            // 
            RchTxtSikayet.Location = new Point(129, 193);
            RchTxtSikayet.Name = "RchTxtSikayet";
            RchTxtSikayet.Size = new Size(260, 200);
            RchTxtSikayet.TabIndex = 5;
            RchTxtSikayet.Text = "";
            // 
            // CmbDoktor
            // 
            CmbDoktor.FormattingEnabled = true;
            CmbDoktor.Location = new Point(129, 142);
            CmbDoktor.Name = "CmbDoktor";
            CmbDoktor.Size = new Size(260, 40);
            CmbDoktor.TabIndex = 4;
            CmbDoktor.SelectedIndexChanged += CmbDoktor_SelectedIndexChanged;
            // 
            // CmbBrans
            // 
            CmbBrans.FormattingEnabled = true;
            CmbBrans.Location = new Point(129, 94);
            CmbBrans.Name = "CmbBrans";
            CmbBrans.Size = new Size(260, 40);
            CmbBrans.TabIndex = 3;
            CmbBrans.SelectedIndexChanged += CmbBrans_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 193);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 2;
            label7.Text = "Şikayet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 145);
            label6.Name = "label6";
            label6.Size = new Size(97, 32);
            label6.TabIndex = 1;
            label6.Text = "Doktor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 97);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 0;
            label5.Text = "Branş:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(479, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(927, 335);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Geçmiş Randevular";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(921, 297);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(479, 353);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(927, 383);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 35);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 57;
            dataGridView2.Size = new Size(921, 345);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1418, 748);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            Text = "Hasta Detay";
            Load += FrmHastaDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private LinkLabel LinkLblBilgileriDuzenle;
        private Label LblAdSoyad;
        private Label label3;
        private Label LblTc;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button BtnRandevuAl;
        private RichTextBox RchTxtSikayet;
        private ComboBox CmbDoktor;
        private ComboBox CmbBrans;
        private TextBox Txtid;
        private Label label2;
    }
}