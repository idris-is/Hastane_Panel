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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            NpgsqlCommand giris = new NpgsqlCommand("Select * from \"Tbl_Doktorlar\" where \"DoktorTC\"=@p1 and \"DoktorSifre\"=@p2",bgl.baglanti());
            giris.Parameters.AddWithValue("@p1",MskTc.Text);
            giris.Parameters.AddWithValue("@p2",TxtSifre.Text);
            NpgsqlDataReader dr = giris.ExecuteReader();
            if (dr.Read()) 
            { 
                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.tc = MskTc.Text;
                frmDoktorDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tc veya Şifre hatalı");
            }

            bgl.baglanti().Close();


        }
    }
}
