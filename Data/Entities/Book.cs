using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Data.Entities
{
    public class Book
    {
        
        
       
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
       /* public Book(string _title, string author, int _year)
        {
            Title = _title;
            Author = author;
            Year = _year;
        }*/
    }
}
