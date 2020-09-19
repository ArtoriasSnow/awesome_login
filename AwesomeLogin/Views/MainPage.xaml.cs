using AwesomeLogin.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeLogin
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel mainPageViewModel;
        public MainPage()
        {
            mainPageViewModel = new MainPageViewModel();
            BindingContext = mainPageViewModel;
            InitializeComponent();
        }
    }
}
