using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers;

public class UserController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost("create")]
    public IActionResult Create(User user)
    {
        if (ModelState.IsValid)
        {
            return View("Success");
        }
        else
        {
            return View("Index");
        }
    }
}
