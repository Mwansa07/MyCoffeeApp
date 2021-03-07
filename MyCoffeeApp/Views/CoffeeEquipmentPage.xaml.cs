using System;
using System.Collections.Generic;
using System.Windows.Input;
using MyCoffeeApp.Models;
using Xamarin.Forms;

namespace MyCoffeeApp.Views
{
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
        }

        async void ListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var coffee = ((ListView)sender).SelectedItem as Coffee;
            if (coffee == null)
                return;

            await DisplayAlert("Coffee Selected", coffee.Name, "OK");
        }

        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }

        async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            var coffee = ((MenuItem)sender).BindingContext as Coffee;
            if (coffee == null)
                return;

            await DisplayAlert("Coffee Favorited", coffee.Name, "OK");
        }
    }
}
