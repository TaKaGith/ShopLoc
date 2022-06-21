using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace ShopLoc.Views
{

    public partial class MainPage : ContentPage

        
    {
        public IList<Product> Ilist { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Ilist = new List<Product>();
            Ilist.Add(new Product { ProductName = "Maggi Kari", Category = "Noodle", Price="RM 5.90" ,  ImageURL = "maggikari.png" });
            Ilist.Add(new Product { ProductName = "Maggi Tomyam", Category = "Noodle", Price = "RM 5.90", ImageURL = "maggitomyam.png" });
            Ilist.Add(new Product { ProductName = "Maggi Asam Laksa", Category = "Noodle",  Price = "RM 5.90", ImageURL = "maggiasamlaksa.png"});
            Ilist.Add(new Product { ProductName = "Lifebuoy", Category = "Bodywash", Price = "RM 11.90", ImageURL = "lifebuoy.png" });
            BindingContext = this;
        }

        public void Search1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchresult = Ilist.Where(c => c.ProductName.ToLower().Contains(Search1.Text.ToLower()));
            Coll1.ItemsSource = searchresult;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
                        await Navigation.PushAsync(new Result());
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string ImageURL { get; set; }

    }




}