using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using App1.Droid.Resources;

namespace App1.Droid
{
    [Activity (Label = "App1", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
   /// [Activity (Label = "App1", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Sensor)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            //Calculate the pixes and pass them to our static application doubles
            //We need to make sure we are using device independent pixels (DIP)
            //All Android Forms sizing requests utilize DIPs, so we need that here
            var pixelWidth = (int)Resources.DisplayMetrics.WidthPixels;
            var pixelHeight = (int)Resources.DisplayMetrics.HeightPixels;
            var screenPixelDensity = (double)Resources.DisplayMetrics.Density;

            App.ScreenHeight = (double)((pixelHeight - 0.5f) / screenPixelDensity);
            App.ScreenWidth = (double)((pixelWidth - 0.5f) / screenPixelDensity);

            //Set our status bar helper DecorView. This enables us to hide the notification bar for fullscreen
           //  StatusBarHelper.DecorView = this.Window.DecorView;


            LoadApplication(new App1.App());
		}

        public override void OnAttachedToWindow()
        {
            base.OnAttachedToWindow();
            //Set our status bar helper AppActionBar. This enables us to hide the ActionBar for fullscreen
            //Always hide the actionbar/toolbar if you are hiding the notification bar
            if (ActionBar != null)
              StatusBarHelper.AppActionBar = ActionBar;
        }
    }
}

