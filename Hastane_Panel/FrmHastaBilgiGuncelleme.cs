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
    public partial class FrmHastaBilgiGuncelleme : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FrmHastaBilgiGuncelleme()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("update \"Tbl_Hastalar\" set \"HastaAd\"=@p1,\"HastaSoyad\"=@p2,\"HastaTelefon\"=@p3,\"HastaSifre\"=@p4,\"HastaCinsiyet\"=@p5 where \"HastaTc\"= @p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3",MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4",TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5",CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6",MskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public String tcNO;

        private void FrmHastaBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            MskTc.Text = tcNO;
            NpgsqlCommand komut = new NpgsqlCommand("Select * from \"Tbl_Hastalar\" where \"HastaTc\" = @p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) 
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }

            bgl.baglanti().Close();
        }
    }
}
