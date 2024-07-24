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
    public partial class FrmHastaKayitPaneli : Form
    {
        public FrmHastaKayitPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO \"Tbl_Hastalar\" (\"HastaAd\",\"HastaSoyad\",\"HastaTc\",\"HastaTelefon\",\"HastaSifre\",\"HastaCinsiyet\") values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskTc.Text);
            komut.Parameters.AddWithValue("@p4",MskTelefon.Text);
            komut.Parameters.AddWithValue("@p5",TxtSifre.Text);
            komut.Parameters.AddWithValue("@p6",CmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kaydınız gerçekleştirilmiştir Şifreniz: " + TxtSifre.Text,"Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
