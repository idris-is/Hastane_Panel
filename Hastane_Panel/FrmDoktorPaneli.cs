using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Panel
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("Select * from \"Tbl_Doktorlar\"", bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;


            NpgsqlCommand branslar = new NpgsqlCommand("Select \"BransAd\" from \"Tbl_Branslar\"", bgl.baglanti());
            NpgsqlDataReader dr = branslar.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand doktorEkle = new NpgsqlCommand("insert into \"Tbl_Doktorlar\" (\"DoktorAd\",\"DoktorSoyad\",\"DoktorBrans\",\"DoktorTC\",\"DoktorSifre\") values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            doktorEkle.Parameters.AddWithValue("@p1", TxtAd.Text);
            doktorEkle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            doktorEkle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            doktorEkle.Parameters.AddWithValue("@p4", MskTc.Text);
            doktorEkle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            doktorEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand doktorSil = new NpgsqlCommand("delete from \"Tbl_Doktorlar\" where \"DoktorTC\" = @p1", bgl.baglanti());
            doktorSil.Parameters.AddWithValue("@p1", MskTc.Text);
            doktorSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand doktorGuncelle = new NpgsqlCommand("update \"Tbl_Doktorlar\" set \"DoktorAd\"=@p1,\"DoktorSoyad\"=@p2,\"DoktorBrans\" = @p3,\"DoktorSifre\"=@p5 where \"DoktorTC\" = @p4", bgl.baglanti());
            doktorGuncelle.Parameters.AddWithValue("@p1", TxtAd.Text);
            doktorGuncelle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            doktorGuncelle.Parameters.AddWithValue("@p3", CmbBrans.Text);
            doktorGuncelle.Parameters.AddWithValue("@p4", MskTc.Text);
            doktorGuncelle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            doktorGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
