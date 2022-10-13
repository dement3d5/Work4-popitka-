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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            collectionView.ItemsSource = App.DataBase.GetBooks();
            collectionView.SelectedItem = null;
            base.OnAppearing();
        }

        private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionView.SelectedItem != null)
            {
                Shell.Current.GoToAsync($"{nameof(BookDetailPage)}" + $"?{nameof(BookDetailPage.BookId)}=" + $"{((Book)collectionView.SelectedItem).Id}");

            }
        }

       

    }
}