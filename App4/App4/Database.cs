using System;
using System.Collections.Generic;
using System.Text;

namespace App4
{
   public class Database
    {
        private List<Item> items = new List<Item>();
        private List<Book> books = new List<Book>();
      

        public Database() 
        { 
            Item item1 = new Item
            {
                Id = 1,
                Name="Первый"
            };
            Item item2 = new Item
            {
                Id = 2,
                Name = "Второй"
            };
            Book book1 = new Book
            {
                Id=1,
                Janr = "Жанры",
             

                JanrName="kolobok"

            };

          

            books.Add(book1);
          
            items.Add(item1);
            items.Add(item2);
        }
        public List<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(int id)
        {
            return items.Find(s => s.Id == id);
        }
        

        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            return books.Find(s => s.Id == id);
        }
    }
}
       