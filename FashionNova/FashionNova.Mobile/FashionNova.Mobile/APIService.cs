using FashionNova.Model;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FashionNova.Mobile
{
    class APIService
    {
        private string _resource;
        public static string Username { get; set; }
        public static string Password { get; set; }

#if DEBUG
        public string _apiURL = "http://localhost:5003/";
#endif
#if RELEASE
        private string _apiURL = "https://mywebsite.azure.com/api/";
#endif
        public APIService(string resource)
        {
            _resource = resource;
        }
        public async Task<T> Get<T>(object searchRequest = null)
        {
            try
            {
                var query = "";
                if (searchRequest != null)
                {
                    query = await searchRequest?.ToQueryString();
                }

                var list = await $"{_apiURL}{_resource}?{query}"
                   .WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                //if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiURL}{_resource}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiURL}{_resource}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return default(T);
            }

        }
        public async Task<T> Authenticiraj<T>(string username, string password)
        {
            var url = $"{_apiURL}/Authenticiraj/{username},{password}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiURL}{_resource}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return default(T);
            }
        }
        public async Task<bool> Delete<T>(int id)
        {
            try
            {
                var url = $"{_apiURL}{_resource}/{id}";
                return await url.WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<bool>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseStringAsync();
                //var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.ToString()}, ${string.Join(",", error.ToString())}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                return false;
            }
        }
    }
}
