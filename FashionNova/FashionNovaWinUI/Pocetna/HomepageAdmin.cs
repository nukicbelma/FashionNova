using FashionNova.WinUI.Artikli;
using FashionNova.WinUI.Klijenti;
using FashionNova.WinUI.Korisnici;
using FashionNova.WinUI.MaterijalBojaVelicinaVrsta;
using FashionNovaWinUI.Artikli;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FashionNova.WinUI.Pocetna
{
    public partial class HomepageAdmin : Form
    {
        private int childFormNumber = 0;

        public HomepageAdmin()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void pregledArtikalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaArtikli = new frmArtikli();
            formaArtikli.ShowDialog();
        }

        private void pregledKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaKlijenti = new frmKlijenti();
            formaKlijenti.ShowDialog();
        }
        private void pregledKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaKorisnici = new frmKorisnici();
            formaKorisnici.ShowDialog();
        }

        private void pregledKorisnikaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formaKorisnici = new frmKorisnici();
            formaKorisnici.ShowDialog();
        }

        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaDodajKorisnika = new frmDodajKorisnika();
            formaDodajKorisnika.ShowDialog();
        }

        private void dodajArtikalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formaDodajArtikal = new frmDodajUrediArtikal();
            formaDodajArtikal.ShowDialog();
        }

        private void HomepageAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dodajVrstuArtiklaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDodajVrstuArtikla();
            frm.ShowDialog();
        }

        private void dodajVelicinuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDodajVelicinu();
            frm.ShowDialog();
        }

        private void dodajMaterijalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDodajMaterijal();
            frm.ShowDialog();
        }

        private void dodajBojuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmDodajBoju();
            frm.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            var frm = new frmConfirmationOdjava();
            if (frm.ShowDialog() == DialogResult.Yes)
            {
                Close();
                PrijavljeniKorisnikService.PrijavljeniKorisnik = null;
                var loginPonovo = new frmLogin();
                loginPonovo.ShowDialog();
            }
        }
    }
}
