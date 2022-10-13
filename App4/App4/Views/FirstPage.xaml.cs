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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
            ToLoginPage();
        }

        //доступ к защищенному элементу
        protected override void OnAppearing()
        {
            collectionView.ItemsSource = App.DataBase.GetItems();
            collectionView.SelectedItem = null;
            base.OnAppearing();
        }
        
        private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionView.SelectedItem !=null)
            {
                Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}" + $"?{nameof(ItemDetailPage.ItemId)}=" + $"{((Item)collectionView.SelectedItem).Id}");

            }
        }


        private async void ToLoginPage()
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }


}