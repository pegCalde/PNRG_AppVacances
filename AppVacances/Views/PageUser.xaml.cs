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
    public partial class PageUser : ContentView
    {
        public PageUser()
        {
            InitializeComponent();
            BindingContext = new PageUserViewModel(user);
        }
    }
}