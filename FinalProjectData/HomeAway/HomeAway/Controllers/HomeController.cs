using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using SAL;
using BOL;


namespace HomeAway.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    RoomService rservice=new RoomService();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        List<RoomDetails> rlist=new List<RoomDetails>();
        rlist=rservice.ShowRoomDetails();
        foreach(RoomDetails r in rlist){
            Console.WriteLine(r.RoomAddress);
        }

        if(rlist is not null)
        {
            ViewData["rlist"]=rlist;
        }
        
        return View();
    }

  public IActionResult Login()
    {
        return RedirectToAction("Index","Account");
    }
      public IActionResult About()
    {
        return View();
    }

       public IActionResult ContactUs()
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
