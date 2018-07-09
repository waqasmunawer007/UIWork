using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UIwork
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            VendorSignUp.Clicked += VendorSignUp_Clicked;
            ClientSignUp.Clicked += ClientSignUp_Clicked;
            SignIn.Clicked += SignIn_Clicked;

        }

        private void SignIn_Clicked(object sender, EventArgs e)
        {
            //todo
        }

        private void ClientSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void VendorSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}