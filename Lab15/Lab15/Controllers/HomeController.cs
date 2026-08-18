using System.Diagnostics;
using Lab15.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab15.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Student student)
    {
        if (ModelState.IsValid)
        {
            ViewBag.message = "Form Submitted Successfully";
        }
        return View(student);
        
    }
}