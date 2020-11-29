using System.ComponentModel;
using Xamarin.Forms;
using MyCoffeeApp.ViewModels;

namespace MyCoffeeApp.Views
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