using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookService.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string  Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }


        //Foreign Key
        
        public int AuthorId { get; set; }

        //Navigation property
        //assuming that each book has a single author.
        public Author Author { get; set; }
    }
}