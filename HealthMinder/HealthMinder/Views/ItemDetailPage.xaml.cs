using HealthMinder.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace HealthMinder.Views
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