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
    class PageUserViewModel : BaseViewModel
    {
        User selectedUser;
        string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                SetProperty(ref username, value);
            }
        }
        string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                SetProperty(ref description, value);
            }
        }
        string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                SetProperty(ref date, value);
            }
        }
        string lieu;
        public string Lieu
        {
            get
            {
                return lieu;
            }
            set
            {
                SetProperty(ref lieu, value);
            }
        }
        string nbVue;
        public string NbVue
        {
            get
            {
                return nbVue;
            }
            set
            {
                SetProperty(ref nbVue, value);
            }
        }
        string nbShare;
        public string NbShare
        {
            get
            {
                return nbShare;
            }
            set
            {
                SetProperty(ref nbShare, value);
            }
        }
        string photo;
        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                SetProperty(ref photo, value);
            }
        }
        string background;
        public string Background
        {
            get
            {
                return background;
            }
            set
            {
                SetProperty(ref background, value);
            }
        }

        public ICommand Button_Clicked
        {
            get
            {
                return new Command(ButtonClicked);
            }
        }

        void ButtonClicked()
        {
            int nbShare = Convert.ToInt32(NbShare);

            nbShare++;
            NbShare = Convert.ToString(nbShare);
        }

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

        public PageUserViewModel(ObservableCollection<User> usersItems, User user)
        {
            selectedUser = user;
            Users = usersItems;

            Username = user.Username;
            Description = user.Description;
            Date = user.Date;
            Lieu = user.Lieu;
            Photo = user.Photo;
            Background = user.Background;
        }


        public ICommand SaveModifiedUser
        {
            get
            {
                return new Command(OnSaveModifierUser);
            }
        }


        void OnSaveModifierUser()
        {
            Users.Remove(selectedUser);

            Users.Add(new User
            {
                Username = username,
                Description = description,
                Date = date,
                Lieu = lieu,
                Photo = photo,
                Background = background
            });

            Application.Current.MainPage.Navigation.PushAsync(new UserListPage(Users));
        }

        public ICommand SaveUser
        {
            get
            {
                return new Command(OnSaveUser);
            }
        }


        void OnSaveUser()
        {
            Users.Add(new User
            {
                Username = username,
                Description = description,
                Date = date,
                Lieu = lieu,
                Photo = photo,
                Background = background
            });

            Application.Current.MainPage.Navigation.PushAsync(new UserListPage(Users));
        }

        public PageUserViewModel(User user)
        {
            Username = user.Username;
            Description = user.Description;
            Date = user.Date;
            Lieu = user.Lieu;
            NbVue = user.NbVue;
            NbShare = user.NbShare;
            Photo = user.Photo;
            Background = user.Background;
        }
    }
}
