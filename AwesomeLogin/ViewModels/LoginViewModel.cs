using System.ComponentModel;
using Xamarin.Forms;

namespace AwesomeLogin.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public LoginViewModel()
        {

        }

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
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }


        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        public Command RememberPasswordCommand
        {
            get
            {
                return new Command(RememberPassword);
            }
        }

        private void RememberPassword()
        {
            App.Current.MainPage.DisplayAlert("Remember Password", "Your username is 'john' and your password is 'doe'. You're welcome ;) ", "Got it!");
        }

        private void Login()
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter your username and password", "OK");
            else
            {
                if (Username == "john" && Password == "doe")
                {

                 
                    Application.Current.MainPage = new NavigationPage(new MainPage());

                }
                else
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please check your username and password", "OK");
            }
        }
    }
}