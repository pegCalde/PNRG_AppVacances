using AppVacances.Models;
using AppVacances.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppVacances.ViewModels
{
    class ListUserViewModel : BaseViewModel
    {
        ObservableCollection<User> users = new ObservableCollection<User>();
        public ObservableCollection<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                SetProperty(ref users, value);
            }
        }
        public ListUserViewModel(ObservableCollection<User> usersItems)
        {
            Users = usersItems;
        }

        public ListUserViewModel()
        {
            Users.Add(new User
            {
                Username = "Perceval",
                Description = "Chef de clan des semi-croustillants",
                Date = "20/08/2000",
                Lieu = "Nice",
                NbVue = "0",
                NbShare = "0",
                Photo = "https://cdn.pixabay.com/photo/2015/04/19/08/32/marguerite-729510_1280.jpg",
                Background = "https://www.proflowers.com/blog/wp-content/uploads/2019/08/mexican-flowers-hero.jpg"
            });
            Users.Add(new User
            {
                Username = "Arthur",
                Description = "Roi de bretagne",
                Date = "20/08/1835",
                Lieu = "Paris",
                NbVue = "0",
                NbShare = "0",
                Photo = "https://cdn.pixabay.com/photo/2015/04/19/08/32/marguerite-729510_1280.jpg",
                Background = "https://www.proflowers.com/blog/wp-content/uploads/2019/08/mexican-flowers-hero.jpg"
            });
            Users.Add(new User
            {
                Username = "Lancelot",
                Description = "Chevalier errant",
                Date = "06/05/1945",
                Lieu = "Lyon",
                NbVue = "0",
                NbShare = "0",
                Photo = "https://cdn.pixabay.com/photo/2015/04/19/08/32/marguerite-729510_1280.jpg",
                Background = "https://www.proflowers.com/blog/wp-content/uploads/2019/08/mexican-flowers-hero.jpg"
            });
        }

        User userSelected;
        public User UserSelected
        {
            get
            {
                return userSelected;
            }
            set
            {
                SetProperty(ref userSelected, value);
                if (value != null)
                {
                    Application.Current.MainPage.Navigation.PushAsync(new UserPage(userSelected));
                    UserSelected = null;
                }
            }
        }

        public ICommand EditCommand
        {
            get
            {
                return new Command<User>(async (theuser) => await OnEditCommand(theuser));
            }
        }

        async Task OnEditCommand(User theuser)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EditUserPage(users, theuser));

        }

        public ICommand DeleteCommand
        {
            get
            {
                return new Command<User>(async (theuser) => await OnDeleteCommand(theuser));
            }
        }

        Task OnDeleteCommand(User theuser)
        {
            Users.Remove(theuser);
            return Task.CompletedTask;
        }

        public ICommand AddUser
        {
            get
            {
                return new Command(OnAddUser);
            }
        }

        void OnAddUser()
        {
            Application.Current.MainPage.Navigation.PushAsync(new NewUser(users, new User()));
        }
    }
}
