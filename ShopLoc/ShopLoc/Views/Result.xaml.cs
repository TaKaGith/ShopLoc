﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopLoc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Result : ContentPage
    {
        IList<Product> resultlist;
        public Result()
        {
            InitializeComponent();
        }

       

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }
    }
}