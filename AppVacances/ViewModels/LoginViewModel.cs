using System;  
using System.ComponentModel;  
using System.Windows.Input;  
using Xamarin.Forms; 

namespace AppVacances
{
       public class LoginViewModel : INotifyPropertyChanged  
    {  
        public Action DisplayInvalidLoginPrompt;   
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string username;  
        public string Username
        {  
            get { return username; }  
            set  
            {
                username = value;  
                PropertyChanged(this, new PropertyChangedEventArgs("Username"));  
            }  
        }  
        private string password;    
        public string Password
        {  
            get { return password; }  
            set  
            {  
                password= value;  
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));  
            }  
        }  
        public ICommand SubmitCommand { protected set; get; }  
        public LoginViewModel()  
        {  
            SubmitCommand = new Command(OnSubmit);  
        }  
        public void OnSubmit()  
        {  
            if (username != "example" || password != "secret")  
            {  
                DisplayInvalidLoginPrompt();  
            }  
        }  
    }  
}  
}
