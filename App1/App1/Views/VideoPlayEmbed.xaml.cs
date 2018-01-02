using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]   
    public partial class VideoPlayEmbed: ContentPage
    {
        public VideoPlayEmbed()
        {
            InitializeComponent();

            LoadingLabel.IsVisible = false;

            wvPlayer.HeightRequest = 854;
            wvPlayer.WidthRequest = 480;
            // setMargin.Margin = new Thickness(0, 100, 0, 0);
            //wvPlayer.Source = lstobj.VideoUrl;

            wvPlayer.Source = new HtmlWebViewSource
            { 
               Html = BuildEmbedUrl("https://www.youtube.com/embed/VCrtEgpKTJo")
            };
        }
        
       // <iframe width = "854" height="480" src="https://www.youtube.com/embed/VCrtEgpKTJo" frameborder="0" gesture="media" allow="encrypted-media" allowfullscreen></iframe>
        private string BuildEmbedUrl(string videoSource)
        {
           var iframeURL = string.Format("<iframe src=\"{0}\" frameborder=\"0\" allowfullscreen></iframe>", videoSource);
           return BuildFinalHtml(iframeURL);
        }

        private string BuildFinalHtml(string iframe)
        {
           string finalUrl = string.Format("<html><body>{0}</body></html>", iframe);
            return finalUrl;
        }
        private void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }

        private void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
        }
    }
}