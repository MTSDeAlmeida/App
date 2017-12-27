using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        private async void BtnEntrar_Clicked(object sender, EventArgs e)
        {
            if ((EntrySenha.Text == string.Empty) || (EntryLogin.Text == string.Empty))
            {
                await DisplayAlert("Atenção!", "Campo obrigatório", "OK");
            }

            if (EntrySenha.Text != "1")
            {
                await DisplayAlert("Atenção!", "Senha Incorreta!", "OK");
            }

            if ((EntryLogin.Text != string.Empty) && (EntrySenha.Text == "1"))
            {
                //EntrySenha.Text = string.Empty;
               // EntryLogin.Text = string.Empty;
                await Navigation.PushAsync(new App1.MastePage() { Title = "#CLASS"});
            }
        }
    }
}