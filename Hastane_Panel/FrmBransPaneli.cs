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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand bransEkle = new NpgsqlCommand("insert into \"Tbl_Branslar\" (\"BransAd\") values (@p1)", bgl.baglanti());
            bransEkle.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            bransEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter("select * from \"Tbl_Branslar\"", bgl.baglanti());
            nda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtBransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand bransSil = new NpgsqlCommand("delete from \"Tbl_Branslar\" where \"Bransid\"=@p1", bgl.baglanti());
            bransSil.Parameters.AddWithValue("@p1", TxtBransid.Text);
            bransSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand bransGuncelle = new NpgsqlCommand("update \"Tbl_Branslar\" set \"BransAd\" = @p1 where \"Bransid\"= @p2 ",bgl.baglanti());
            bransGuncelle.Parameters.AddWithValue("@p1", TxtBransAd.Text);
            bransGuncelle.Parameters.AddWithValue("@p2",TxtBransid.Text);
            bransGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
