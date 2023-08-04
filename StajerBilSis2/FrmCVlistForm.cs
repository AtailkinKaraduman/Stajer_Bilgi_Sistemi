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
    public partial class FrmCVlistForm : Form
    {
        public FrmCVlistForm()
        {
            InitializeComponent();
        }

        private void FrmCVlistForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet10.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter.Fill(this.stajyerBilgiDataSet10.Stajyer);

        }
        int secilen;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string path = dataGridView1.Rows[secilen].Cells[8].Value.ToString();

            FrmPdfViewer frmPdf = new FrmPdfViewer(path);
            frmPdf.Show();

        }
    }
}
