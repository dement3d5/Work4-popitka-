using App4.Models;
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
    public partial class ThreePage : ContentPage
    {
        public ThreePage()
        {
            InitializeComponent();
            GetItemsToCollection();
        }
        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = new List<Janr>();
            collectionView.ItemsSource = await App.Database.GetJanrs();
            collectionView.ItemsSource = new List<Book>();
            collectionView.ItemsSource = await App.Database.GetBooks();
            collectionView.SelectedItem = null;
            base.OnAppearing();
        }

        private async void GetItemsToCollection()
        {
            collectionView.ItemsSource = await App.Database.GetBooks();
            collectionView.ItemsSource = await App.Database.GetJanrs();

        }

        private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (collectionView.SelectedItem != null)
            {
                Shell.Current.GoToAsync($"{nameof(LibraryDetailPage)}?{nameof(LibraryDetailPage.BookId)}={((Book)collectionView.SelectedItem).Id}");
                Shell.Current.GoToAsync($"{nameof(JanrDetailPage)}" + $"?{nameof(JanrDetailPage.JanrId)}=" + $"{((Janr)collectionView.SelectedItem).Id}");
            }
        }

    }
}