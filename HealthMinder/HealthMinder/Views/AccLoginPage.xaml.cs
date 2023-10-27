using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HealthMinder.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccLoginPage : ContentPage
	{
		public AccLoginPage ()
		{
			InitializeComponent ();
		}
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }

        private void ForgotPasswordButton_Clicked(object sender, EventArgs e)
        {

        }

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
        }


        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}