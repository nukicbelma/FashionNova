using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Pocetna
{
    public partial class frmConfirmationOdjava : Form
    {
        public frmConfirmationOdjava()
        {
            InitializeComponent();
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Pozdrav!");
            DialogResult = DialogResult.Yes;
        }
    }
}
