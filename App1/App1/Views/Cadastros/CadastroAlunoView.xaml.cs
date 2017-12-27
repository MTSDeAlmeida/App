using App1.Model.Cadastros;
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
	public partial class CadastroAlunoView : ContentPage
	{
		public CadastroAlunoView ()
		{
			InitializeComponent ();
		}

        private async void BtnSalvar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Atenção","Cadastro realizado com sucesso!","OK");

            AlunoModel objAluno = new AlunoModel();
            objAluno.Nome = EntryNome.Text;
            objAluno.Idade = Convert.ToInt32(EntryIdade.Text);
            objAluno.Sexo = picSexo.SelectedItem.ToString();
            objAluno.Telefone = EntryFone.Text;
            objAluno.Email = EntryEmail.Text;
            objAluno.DtNasc = dpDataNascimento.Date.ToString("dd/MM/yyyy");

            await Navigation.PushAsync(new App1.Views.Report.FichaAluno(objAluno));
        }
    }
}