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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.stajyerBilgiDataSet.Bolumler);

        }

        private void PcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut1 = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)",   SqlBaglantim.baglanti());
                komut1.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut1.ExecuteNonQuery();
                SqlBaglantim.baglanti().Close();
                MessageBox.Show("Ekleme işlemi başarılı ✓ ");
                this.bolumlerTableAdapter.Fill(this.stajyerBilgiDataSet.Bolumler);

            }
            catch
            {
                MessageBox.Show("Hata Oluştu ! Yeniden Deneyin !");
            }
        }

        private void PcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1", SqlBaglantim.baglanti());
                komut2.Parameters.AddWithValue("@p1", TxtBolumid.Text);
                komut2.ExecuteNonQuery();
                SqlBaglantim.baglanti().Close();
                MessageBox.Show("Silme işlemi Gerçekleşti");
                this.bolumlerTableAdapter.Fill(this.stajyerBilgiDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Hata, işlem gerçekleşmedi !");
            }
        }
        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBolumid.Text = id;
            TxtBolumAd.Text = bolumad;
       }

        private void PcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("update Bolumler Set Bolumad=@p1 where Bolumid=@p2", SqlBaglantim.baglanti());
                komut2.Parameters.AddWithValue("@p2", TxtBolumid.Text);
                komut2.Parameters.AddWithValue("@p1", TxtBolumAd.Text);
                komut2.ExecuteNonQuery();
                SqlBaglantim.baglanti().Close();
                MessageBox.Show("Güncelleme Gerçekleşti ✓");
                this.bolumlerTableAdapter.Fill(this.stajyerBilgiDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Hata, güncelleme gerçekleştirilemedi !");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
