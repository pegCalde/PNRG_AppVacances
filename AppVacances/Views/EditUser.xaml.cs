﻿using AppVacances.Models;
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
    public partial class EditUser : ContentView
    {
        public EditUser(ObservableCollection<User> users, User user)
        {
            InitializeComponent();
            BindingContext = new PageUserViewModel(users, user);
        }
    }
}