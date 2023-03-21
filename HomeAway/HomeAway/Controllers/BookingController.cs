using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
//using Customer;

namespace HomeAway.Controllers;

public class BookingController : Controller
{
    private readonly ILogger<BookingController> _logger;

    public BookingController(ILogger<BookingController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult BookRoom()
    {
       // Customer 
        return View();
    }

  

   
}
