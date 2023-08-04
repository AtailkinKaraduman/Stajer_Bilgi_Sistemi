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
using System.IO;

namespace StajerBilSis2
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        public string id, ad, soyad, TC, telefon, bas, bit, bolum, fotoPath;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox1.Text);
        }

        private void cvPdftxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "png File|*.png";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opf.FileName))
                {
                    textBox1.Text = opf.FileName;
                }
            }
        }

        private void cvPdftxtbox_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pdf File|*.pdf";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(opf.FileName))
                {
                    cvPdftxtbox.Text = opf.FileName;
                }
            }
        }




        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stajyer Silme
            DialogResult dialogResult = MessageBox.Show("Kaydı Silmek istediğinizden emin misiniz ?", "Uyarı !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komutsil = new SqlCommand("delete from Stajyer where ogrid=@k1", SqlBaglantim.baglanti());
                komutsil.Parameters.AddWithValue("@k1", TxtOgrid.Text);
                komutsil.ExecuteNonQuery();
                SqlBaglantim.baglanti().Close();
                MessageBox.Show("Kayıt Silindi !");
                this.Close();

            }
            else if (dialogResult == DialogResult.No)
            {
                FrmOgrDuzenle fr = new FrmOgrDuzenle();
                fr.Show();
            }

        }


        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kaydı Güncellemek İstediğinizden Emin Misiniz ?", "Uyarı !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SqlCommand komut = new SqlCommand("update Stajyer set OgrAd=@p2, OgrSoyad=@p3, OgrTC=@p4, OgrTelefon=@p5, OgrBolum=@p6, OgrBas=@p7, OgrBit=@p8 ,[CvPath]=ISNULL(@p9,(SELECT CvPath from Stajyer where Ogrid=@p1) ) ,[PhotoPath]=ISNULL(@p10,(SELECT PhotoPath from Stajyer where Ogrid=@p1) )   where Ogrid=@p1", SqlBaglantim.baglanti());
                    komut.Parameters.AddWithValue("@p1", TxtOgrid.Text);
                    komut.Parameters.AddWithValue("@p2", TxtOgrAd.Text);
                    komut.Parameters.AddWithValue("@p3", TxtOgrSoyad.Text);
                    komut.Parameters.AddWithValue("@p4", MskTC.Text);
                    komut.Parameters.AddWithValue("@p5", MskOgrTelefon.Text);
                    komut.Parameters.AddWithValue("@p6", comboBox1.Text);
                    komut.Parameters.AddWithValue("@p7", MskBasTarihi.Text);
                    komut.Parameters.AddWithValue("@p8", MskBitTarihi.Text);

                    Guid guid = Guid.NewGuid();
                    string fileToCopy = cvPdftxtbox.Text;
                    var rootPath = SqlBaglantim.GetAppFolder();
                    string destinationDirectory = SqlBaglantim.GetAppFolder() + "\\CV\\" + guid + ".pdf";
                    if (!String.IsNullOrEmpty(cvPdftxtbox.Text) && !(cvPdftxtbox.Text == "Dosya Seçmek İçin Tıkla "))
                    {
                        File.Copy(fileToCopy, destinationDirectory);
                    }
                    komut.Parameters.AddWithValue("@p9", "\\CV\\" + guid + ".pdf");


                    Guid fotoGuid = Guid.NewGuid();
                    string fotoFileToCopy = textBox1.Text;
                    var fotoRootPath = SqlBaglantim.GetAppFolder();
                    string fotoDestinationDirectory = SqlBaglantim.GetAppFolder() + "\\Foto\\" + fotoGuid + ".jpg";

                    if (!String.IsNullOrEmpty(textBox1.Text) && !(textBox1.Text == "Dosya Seçmek İçin Tıkla "))
                    {
                        File.Copy(fotoFileToCopy, fotoDestinationDirectory);
                    }
                    komut.Parameters.AddWithValue("@p10", "\\Foto\\" + fotoGuid + ".jpg");








                    komut.ExecuteNonQuery();
                    SqlBaglantim.baglanti();
                    MessageBox.Show("Kayıt Güncellendi ✓");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata, Yeniden Deneyin !");
                }
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                FrmOgrDuzenle fr = new FrmOgrDuzenle();
                fr.Show();
            }
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            TxtOgrid.Text = id;
            TxtOgrAd.Text = ad;
            TxtOgrSoyad.Text = soyad;
            MskTC.Text = TC;
            MskOgrTelefon.Text = telefon;
            MskBasTarihi.Text = bas;
            MskBitTarihi.Text = bit;
            comboBox1.Text = bolum;

            //if (!String.IsNullOrEmpty(fotoPath))
            //{
            //    var fotoRootPath = SqlBaglantim.GetAppFolder();
            //    pictureBox1.Image = Image.FromFile(fotoRootPath + fotoPath);
            //}


        }
    }
}
