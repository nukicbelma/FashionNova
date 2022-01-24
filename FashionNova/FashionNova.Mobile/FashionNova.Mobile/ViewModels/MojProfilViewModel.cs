using FashionNova.Mobile.Services;
using FashionNova.Mobile.Views;
using FashionNova.Model.Models;
using FashionNova.Model.Requests;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace FashionNova.Mobile.ViewModels
{
    public class MojProfilViewModel :BaseViewModel
    {
        private readonly APIService _service = new APIService("Klijenti");
        public MojProfilViewModel()
        {
        }
        public ICommand UploadProfileCommand { get; set; }
        public byte[] ProfilePhoto { get; set; }
        //public ImageSource ProfilePhotoSource
        //{
        //    get
        //    {
        //        return _profilePhotoSource;
        //    }

        //    set
        //    {
        //        _profilePhotoSource = value;
        //        OnPropertyChanged("ProfilePhotoSource");
        //    }
        //}

        string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        string _klijentId = string.Empty;
        public string KlijentId
        {
            get { return _klijentId; }
            set { SetProperty(ref _klijentId, value); }
        }
        string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }
        string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }
        string _telefon = string.Empty;
        public string Telefon
        {
            get { return _telefon; }
            set { SetProperty(ref _telefon, value); }
        }
        string _korisnickoime = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoime; }
            set { SetProperty(ref _korisnickoime, value); }
        }
        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        string _potvrda = string.Empty;
        public string Potvrda
        {
            get { return _potvrda; }
            set { SetProperty(ref _potvrda, value); }
        }
        ImageSource _profilePhotoSource;
        public ImageSource ProfilePhotoSource
        {
            get
            {
                return _profilePhotoSource;
            }

            set
            {
                _profilePhotoSource = value;
                OnPropertyChanged("ProfilePhotoSource");
            }
        }
        public async Task EditujKlijenta()
        {
            KlijentiUpdateRequest request = new KlijentiUpdateRequest();

            request.KlijentId = int.Parse(KlijentId);
            request.Email = Email;
            request.Ime = Ime;
            request.Prezime = Prezime;
            request.KorisnickoIme = KorisnickoIme;
            request.Telefon = Telefon;
            request.Password = Password;
            request.PasswordPotvrda = Potvrda;
            request.Slika = ProfilePhoto;


            await _service.Update<Klijenti>(int.Parse(KlijentId),request);
            await Application.Current.MainPage.DisplayAlert("Welcome", "Uspjesno ste editovali vas korisnicki racun. ", "OK");
        }
        private MediaFile _mediaFileProfilePhoto;
        public async Task UploadProfilePicture()
        {
            
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                return;
            }
            _mediaFileProfilePhoto = await CrossMedia.Current.PickPhotoAsync();
            if (_mediaFileProfilePhoto == null)
                return;
            var path = _mediaFileProfilePhoto.Path;
            var file = File.ReadAllBytes(path);
            ProfilePhoto = file;
            ProfilePhotoSource = ImageSource.FromStream(() => { return _mediaFileProfilePhoto.GetStream(); });
        }
    }
}

