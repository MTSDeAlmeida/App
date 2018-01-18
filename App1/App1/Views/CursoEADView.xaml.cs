using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Share;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CursoEADView : ContentPage
    {
        public CursoEADView()
        {
            InitializeComponent();
            
             wvCursoEAD.Source = "https://infoco.matheusacademico.com.br/EAD/relPublicaCurso.asp?id_curso=46&ordem=1";
            // wvCursoEAD.Source = "https://www.google.com.br";
        }

        private string BuildEmbedUrl(string url)
        {
            return BuildFinalHtml(url);        
        }

        private string BuildFinalHtml(string url)
        {
            string finalUrl = string.Format("<html><body>{0}</body></html>", url);
            return finalUrl;
        }
    }
}