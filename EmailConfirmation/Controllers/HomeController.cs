using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using EmailConfirmation.Models;

namespace EmailConfirmation.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }


}
