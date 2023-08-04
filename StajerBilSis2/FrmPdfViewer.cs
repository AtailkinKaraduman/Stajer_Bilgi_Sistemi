using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajerBilSis2
{
    public partial class FrmPdfViewer : Form
    {
        public static string path = "";
        public FrmPdfViewer(string pdfPath)
        {
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            InitializeComponent();
            this.pdfViewer1.LoadFromFile(startupPath + pdfPath);
        }
        private void FrmPdfViewer_Load(object sender, EventArgs e)
        {
        }
    }
}
