using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using FashionNovaWinUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionNova.WinUI.Artikli
{
    public partial class frmDodajUrediArtikal : Form
    {
        private readonly APIService _artikli = new APIService("Artikli");
        private readonly APIService _vrstaArtikla = new APIService("VrstaArtikla");
        private readonly APIService _boja = new APIService("Boja");
        private readonly APIService _materijal = new APIService("Materijal");
        private readonly APIService _velicina = new APIService("Velicina");
        private ArtikliInsertRequest insert = new ArtikliInsertRequest();
        private ArtikliUpdateRequest update = new ArtikliUpdateRequest();

        private Model.Models.Artikli SelectedArtikal;

        public frmDodajUrediArtikal(Model.Models.Artikli selectedArtikal=null)
        {
            InitializeComponent();
            SelectedArtikal = selectedArtikal;
        }
        private async void frmDodajUrediArtikal_Load(object sender, EventArgs e)
        {
            await LoadData();
            if(SelectedArtikal!=null)
            {
                btnIzbrisi.Visible = true;
                cmbVrstaArtikla.SelectedIndex = SelectedArtikal.VrstaArtiklaId;
                cmbBoja.SelectedIndex = SelectedArtikal.BojaId;
                cmbMaterijal.SelectedIndex = SelectedArtikal.MaterijalId;
                cmbVelicina.SelectedIndex = SelectedArtikal.VelicinaId;
                txtNaziv.Text = SelectedArtikal.Naziv;
                txtCijena.Text = SelectedArtikal.Cijena.ToString();
                txtSifra.Text = SelectedArtikal.Sifra;
                if (SelectedArtikal.Slika != null)
                {
                    txtSlika.Text = SelectedArtikal.Slika.ToString();
                    pbxSlika.Image = FashionNova.WinUI.Helpers.ImageHelper.FromByteToImage(SelectedArtikal.Slika);
                }
            }
        }
        private async Task LoadData()
        {
            await LoadBoja();
            await LoadVrstaArtikla();
            await LoadVelicina();
            await LoadMaterijal();
        }
        private async Task LoadVrstaArtikla()
        {
            var result = await _vrstaArtikla.Get<List<VrstaArtikla>>();

            result.Insert(0, new VrstaArtikla());
            cmbVrstaArtikla.DisplayMember = "Naziv";
            cmbVrstaArtikla.ValueMember = "VrstaArtiklaId";
            cmbVrstaArtikla.DataSource = result;
        }
        private async Task LoadBoja()
        {
            var result = await _boja.Get<List<Boja>>();

            result.Insert(0, new Boja());
            cmbBoja.DisplayMember = "Naziv";
            cmbBoja.ValueMember = "BojaId";
            cmbBoja.DataSource = result;
        }
        private async Task LoadVelicina()
        {
            var result = await _velicina.Get<List<Velicina>>();

            result.Insert(0, new Velicina());
            cmbVelicina.DisplayMember = "Oznaka";
            cmbVelicina.ValueMember = "VelicinaId";
            cmbVelicina.DataSource = result;
        }
        private async Task LoadMaterijal()
        {
            var result = await _materijal.Get<List<Materijal>>();

            result.Insert(0, new Materijal());
            cmbMaterijal.DisplayMember = "Naziv";
            cmbMaterijal.ValueMember = "MaterijalId";
            cmbMaterijal.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var vrstaArtiklaId = cmbVrstaArtikla.SelectedValue;
            if (int.TryParse(vrstaArtiklaId.ToString(), out int VrstaArtiklaId))
            {
                insert.VrstaArtiklaId = VrstaArtiklaId;
                update.VrstaArtiklaId = VrstaArtiklaId;
            }
            var bojaId = cmbBoja.SelectedValue;
            if (int.TryParse(bojaId.ToString(), out int BojaId))
            {
                insert.BojaId = BojaId;
                update.BojaId = BojaId;
            }
            var velicinaId = cmbVelicina.SelectedValue;
            if (int.TryParse(velicinaId.ToString(), out int VelicinaId))
            {
                insert.VelicinaId = VelicinaId;
                update.VelicinaId = VelicinaId;
            }
            var materijalId = cmbMaterijal.SelectedValue;
            if (int.TryParse(materijalId.ToString(), out int MaterijalId))
            {
                insert.MaterijalId = MaterijalId;
                update.MaterijalId = MaterijalId;
            }

            insert.Naziv = update.Naziv = txtNaziv.Text;
            insert.Sifra = update.Sifra = txtSifra.Text;
            insert.Slika = update.Slika = FashionNova.WinUI.Helpers.ImageHelper.FromImageToByte(pbxSlika.Image);

            if (decimal.TryParse(txtCijena.Text, out decimal cijena))
            {
                insert.Cijena = update.Cijena = cijena;
            }

            if (SelectedArtikal == null)
            {
                    await _artikli.Insert<Model.Models.Artikli>(insert);
                    MessageBox.Show($"Uspjesno ste dodali artikal {txtNaziv.Text} ");
                    Close(); 
            }
            else
            {
                await _artikli.Update<Model.Models.Artikli>(SelectedArtikal.ArtikalId, update);
                MessageBox.Show($"Uspjesno ste editovali artikal {txtNaziv.Text} ");
                Close();
            }
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            var result = ofdSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdSlika.FileName;
                var file = File.ReadAllBytes(fileName);

                txtSlika.Text = fileName;
                pbxSlika.Image = Image.FromFile(fileName);

            }
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
        }

        private async void btnIzbrisi_Click(object sender, EventArgs e)
        {
            if (SelectedArtikal != null)
            {
                //var izbrisi = new frmConfirmation(SelectedArtikal);
                //izbrisi.ShowDialog();
                //Close();
                //int ID = Convert.ToInt32(dgvArtists.CurrentRow.Cells["ID"].Value);
                await _artikli.Delete<dynamic>(SelectedArtikal.ArtikalId);
            }
        }
    }
}
