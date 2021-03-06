using System;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace MyCoffeeApp.ViewModels
{
    public class CoffeeEquipmentViewModel : ViewModelBase
    {
        public CoffeeEquipmentViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
            Title = "Coffee Equipment";
        }

        public ICommand IncreaseCount { get; }

        private void OnIncrease(object obj)
        {
            count++;
            CountDisplay = $"You clicked {count} time(s)";
        }

        int count = 0;

        string countDisplay = "Click Me!";
        public string CountDisplay
        {
            get => countDisplay;
            set => SetProperty(ref countDisplay, value);
        }
    }
}
