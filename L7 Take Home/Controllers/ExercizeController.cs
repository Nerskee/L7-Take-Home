using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using L7_Take_Home.Models;

namespace L7_Take_Home.Controllers;

public class ExercizeController : Controller
{
    private readonly ApplicationDbContext _db;
    
    public ExercizeController(ApplicationDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View(_db.Exercizes.ToList());
    }
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("Id, Name, Date")] Exercize exercize)
    {
        if (ModelState.IsValid)
        {
            _db.Add(exercize);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(exercize);
    }
}