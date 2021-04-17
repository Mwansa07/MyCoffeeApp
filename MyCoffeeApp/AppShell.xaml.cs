using System;
using System.Collections.Generic;
using MyCoffeeApp.Views;
using MyCoffeeApp.Views.MyCoffee;
using Xamarin.Forms;

namespace MyCoffeeApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddMyCoffeePage), typeof(AddMyCoffeePage));

            Routing.RegisterRoute(nameof(MyCoffeeDetailsPage), typeof(MyCoffeeDetailsPage));
        }

    }
}
