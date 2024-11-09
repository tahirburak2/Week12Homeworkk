using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Soru2;

namespace Soru2.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
