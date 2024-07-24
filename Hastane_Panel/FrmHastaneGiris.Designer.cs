namespace Hastane_Panel
{
    partial class FrmHastaneGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaneGiris));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnHastaGiris = new Button();
            BtnDoktorGiris = new Button();
            BtnSekreterGiris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Calligraphy", 22.195488F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 56);
            label1.Name = "label1";
            label1.Size = new Size(479, 53);
            label1.TabIndex = 0;
            label1.Text = "Hastane Giriş Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 479);
            label2.Name = "label2";
            label2.Size = new Size(130, 32);
            label2.TabIndex = 1;
            label2.Text = "Hasta Giriş";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 479);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 2;
            label3.Text = "Doktor Giriş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(915, 479);
            label4.Name = "label4";
            label4.Size = new Size(160, 32);
            label4.TabIndex = 3;
            label4.Text = "Sekreter Giriş";
            // 
            // BtnHastaGiris
            // 
            BtnHastaGiris.BackgroundImage = (Image)resources.GetObject("BtnHastaGiris.BackgroundImage");
            BtnHastaGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnHastaGiris.Location = new Point(123, 220);
            BtnHastaGiris.Name = "BtnHastaGiris";
            BtnHastaGiris.Size = new Size(242, 217);
            BtnHastaGiris.TabIndex = 4;
            BtnHastaGiris.UseVisualStyleBackColor = true;
            BtnHastaGiris.Click += BtnHastaGiris_Click;
            // 
            // BtnDoktorGiris
            // 
            BtnDoktorGiris.BackgroundImage = (Image)resources.GetObject("BtnDoktorGiris.BackgroundImage");
            BtnDoktorGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnDoktorGiris.Location = new Point(503, 220);
            BtnDoktorGiris.Name = "BtnDoktorGiris";
            BtnDoktorGiris.Size = new Size(242, 217);
            BtnDoktorGiris.TabIndex = 5;
            BtnDoktorGiris.UseVisualStyleBackColor = true;
            BtnDoktorGiris.Click += BtnDoktorGiris_Click;
            // 
            // BtnSekreterGiris
            // 
            BtnSekreterGiris.BackgroundImage = (Image)resources.GetObject("BtnSekreterGiris.BackgroundImage");
            BtnSekreterGiris.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSekreterGiris.Location = new Point(873, 220);
            BtnSekreterGiris.Name = "BtnSekreterGiris";
            BtnSekreterGiris.Size = new Size(242, 217);
            BtnSekreterGiris.TabIndex = 6;
            BtnSekreterGiris.UseVisualStyleBackColor = true;
            BtnSekreterGiris.Click += BtnSekreterGiris_Click;
            // 
            // FrmHastaneGiris
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1226, 615);
            Controls.Add(BtnSekreterGiris);
            Controls.Add(BtnDoktorGiris);
            Controls.Add(BtnHastaGiris);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Corbel", 14.0751877F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaneGiris";
            Text = "Hastane Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnHastaGiris;
        private Button BtnDoktorGiris;
        private Button BtnSekreterGiris;
    }
}
