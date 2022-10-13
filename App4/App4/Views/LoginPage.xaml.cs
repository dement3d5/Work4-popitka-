using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if(Log.Text=="1" && Pass.Text == "1")
            {
                Shell.Current.GoToAsync("//FirstPage");
            }
            else DisplayAlert("Ошибка", "Проверьте правильность введенных данных", "ОK");

        }



    }
}