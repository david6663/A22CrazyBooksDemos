using CrazyBooks_Web.Models;      //ADD
using CrazyBooks_Web.Models.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class BookController : Controller
  {
        //private Database _database { get; set; }
        private CrazyBooksDbContext _database { get; set; }

        //public BookController(Database database)
        public BookController(CrazyBooksDbContext database)
        {
            _database = database;
        }


        public IActionResult Index()
        {

            // List<Book> objList = _database.Books.ToList();
            List<Book> objList = _database.Book.ToList();

            return View(objList);
        }


        //GET CREATE
        public IActionResult Create()
        {
          return View();
        }

        //POST CREATE
        [HttpPost]
        public IActionResult Create(Book book)
        {
          if (ModelState.IsValid)
          {
                // Ajouter à la BD
                //_database.Books.Add(book);
                _database.Book.Add(book);
                //ADD pour update base de données. Celui en haut c'est juste le look. 
                _database.SaveChanges();
                return this.RedirectToAction("Index");
            }

          return this.View(book);
        }
  }
}
