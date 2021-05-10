using AppVacances.Models;
using AppVacances.ViewModels;
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
    public partial class UserPage : ContentPage
    {
        public UserPage(User user)
        {
            InitializeComponent();
            BindingContext = new PageUserViewModel(user);
        }
    }
}