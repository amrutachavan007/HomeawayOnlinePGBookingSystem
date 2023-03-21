using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using BOL;
using SAL;
namespace HomeAway.Controllers;

public class PaymentController : Controller
{
    private readonly ILogger<PaymentController> _logger;

    BookingService bService=new BookingService();
    public PaymentController(ILogger<PaymentController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult PaymentPage1(int id1,int rno,double amount,string date)
    {
        
        Booking bRoom=new Booking{
            CustomerId=id1,
            RoomId=rno,
            BookingAmount=amount,
            Date=date
        };
        bService.AddBookingDetails(bRoom);
        return View();
    }

    [HttpPost]
     public IActionResult PaymentSuccess()
    {

        return Content("Thank you...Payment Successful...");
    }
}
