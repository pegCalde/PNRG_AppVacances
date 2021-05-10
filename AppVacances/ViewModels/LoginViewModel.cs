using System;  
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AppVacances.Models;
using AppVacances.Service;
using Newtonsoft.Json;
using Xamarin.Forms; 

namespace AppVacances
{
    public class LoginViewModel : BaseViewModel, INotifyPropertyChanged
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
        
        public async void OnSubmit()  
        {  
            if (username == "example" || password == "secret")  
            {  
                DisplayInvalidLoginPrompt();  
            } else
            {
                await Login();
            } 
        }

        

        async Task Login()
        {
            if(IsBusy)
            {
                return;
            }

            IsBusy = true;           
            

            var client = HttpService.GetInstance();

            var url = new Uri("http://77.144.130.176:5001/login");
            var json = JsonConvert.SerializeObject(new { username = Username, password = Password });
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = url,
                Content = content
            };

            var result = await client.SendAsync(request).ConfigureAwait(false);
            if (result.IsSuccessStatusCode)
            {
                var data = await result.Content.ReadAsStringAsync();

                var user = new Utilisateur()
                
            }
        }
    }  
}
