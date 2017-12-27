using App1.Model;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContatoView : ContentPage
	{
        private ObservableCollection<ContatoModel> listContatos = new ObservableCollection<ContatoModel>();
		public ContatoView ()
		{
			InitializeComponent ();

            listContatos.Add(new ContatoModel()
            {
                Nome = "Alexandre de Almeida",
                Fone = "(041)3089-1440",
                Email = "de_almeidasilva@hotmail.com",
                TargetType = typeof(Views.Cadastros.CadastroContatoView)
            });
            listContatos.Add(new ContatoModel()
            {
                Nome = "João da Silva",
                Fone = "(041)3089-1440",
                Email = "de_almeidasilva@hotmail.com",
                TargetType = typeof(Views.Cadastros.CadastroContatoView)
            });

            var dependency = DependencyService.Get<App1.Interfaces.IContacts>();
            var t =  dependency.BuscaContato();
            foreach (var s in t)
            {
                listContatos.Add(new ContatoModel()
                {
                    Nome = s.Nome,
                    Fone = s.Fone,
                    Email = s.Email,
                    TargetType = typeof(Views.Cadastros.CadastroContatoView)
                });
            }           
            listContatosView.ItemsSource = listContatos;
            listContatosView.ItemSelected += listContatosView_ItemSelected;           
        }

        private async void listContatosView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.ContatoModel;
            if (item == null)
                return;

            await Navigation.PushAsync(new Views.Cadastros.CadastroContatoView(item) { Title = "Contato" });

            //IsPresented = false;
            listContatosView.SelectedItem = null;
        }

        private void LoadItemsCommand() {

        }
    }
}