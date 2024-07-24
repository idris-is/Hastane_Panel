namespace Hastane_Panel
{
    partial class FrmBransPaneli
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
            TxtBransid = new TextBox();
            TxtBransAd = new TextBox();
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
            label1.Location = new Point(39, 55);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 0;
            label1.Text = "Branş id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 106);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 1;
            label2.Text = "Branş Ad:";
            // 
            // TxtBransid
            // 
            TxtBransid.Location = new Point(153, 52);
            TxtBransid.Name = "TxtBransid";
            TxtBransid.Size = new Size(198, 39);
            TxtBransid.TabIndex = 2;
            // 
            // TxtBransAd
            // 
            TxtBransAd.Location = new Point(153, 103);
            TxtBransAd.Name = "TxtBransAd";
            TxtBransAd.Size = new Size(198, 39);
            TxtBransAd.TabIndex = 3;
            // 
            // BtnEkle
            // 
            BtnEkle.Location = new Point(153, 148);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(94, 40);
            BtnEkle.TabIndex = 4;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Location = new Point(257, 148);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(94, 40);
            BtnSil.TabIndex = 5;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Location = new Point(153, 194);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(198, 40);
            BtnGuncelle.TabIndex = 6;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 57;
            dataGridView1.Size = new Size(541, 182);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // FrmBransPaneli
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(941, 270);
            Controls.Add(dataGridView1);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(TxtBransAd);
            Controls.Add(TxtBransid);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmBransPaneli";
            Text = "Branş Paneli";
            Load += FrmBransPaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtBransid;
        private TextBox TxtBransAd;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnGuncelle;
        private DataGridView dataGridView1;
    }
}