using Npgsql;
using System.Data;

namespace Hastane_Panel
{
    public partial class FrmSekreterDetay : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FrmSekreterDetay()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        public String sekreterTc;

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = sekreterTc;
            NpgsqlCommand komut = new NpgsqlCommand("Select \"SekreterAdSoyad\" from \"Tbl_Sekreter\" where \"SekreterTC\" = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter("Select * from \"Tbl_Branslar\" ", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            DataTable dt2 = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("Select \"DoktorAd\",\"DoktorSoyad\",\"DoktorBrans\" from \"Tbl_Doktorlar\"", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransları Getirme
            NpgsqlCommand npgBrans = new NpgsqlCommand("Select \"BransAd\" from \"Tbl_Branslar\"", bgl.baglanti());
            NpgsqlDataReader brans = npgBrans.ExecuteReader();
            while (brans.Read())
            {
                CmbBrans.Items.Add(brans[0]);
            }

            bgl.baglanti().Close();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komutkaydet = new NpgsqlCommand("insert into \"Tbl_Randevular\" (\"RandevuTarih\",\"RandevuSaat\",\"RandevuBrans\",\"RandevuDoktor\") values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            NpgsqlCommand npgDoktorlar = new NpgsqlCommand("Select \"DoktorAd\",\"DoktorSoyad\" from \"Tbl_Doktorlar\" where \"DoktorBrans\" = @p1", bgl.baglanti());
            npgDoktorlar.Parameters.AddWithValue("@p1", CmbBrans.Text);
            NpgsqlDataReader drDoktor = npgDoktorlar.ExecuteReader();
            while (drDoktor.Read())
            {
                CmbDoktor.Items.Add(drDoktor[0] + " " + drDoktor[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            NpgsqlCommand olustur = new NpgsqlCommand("insert into \"Tbl_Duyurular\" (\"Duyuru\") values (@p1)", bgl.baglanti());
            olustur.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            olustur.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();
            frmDoktorPaneli.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm = new FrmBransPaneli();
            frm.Show();
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmr = new FrmRandevuListesi();
            frmr.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmd = new FrmDuyurular();
            frmd.Show();
        }
    }
}
