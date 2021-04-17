using System;
using System.Threading.Tasks;
using MvvmHelpers.Commands;
using MyCoffeeApp.Services;
using Xamarin.Forms;

namespace MyCoffeeApp.ViewModels.MyCoffee
{
    public class AddMyCoffeeViewModel : ViewModelBase
    {
        string name, roaster;
        public string Name { get => name; set => SetProperty(ref name, value); }
        public string Roaster { get => roaster; set => SetProperty(ref roaster, value); }

        public AsyncCommand SaveCommand { get; }

        public AddMyCoffeeViewModel()
        {
            Title = "Add Coffee";
            SaveCommand = new AsyncCommand(Save);
        }

        async Task Save()
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(roaster))
            {
                return;
            }

            await CoffeeService.AddCoffee(name, roaster);

            await Shell.Current.GoToAsync("..");
        }
    }
}
