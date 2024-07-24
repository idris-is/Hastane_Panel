using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Panel
{
    public partial class FrmHastaDetay : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;

            //Ad Soyad Çekme
            NpgsqlCommand komut = new NpgsqlCommand("Select \"HastaAd\",\"HastaSoyad\" from \"Tbl_Hastalar\" where \"HastaTc\"=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            NpgsqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                LblAdSoyad.Text = dataReader[0] + " " + dataReader[1];
            }
            bgl.baglanti().Close();

            //Randevu Listeleme
            DataTable dt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter("Select * from \"Tbl_Randevular\" where \"HastaTc\"= @p1", bgl.baglanti());
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            nda.SelectCommand.Parameters.AddWithValue("@p1", tc);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            nda.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları çekme
            NpgsqlCommand komut2 = new NpgsqlCommand("Select \"BransAd\" from \"Tbl_Branslar\"", bgl.baglanti());
            NpgsqlDataReader ndr = komut2.ExecuteReader();
            while (ndr.Read())
            {
                CmbBrans.Items.Add(ndr[0]);
            }

            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            NpgsqlCommand komut3 = new NpgsqlCommand("Select \"DoktorAd\", \"DoktorSoyad\" from \"Tbl_Doktorlar\" where \"DoktorBrans\"=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            NpgsqlDataReader ndr3 = komut3.ExecuteReader();
            while (ndr3.Read())
            {
                CmbDoktor.Items.Add(ndr3[0] + " " + ndr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter nda = new NpgsqlDataAdapter("Select * from \"Tbl_Randevular\" where \"RandevuBrans\"='" + CmbBrans.Text + "'" + " and \"RandevuDoktor\"='" + CmbDoktor.Text + "' and \"RandevuDurum\"= False", bgl.baglanti());
            nda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LinkLblBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LinkLblBilgileriDuzenle_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiGuncelleme frmHastaBilgiGuncelleme = new FrmHastaBilgiGuncelleme();
            frmHastaBilgiGuncelleme.tcNO = LblTc.Text;
            frmHastaBilgiGuncelleme.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            NpgsqlCommand randevuAl = new NpgsqlCommand("update \"Tbl_Randevular\" set \"RandevuDurum\"=True,\"HastaTc\"=@p1,\"HastaSikayet\" = @p2 where \"Randevuid\" = @p3",bgl.baglanti());
            randevuAl.Parameters.AddWithValue("@p1",LblTc.Text);
            randevuAl.Parameters.AddWithValue("@p2",RchTxtSikayet.Text);
            randevuAl.Parameters.AddWithValue("@p3",int.Parse(Txtid.Text));
            randevuAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
