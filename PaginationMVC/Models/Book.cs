using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginationMVC.Models
{
    public class Book
    {
        private string Title { get; set; }
        private string Director { get; set; }
        private int PubDate { get; set; }
        public Book(string Title, string Director, int PubDate)
        {
            this.Title = Title;
            this.Director = Director;
            this.PubDate = PubDate;
        }
    }
}