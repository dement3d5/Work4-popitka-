using App4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [QueryProperty(nameof(BookId ), nameof(BookId))]


    public partial class LibraryDetailPage : ContentPage
    {

        private int bookId;
        public int BookId
        {
            get => BookId;
            set
            {
                bookId = value;

                if (bookId > 0)
                {
                    SetJanr();



                }

            }
        }

        private int janrId;
        public int JanrId
        {
            get => JanrId;
            set
            {
                janrId = value;

                if (janrId > 0)
                {


                    
                }

            }
        }

        public Book Book { get; set; }

        public Janr Janr { get; set; }

        public LibraryDetailPage()
        {
            InitializeComponent();
        }

        private async void SetJanr()
        {
            Book = await App.Database.GetBook(BookId);

          
               
                Janr = await App.Database.GetJanr(Book.JanrId);
                lable.Text = Janr.Name;
            


        }

    }
}