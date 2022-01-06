using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Artikli
{
    public partial class frmConfirmation : Form
    {
        private readonly APIService _artikli = new APIService("Artikli");
        private Model.Models.Artikli selectedArtikal;
        public frmConfirmation(Model.Models.Artikli selectedArtikal)
        {
            InitializeComponent();
            this.selectedArtikal = selectedArtikal;
        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private async void btnDa_Click(object sender, EventArgs e)
        {
            if (await _artikli.Delete<bool>(selectedArtikal.ArtikalId))
            {
                MessageBox.Show($"Uspjesno ste obrisali artikal s id-em:: {selectedArtikal.ArtikalId}!");
                DialogResult = DialogResult.Yes;
            }
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
