using FashionNova.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using FashionNova.Model.Models;
using FashionNova.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace FashionNova.WebAPI.Autentifikacija
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisniciService _userService;
        private readonly IKlijentiService _clientService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisniciService userService,
            IKlijentiService clientService)
            : base(options, logger, encoder, clock)
        {

            _userService = userService;
            _clientService = clientService;


        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            FashionNova.Model.Models.Korisnici user = null;
            FashionNova.Model.Models.Klijenti client = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userService.Authenticiraj(username, password);
                //if (user == null)
                    //client = _clientService.Authenticiraj(username, password);
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null && client == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim>();

            if (user != null)
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme));
                claims.Add(new Claim(ClaimTypes.Name, user.Ime));

                foreach (var role in user.KorisniciUloge)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
                }
            }
            else
            {
                claims.Add(new Claim(ClaimTypes.NameIdentifier, client.KorisnickoIme));
                claims.Add(new Claim(ClaimTypes.Name, client.Ime));
                claims.Add(new Claim(ClaimTypes.Role, "Klijent"));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
