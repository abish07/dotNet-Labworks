using Microsoft.AspNetCore.Mvc;
using Lab14.Models;
namespace Lab14.Controllers;

public class SimpleInterestController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(SimpleIntrest SI)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        return RedirectToAction("Interest",SI);
    }

    public IActionResult Interest(SimpleIntrest SI)
    {
        SI.SimpleInterestAmount = (SI.Principal*SI.Time*SI.Rate)/100;
        return View(SI);
    }
}