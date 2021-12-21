using FashionNova.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Klijenti
{
    public partial class frmKlijentiDetalji : Form
    {
        private Model.Models.Klijenti klijent;
        private KlijentiInsertRequest update = new KlijentiInsertRequest();
        public frmKlijentiDetalji(Model.Models.Klijenti klijent)
        {
            InitializeComponent();
            this.klijent = klijent;
        }

        private async void frmKlijentiDetalji_Load(object sender, EventArgs e)
        {
            await ucitajPodatke();
        }
        private async Task ucitajPodatke()
        {
            txtnaslov.Text = klijent.KorisnickoIme;
            txtImePrezime.Text = klijent.Ime + " " + klijent.Prezime;
            txtEmail.Text = klijent.Email;
            txtTelefon.Text = klijent.Telefon;
            txtKorisnickoIme.Text = klijent.KorisnickoIme;
            //pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(klijent.Slika);
        }

        private void pbxSlika_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);

                txtSlika.Text = fileName;
                pbxSlika.Image = Image.FromFile(fileName);

            }
            update.Slika = FashionNova.WinUI.Helpers.ImageHelper.FromImageToByte(pbxSlika.Image);

        }
    }
}
