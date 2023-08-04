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
    public partial class FrmOgrenciRapor : Form
    {
        public FrmOgrenciRapor()
        {
            InitializeComponent();
        }

        private void FrmOgrenciRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet9.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter1.Fill(this.stajyerBilgiDataSet9.Stajyer);
            // TODO: This line of code loads data into the 'stajyerBilgiDataSet1.Stajyer' table. You can move, or remove it, as needed.
            this.stajyerTableAdapter.Fill(this.stajyerBilgiDataSet1.Stajyer);

            this.reportViewer1.RefreshReport();
        }
    }
}
