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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void LinkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayitPaneli frmHastaKayitPaneli = new FrmHastaKayitPaneli();
            frmHastaKayitPaneli.Show();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("Select * from \"Tbl_Hastalar\" where \"HastaTc\" = @p1 and \"HastaSifre\" = @p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTc.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            NpgsqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = MskTc.Text;
                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc veya Şifre Hatalı Lütfen Bilgilerinizi kontrol edin veya hesabınız yoksa hesap oluşturup öyle deneyiniz");
            }

            bgl.baglanti().Close();
        }
    }
}
