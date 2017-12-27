using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views.Cadastros
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroContatoView : ContentPage
	{
		public CadastroContatoView (Model.ContatoModel objModel)
		{
			InitializeComponent ();
		}
	}
}