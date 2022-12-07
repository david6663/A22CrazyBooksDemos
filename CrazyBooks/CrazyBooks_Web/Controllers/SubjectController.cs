using CrazyBooks_DataAccess.Data;//ADD DEMO2
using CrazyBooks_Models.Models;  //ADD DEMO 2
using CrazyBooks_Web.Models;
//using CrazyBooks_Web.Models.Data;   //ADD
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrazyBooks.Controllers
{
  public class SubjectController : Controller
  {
    //private Database _database { get; set; }
    private CrazyBooksDbContext _database { get; set; }


    //public SubjectController(Database database)
    public SubjectController(CrazyBooksDbContext database)
    {
        _database = database;
    }
        
        
    public IActionResult Index()
    {
        //List<Subject> objList = _database.Subjects.ToList();
        List<Subject> objList = _database.Subject.ToList();

        return View(objList);
    }

    //GET CREATE
    public IActionResult Create()
    {
      return View();
    }

    //POST CREATE
    [HttpPost]
    public IActionResult Create(Subject subject)
    {
      if (ModelState.IsValid)
      {
                // Ajouter à la BD
                //_database.Subjects.Add(subject);
                _database.Subject.Add(subject);
                return this.RedirectToAction("Index");
      }

      return this.View(subject);
    }
  }
}
