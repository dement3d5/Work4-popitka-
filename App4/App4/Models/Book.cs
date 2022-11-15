using System;
using System.Collections.Generic;
using System.Text;

namespace App4.Models
{
    public class Book
    {
        public int Id { get; set; }

        public int JanrId { get; set; }

        public string Name { get; set; }

        public string JanrName { get; set; }
    }
}
