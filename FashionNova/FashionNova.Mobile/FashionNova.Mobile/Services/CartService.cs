using FashionNova.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FashionNova.Mobile.Services
{
    public class CartService
    {
        public static Dictionary<int, ArtikliDetaljiViewModel> Cart = new Dictionary<int, ArtikliDetaljiViewModel>();
    }
}
