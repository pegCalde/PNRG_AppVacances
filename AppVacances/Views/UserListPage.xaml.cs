using AppVacances.Models;
using AppVacances.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppVacances.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserListPage : ContentPage
    {
        public UserListPage(ObservableCollection<User> users)
        {
            InitializeComponent();
            BindingContext = new ListUserViewModel(users);
        }

        public UserListPage()
        {
            InitializeComponent();
            BindingContext = new ListUserViewModel();
        }
    }
}