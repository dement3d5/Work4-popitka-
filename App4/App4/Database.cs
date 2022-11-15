using App4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    public class Database
    {
        private List<Janr> janrs = new List<Janr>();
        private List<Book> books = new List<Book>();
        private int autoincrement = 2;

        public Database() 
        { 
            Janr janrs1 = new Janr
            {
                Id = 1,
                Name="пьеса"
            };

            Janr janrs2 = new Janr
            {
                Id = 2,
                Name = "харам"
            };


            Book bookName1 = new Book
            {
                Id=1,
                Name = "Колобок"
            };

            Book bookName2 = new Book
            {
                Id = 2,
                Name = "Золушка"
            };

            books.Add(bookName1);
            books.Add(bookName2);
            janrs.Add(janrs1);
            janrs.Add(janrs2);
        }

        public Task<List<Book>> GetBooks()
        {
            return Task.FromResult(books);
        }

        public Task<Book> GetBook(int id)
        {
            return Task.FromResult(books.Find(s => s.Id == id));
        }

        public Task<List<Janr>> GetJanrs()
        {
            return Task.FromResult(janrs);
        }

        public Task <Janr> GetJanr(int id)
        {
            return Task.FromResult(janrs.Find(s => s.Id == id));
        }


        public Task AddBook(Book book)
        {
            book.Id = ++autoincrement;
            books.Add(book);
            return Task.CompletedTask;
        }

        public async Task EditBook(Book book)
        {
            Book oldBook = await GetBook(book.Id);
            oldBook = book;
        }

        public Task DeleteBook(Book book)
        {

            books.Remove(book);
            return Task.CompletedTask;
        }

        public Task AddJanr(Janr janr)
        {
            janr.Id = ++autoincrement;
            janrs.Add(janr);
            return Task.CompletedTask;
        }

        public async Task EditJanr(Janr janr)
        {
            Janr oldJanr = await GetJanr(janr.Id);
            oldJanr = janr;
        }

        public Task DeleteJanr(Janr janr)
        {

            janrs.Remove(janr);
            return Task.CompletedTask;
        }
       
    }
}
       