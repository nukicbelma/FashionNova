using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Reports
{
    public partial class frmIndexReport : Form
    {
        public frmIndexReport()
        {
            InitializeComponent();
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            var frm = new frmNarudzbeReport();
            frm.ShowDialog();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            var frm = new frmArtikalOcjenaReport();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmArtikli();
            frm.ShowDialog();
        }
    }
}
