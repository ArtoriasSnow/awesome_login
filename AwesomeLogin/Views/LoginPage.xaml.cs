using AwesomeLogin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeLogin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        LoginViewModel loginViewModel;
        public LoginPage()
        {
            loginViewModel = new LoginViewModel();
            BindingContext = loginViewModel;
            InitializeComponent();
            
        }
    }
}