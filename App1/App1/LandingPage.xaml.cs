﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LandingPage : ContentPage
	{
        ContentView videoPlayer;

        public LandingPage ()
		{
            InitializeComponent ();
            videoPlayer = new ContentView
            {
                WidthRequest = App.ScreenWidth / 2,
                HeightRequest = App.ScreenHeight / 2,
            };            

            Content = new StackLayout
            {
                Children = {
                    videoPlayer
                }
            };
        }

        protected override void LayoutChildren(double x, double y, double width, double height)
        {
            //need to change the size of the ContentView for Landscape Orientation
            //This enables fullscreen capabilities in the Custom Renderer
            if (width > height)
            {
                //Landscape Orientation
                videoPlayer.WidthRequest = App.ScreenWidth;
                videoPlayer.HeightRequest = App.ScreenHeight;
            }
            else if (width < height)
            {
                //Portrait Orientation
                videoPlayer.WidthRequest = App.ScreenWidth / 2;
                videoPlayer.HeightRequest = App.ScreenHeight / 2;
                
            }

            base.LayoutChildren(x, y, width, height);
        }
    }
}