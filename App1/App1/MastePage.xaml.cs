using App1.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MastePage : MasterDetailPage
    {
        public MastePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;           
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MastePageMenuItem;

            if (item == null)
                return;

            if (item.TargetType != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                {
                    BarBackgroundColor = Color.FromHex("2c3e50"),
                    Title = item.Title
                };
            }
            else
            {
                await Navigation.PopAsync(true);
            }

            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
        }
    }
}