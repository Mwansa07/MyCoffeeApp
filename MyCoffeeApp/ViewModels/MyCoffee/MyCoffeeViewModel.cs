﻿using System;
using MvvmHelpers;
using MvvmHelpers.Commands;
using MyCoffeeApp.Models;
using MyCoffeeApp.Services;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Command = MvvmHelpers.Commands.Command;
using MyCoffeeApp.Views.MyCoffee;

namespace MyCoffeeApp.ViewModels
{
    public class MyCoffeeViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Coffee> Coffee { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Coffee> RemoveCommand { get; }
        public AsyncCommand<Coffee> SelectedCommand { get; }

        public MyCoffeeViewModel()
        {
            Title = "My Coffee";

            Coffee = new ObservableRangeCollection<Coffee>();

            RefreshCommand = new AsyncCommand(Refresh);
            AddCommand = new AsyncCommand(Add);
            RemoveCommand = new AsyncCommand<Coffee>(Remove);
            SelectedCommand = new AsyncCommand<Coffee>(Selected);
        }

        async Task Remove(Coffee coffee)
        {
            await CoffeeService.RemoveCoffee(coffee.Id);
            await Refresh();
        }

        async Task Add()
        {
            //var name = await App.Current.MainPage.DisplayPromptAsync("Name", "Name of coffee");
            //var roaster = await App.Current.MainPage.DisplayPromptAsync("Roaster", "Roaster of coffee");
            //await CoffeeService.AddCoffee(name, roaster);
            //await Refresh();

            var route = $"{nameof(AddMyCoffeePage)}";
            await Shell.Current.GoToAsync(route);
        }

        async Task Selected(Coffee coffee)
        {
            if (coffee == null)
            {
                return;
            }

            var route = $"{nameof(MyCoffeeDetailsPage)}?CoffeeId={coffee.Id}";
            await Shell.Current.GoToAsync(route);
        }

        async Task Refresh()
        {
            IsBusy = true;

            await Task.Delay(2000);

            Coffee.Clear();

            var coffees = await CoffeeService.GetCoffee();

            Coffee.AddRange(coffees);

            IsBusy = false;
        }
    }
}
