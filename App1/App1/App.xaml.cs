using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
	public partial class App : Application
	{
        //Create two static doubles that will be used to size elements
        public static double ScreenWidth;
        public static double ScreenHeight;

        public App ()
		{
            
            InitializeComponent();
            // The root page of your application
            //MainPage = new NavigationPage(new LandingPage());

            MainPage = new NavigationPage(new App1.LoginPage() {Title="#CLASS",});
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex("2c3e50");
            NavigationPage.SetHasNavigationBar(this, false);

             MainPage = new NavigationPage(new App1.LoginPage());
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
