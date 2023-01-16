using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginationMVC.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int PubDate { get; set; }
        public Book(string Title, string Director, int PubDate)
        {
            this.Title = Title;
            this.Director = Director;
            this.PubDate = PubDate;
        }
    }
}