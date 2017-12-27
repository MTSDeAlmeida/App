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
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MastePageMenuItem;
            if (item == null)
                return;
           
            Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType)) {
                    BarBackgroundColor = Color.FromHex("2c3e50"),
                    Title = item.Title
            };

            IsPresented = false;            
            MasterPage.ListView.SelectedItem = null;
        }
    }
}