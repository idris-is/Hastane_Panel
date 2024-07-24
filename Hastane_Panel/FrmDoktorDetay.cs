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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        public string tc;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;
            NpgsqlCommand komut = new NpgsqlCommand("Select \"DoktorAd\",\"DoktorSoyad\" from \"Tbl_Doktorlar\" where \"DoktorTC\" = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            NpgsqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                LblAdSoyad.Text = dataReader[0] + " " + dataReader[1];
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from \"Tbl_Randevular\" where \"RandevuDoktor\"= '" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frmDoktorBilgiDuzenle = new FrmDoktorBilgiDuzenle();
            frmDoktorBilgiDuzenle.tc = LblTc.Text;
            frmDoktorBilgiDuzenle.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
