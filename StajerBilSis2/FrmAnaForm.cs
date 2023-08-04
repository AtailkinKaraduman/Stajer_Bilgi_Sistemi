using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajerBilSis2
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void hesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMailForm fr = new FrmMailForm();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet11.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter4.Fill(this.stajyerBilgiDataSet11.Stajyer);


            //// TODO: This line of code loads data into the 'stajyerBilgiDataSet4.Stajyer' table. You can move, or remove it, as needed.
            //this.stajyerTableAdapter3.Fill(this.stajyerBilgiDataSet4.Stajyer);
            //// TODO: This line of code loads data into the 'stajyerBilgiDataSet3.Stajyer' table. You can move, or remove it, as needed.
            //this.stajyerTableAdapter2.Fill(this.stajyerBilgiDataSet3.Stajyer);
            //// TODO: This line of code loads data into the 'stajyerBilgiDataSet2.Stajyer' table. You can move, or remove it, as needed.
            //this.stajyerTableAdapter1.Fill(this.stajyerBilgiDataSet2.Stajyer);
            //// TODO: This line of code loads data into the 'stajyerBilgiDataSet1.Stajyer' table. You can move, or remove it, as needed.
            //this.stajyerTableAdapter.Fill(this.stajyerBilgiDataSet1.Stajyer);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void perToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }

        private void büyüteçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("magnify.Exe");
        }

        private void ekranOkuyucuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("write.Exe");
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome.Exe");
        }

        private void ePostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("outlook");
        }

        private void stajyerEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayıt fr = new FrmOgrKayıt();
            fr.Show();
        }

        private void stajyerListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void stajyerDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe fr = new FrmOgrListe();
            fr.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle fr = new FrmYoneticiDuzenle();
            fr.Show();
        }

        private void stajyerBilgileriRaporlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciRapor fr = new FrmOgrenciRapor();
            fr.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Ata İlkin Karaduman Tarafından Cumhurbaşkanlığı Yazılım Daire Başkanlığı Stajında Yapılmıştır.", "Stajyer Bilgi Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz ? ", "Çıkış Ekranı !", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Ana ekranda kal

            }

        }

        private void stajyerCVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCVlistForm frmCVlistForm = new FrmCVlistForm();
            frmCVlistForm.Show();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //MessageBox.Show("Test");
        }
    }
}
