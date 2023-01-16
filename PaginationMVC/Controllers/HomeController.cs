using PagedList;
using PaginationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginationMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string sort_Order, string key_search, string Filter_value, int? Page_no)
        {
            List<Book> bookList = new List<Book>()
            {
                new Book("Les Miserables", "Victor Hugo", 1862),
                new Book("L'Etranger", "Albert Camus", 1942),
                new Book("Madame Bovary", "Gustave Flaubert", 1857),
                new Book("Le Comte de Monte-Cristo", "Alexandre Dumas", 1844),
                new Book("Les Miserables", "Victor Hugo", 1862),
                new Book("L'Etranger", "Albert Camus", 1942),
                new Book("Madame Bovary", "Gustave Flaubert", 1857),
                new Book("Le Comte de Monte-Cristo", "Alexandre Dumas", 1844),
                new Book("Les Miserables", "Victor Hugo", 1862),
                new Book("L'Etranger", "Albert Camus", 1942),
                new Book("Madame Bovary", "Gustave Flaubert", 1857),
                new Book("Le Comte de Monte-Cristo", "Alexandre Dumas", 1844),
                new Book("Les Miserables", "Victor Hugo", 1862),
                new Book("L'Etranger", "Albert Camus", 1942),
                new Book("Madame Bovary", "Gustave Flaubert", 1857),
                new Book("Le Comte de Monte-Cristo", "Alexandre Dumas", 1844),
                new Book("Candide", "Voltaire", 1759)
            };
            ViewBag.libro_titulo = String.IsNullOrEmpty(sort_Order) ? "libro_titulo" : "";
            ViewBag.libro_director = String.IsNullOrEmpty(sort_Order) ? "libro_director" : "";
            ViewBag.libro_anio = String.IsNullOrEmpty(sort_Order) ? "libro_anio" : "";
            if (key_search != null)
            {
                Page_no = 1;
            }
            else
            {
                key_search = Filter_value;
            }
            if (!String.IsNullOrEmpty(key_search))
            {
                bookList = bookList.Where(libro => libro.Title.Contains(key_search)).ToList();
            }

            switch (sort_Order)
            {
                case "libro_titulo":
                    bookList = bookList.OrderBy(tur => tur.Title).ToList();
                    break;
                case "libro_director":
                    bookList = bookList.OrderBy(tur => tur.Director).ToList();
                    break;
                case "libro_anio":
                    bookList = bookList.OrderByDescending(tur => tur.PubDate).ToList();
                    break;
                default:
                    bookList = bookList.OrderBy(tur => tur.Title).ToList();
                    break;
            }
            int cantidad_por_pagina = 10;
            int pagina_actual = (Page_no ?? 1);
            return View(bookList.ToPagedList(pagina_actual, cantidad_por_pagina));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}