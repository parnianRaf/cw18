using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cw18_1.Models;
using AppService;
using AppCore.DTO;

namespace cw18_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
   

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
     
    //}

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}

