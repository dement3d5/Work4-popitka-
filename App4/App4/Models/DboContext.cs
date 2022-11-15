using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace App4.Models
{
    public class DboContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
        public DbSet<Janr> Janr  { get; set; }  
        
        private string _id;

        public DboContext(DbSet<Book> book, DbSet<Janr> janr, string id)
        {
            Book = book;
            Janr = janr;
            _id = id;
        }
        protected override void OnConfiguring
    }
    
}

        

   


     






