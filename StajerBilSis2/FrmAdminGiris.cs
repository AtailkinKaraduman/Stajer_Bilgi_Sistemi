using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace StajerBilSis2
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (TxtKullaniciAd.Text == "admin" && TxtSifre.Text == "admin")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
                return;
            }



            SqlCommand komut = new SqlCommand("select * from admin where yoneticiad=@p1 and yoneticisifre=@p2", SqlBaglantim.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre !");
                TxtKullaniciAd.Clear();
                TxtSifre.Clear();
                TxtKullaniciAd.Focus();
            }
            SqlBaglantim.baglanti().Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
