using System;
using System.Collections.Generic;
using MyCoffeeApp.ViewModels;
using MyCoffeeApp.Views;
using Xamarin.Forms;

namespace MyCoffeeApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
