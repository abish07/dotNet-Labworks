using Lab13.Models;
using Microsoft.AspNetCore.Mvc;
using Lab13.Models;

namespace Lab13.Controllers;

public class StudentController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View(student);
        }
        return RedirectToAction("Success",student);
    }

    public IActionResult Success(Student student)
    {
        return View(student);
    }
}