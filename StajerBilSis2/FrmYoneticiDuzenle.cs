﻿using System;
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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet6.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.stajyerBilgiDataSet6.Admin);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd, YoneticiSifre) values (@p1,@p2)",SqlBaglantim.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.ExecuteNonQuery();
            SqlBaglantim.baglanti().Close();
            MessageBox.Show("Yönetici Eklendi ✓");
            this.adminTableAdapter.Fill(this.stajyerBilgiDataSet6.Admin);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            TxtKullanıcıAd.Text = ad;
            TxtSifre.Text = sifre;  
            TxtYoneticiid.Text = id;   
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut= new SqlCommand("delete from Admin where Yoneticiid=@p1",SqlBaglantim.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            SqlBaglantim.baglanti().Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti ✓");
            this.adminTableAdapter.Fill(this.stajyerBilgiDataSet6.Admin);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update admin set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", SqlBaglantim.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullanıcıAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p3", TxtYoneticiid.Text);
            komut.ExecuteNonQuery();
            SqlBaglantim.baglanti().Close();
            MessageBox.Show("Güncelleme Gerçekleşti ✓");
            this.adminTableAdapter.Fill(this.stajyerBilgiDataSet6.Admin);
        }
    }
}
