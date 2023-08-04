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
    public partial class FrmOgrListe : Form
    {
        public FrmOgrListe()
        {
            InitializeComponent();
        }
        private void FrmOgrList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet5.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter.Fill(this.stajyerBilgiDataSet5.Stajyer);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            secilen = dataGridView1.SelectedCells[0].RowIndex;
            FrmOgrDuzenle fr = new FrmOgrDuzenle();
            fr.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            fr.soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fr.telefon = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            fr.bas = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            fr.bit = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            fr.bolum = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            fr.TC = dataGridView1.Rows[secilen].Cells[3].Value.ToString();


            SqlCommand komutkaydet = new SqlCommand("SELECT [PhotoPath] FROM [Stajyer] WHERE [Ogrid]=" + fr.id, SqlBaglantim.baglanti());
            var reader = komutkaydet.ExecuteReader();
            var photopath = "";
            while (reader.Read())
            {
                photopath = reader[0].ToString();
            }
            SqlBaglantim.baglanti().Close();
            fr.fotoPath = photopath;


            this.stajyerTableAdapter.Fill(this.stajyerBilgiDataSet5.Stajyer);
            fr.Show();




        }
    }
}
