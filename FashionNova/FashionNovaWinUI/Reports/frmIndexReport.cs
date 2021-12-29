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
            string str = "narudzbi";
            var frm = new frmKreirajReport(str);
            frm.ShowDialog();
        }

        private void btnArtikli_Click(object sender, EventArgs e)
        {
            string str = "prodanih artikala";
            var frm = new frmKreirajReport(str);
            frm.ShowDialog();
        }
    }
}
