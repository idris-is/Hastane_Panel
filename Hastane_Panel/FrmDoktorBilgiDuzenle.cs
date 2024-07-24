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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public FrmDoktorBilgiDuzenle()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        public string tc;

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = tc;

            NpgsqlCommand duzenle = new NpgsqlCommand("select * from \"Tbl_Doktorlar\" where \"DoktorTC\"=@p1", bgl.baglanti());
            duzenle.Parameters.AddWithValue("@p1", MskTc.Text);
            NpgsqlDataReader dr = duzenle.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand guncelle = new NpgsqlCommand("update \"Tbl_Doktorlar\" set \"DoktorAd\"=@p1 , \"DoktorSoyad\"=@p2,\"DoktorBrans\"=@p3,\"DoktorSifre\"=@p4 where \"DoktorTC\"=@p5", bgl.baglanti());
            guncelle.Parameters.AddWithValue("@p1",TxtAd.Text);
            guncelle.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            guncelle.Parameters.AddWithValue("@p3",CmbBrans.Text);
            guncelle.Parameters.AddWithValue("@p4",TxtSifre.Text);
            guncelle.Parameters.AddWithValue("@p5",MskTc.Text);
            guncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
