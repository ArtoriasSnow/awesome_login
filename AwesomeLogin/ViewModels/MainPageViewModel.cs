using System.ComponentModel;
using Xamarin.Forms;

namespace AwesomeLogin.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public MainPageViewModel()
        {

        }

     


        public Command LogoutCommand
        {
            get
            {
                return new Command(Logout);
            }
        }

        private void Logout()
        {
           
                    Application.Current.MainPage = new NavigationPage(new LoginPage());
            
        }
    }
}