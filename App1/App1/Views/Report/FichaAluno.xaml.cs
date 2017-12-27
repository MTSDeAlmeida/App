
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Model.Cadastros;


namespace App1.Views.Report
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FichaAluno : ContentPage
	{
        public FichaAluno() {
            InitializeComponent();
        }

		public FichaAluno (AlunoModel objAluno)
		{
			InitializeComponent ();
           
            lblNome.Text = "Nome: " + objAluno.Nome;
            lblDtNasc.Text = "Data Nascimento:" + objAluno.DtNasc;
            lblIdade.Text = "Idade: " + objAluno.Idade;
            lblSexo.Text = "Sexo: " + objAluno.Sexo;
            lblFone.Text = "Fone: " + objAluno.Telefone;
            lblEmail.Text = "Email: " + objAluno.Email;                      
        }
	}
}