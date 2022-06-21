using ShopLoc.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ShopLoc.Views
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