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
using System.Runtime.InteropServices.ComTypes;

namespace StajerBilSis2
{
    public partial class FrmOgrKayıt : Form
    {
        public FrmOgrKayıt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri listeleme 
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", SqlBaglantim.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comboBox1.Items.Add(oku[0].ToString());
            }
            SqlBaglantim.baglanti().Close();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutkaydet = new SqlCommand("insert into Stajyer (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrBolum,OgrBas,OgrBit,CvPath,PhotoPath) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", SqlBaglantim.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", TxtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", TxtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", MskTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", MskOgrTelefon.Text);
                komutkaydet.Parameters.AddWithValue("@p5", comboBox1.Text);
                komutkaydet.Parameters.AddWithValue("@p6", MskBasTarihi.Text);
                komutkaydet.Parameters.AddWithValue("@p7", MskBitTarihi.Text);




                Guid guid = Guid.NewGuid();
                string fileToCopy = cvPdftxtbox.Text;
                var rootPath = SqlBaglantim.GetAppFolder();
                string destinationDirectory = SqlBaglantim.GetAppFolder() + "\\CV\\" + guid + ".pdf";
                File.Copy(fileToCopy, destinationDirectory);
                komutkaydet.Parameters.AddWithValue("@p8", "\\CV\\" + guid + ".pdf");


                Guid fotoGuid = Guid.NewGuid();
                string fotoFileToCopy = textBox1.Text;
                var fotoRootPath = SqlBaglantim.GetAppFolder();
                string fotoDestinationDirectory = SqlBaglantim.GetAppFolder() + "\\Foto\\" + fotoGuid + ".jpg";
                File.Copy(fotoFileToCopy, fotoDestinationDirectory);
                komutkaydet.Parameters.AddWithValue("@p9", "\\Foto\\" + fotoGuid + ".jpg");






                komutkaydet.ExecuteNonQuery();
                SqlBaglantim.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Eklendi !");
                this.Close();
                FrmOgrListe fr = new FrmOgrListe();
                fr.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA ! Lütfen tekrar deneyin. Tüm boşlukları doldurduğunuzdan emin olun !");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox1.Text);
        }
    }
}
//Data Source=DESKTOP-I33JM8T;Initial Catalog=StajyerBilgi;Integrated Security=True