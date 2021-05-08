using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVacances.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestMenu : MasterDetailPage
    {
        /* Nouvel item = Page maitre/detail, ca crée 4 fichiers. 
           On peut supprimer Detail.xaml, Master.xaml et MenuItem.cs 
        tuto menu xamarin => https://www.youtube.com/watch?v=vs4KyqZ6xeI */

        List<MenuItems> MenuItems;

        public TestMenu()
        {
            InitializeComponent();
            MenuItems = new List<MenuItems>();

            MenuItems.Add(new MenuItems { OptionName = "FavoriListPage" });
            MenuItems.Add(new MenuItems { OptionName = "LieuDetailsPage" });
            MenuItems.Add(new MenuItems { OptionName = "LieuListPage" });

            navigationList.ItemsSource = MenuItems;

            Detail = new NavigationPage(new FavoriListPage());
            Detail = new NavigationPage(new LieuDetailsPage());
            Detail = new NavigationPage(new LieuListPage());
        }

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                var item = e.Item as MenuItems;

                switch (item.OptionName)
                {
                    case "FavoriListPage":
                        {
                            Detail = new NavigationPage(new FavoriListPage());
                            IsPresented = false;
                        }
                        break;
                    case "LieuDetailsPage":
                        {
                            Detail = new NavigationPage(new LieuDetailsPage());
                            IsPresented = false;
                        }
                        break;
                    case "LieuListPage":
                        {
                            Detail = new NavigationPage(new LieuListPage());
                            IsPresented = false;
                        }
                        break;
                }
            } catch(Exception exception)
            {

            }
        }
    }

    public class MenuItems
    {
        public string OptionName { get; set; }
    }
}