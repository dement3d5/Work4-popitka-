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
    [QueryProperty(nameof(BookId), nameof(BookId))]
    public partial class BookDetailPage : ContentPage
    {
        private int bookId;
        public int BookId
        {
            get => bookId;
            set
            {
                bookId = value;
                if (BookId > 0)
                {
                    SelectedBook = App.DataBase.GetBook(BookId);
                    lable.Text = SelectedBook.JanrName;

                }

            }

        }

        public Book SelectedBook { get; set; }


        public BookDetailPage()
        {
            InitializeComponent();
        }
    }
}