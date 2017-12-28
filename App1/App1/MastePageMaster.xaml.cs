using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MastePageMaster : ContentPage
    {
        public ListView ListView;

        public MastePageMaster()
        {
            InitializeComponent();

            BindingContext = new MastePageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MastePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MastePageMenuItem> MenuItems { get; set; }
            
            public MastePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MastePageMenuItem>(new[]
                {
                    new MastePageMenuItem { Id = 0, Title = "Cadastro de Aluno",TitleColor=Color.FromHex("454545"),BarBackgroundColor=Color.FromHex("454545"),TitleWeight=FontAttributes.Bold, TargetType = typeof(Views.Cadastros.CadastroAlunoView) },
                    new MastePageMenuItem { Id = 1, Title = "Ficha do Aluno",TitleColor=Color.FromHex("454545"),TitleWeight=FontAttributes.Bold,TargetType = typeof(Views.Report.FichaAluno) },
                    new MastePageMenuItem { Id = 2, Title = "Contatos",TitleColor=Color.FromHex("454545"),TitleWeight=FontAttributes.Bold,TargetType = typeof(Views.ContatoView) },
                    new MastePageMenuItem { Id = 2, Title = "Play Video",TitleColor=Color.FromHex("454545"),TitleWeight=FontAttributes.Bold,TargetType = typeof(Views.PlayVideoView) },
                    new MastePageMenuItem { Id = 3, Title = "Sair",TitleColor=Color.FromHex("454545"),TitleWeight=FontAttributes.Bold,TargetType = null }                 
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}