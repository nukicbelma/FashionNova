using Acr.UserDialogs;
using FashionNova.Model.Models;
using FashionNova.Models;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FashionNova.Mobile.ViewModels
{
    public class PlacanjeViewModel : BindableBase
    {
        #region Variable

        private KreditnaKartica _kreditnaKartica;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;


        private APIService _servicePracenje = new APIService("NarudzbePracenjeInfo");

        #endregion Variable

        #region Public Property
        private string StripeTestApiKey = "pk_test_RyD6IdafiByMH7dKuEJeB9AT00tAv0qRC6";
        private string StripeSecretApiKey = "sk_test_wjmlOOtSQjkZOBXhU8MhIECT00HgaPEGWe";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        decimal _iznos = 0;
        public decimal Iznos
        {
            get { return _iznos; }
            set { SetProperty(ref _iznos, value); }
        }

        public KreditnaKartica kreditnaKartica
        {
            get { return _kreditnaKartica; }
            set { SetProperty(ref _kreditnaKartica, value); }
        }

        #endregion Public Property

        #region Constructor

        public PlacanjeViewModel()
        {
            _kreditnaKartica = new KreditnaKartica();
            Title = "Card Details";
        }

        #endregion Constructor

        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {
            _kreditnaKartica.ExpMonth = Convert.ToInt64(ExpMonth);
            _kreditnaKartica.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);

            }

            if (IsTransectionSuccess)
            {
                //await _servicePracenje.Insert<NarudzbePracenjeInfo>(new Model.Requests.NarudzbePracenjeInfoInsertRequest
                //{
                //    NarudzbaId = NarudzbaId,
                //    Datum = DateTime.Now,
                //    StatusPracenja = StatusPracenja.Potvrđena
                //});

                Console.Write("Payment Gateway" + "Payment Successful ");
                UserDialogs.Instance.Alert("Your payment was successfull", "Payment success", "OK");
                UserDialogs.Instance.HideLoading();

            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
            }


        });

        public int NarudzbaId { get; set; }

        #endregion Command

        #region Method

        private string CreateToken()
        {
            try
            {
                //StripeConfiguration.SetApiKey(StripeTestApiKey);
                //var service = new ChargeService();
                //var Tokenoptions = new TokenCreateOptions
                //{
                //    Card = new CreditCardOptions
                //    {
                //        Number = _kreditnaKartica.Number,
                //        ExpYear = _kreditnaKartica.ExpYear,
                //        ExpMonth = _kreditnaKartica.ExpMonth,
                //        Cvc = _kreditnaKartica.Cvc,
                //        //Name = Global.PrijavljeniKlijent.KorisnickoIme,
                //        AddressLine1 = "Adresa 1",
                //        AddressLine2 = "Adresa 2",
                //        AddressCity = "Capljina",
                //        AddressZip = "88305",
                //        AddressState = "HNK",
                //        AddressCountry = "Bosnia and Herzegovina",
                //        Currency = "bam",
                //    }
                //};

                Tokenservice = new TokenService();
                //stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecretApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = ((long)Iznos) * 100,
                    Currency = "bam",
                    //Description = "Charge for " + Global.PrijavljeniKlijent.Email,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "neki.neko@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (_kreditnaKartica.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && _kreditnaKartica.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }

        #endregion Method
    }
}
