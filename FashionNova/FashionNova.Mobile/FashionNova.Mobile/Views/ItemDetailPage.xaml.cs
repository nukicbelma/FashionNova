using FashionNova.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FashionNova.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}