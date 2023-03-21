using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using BOL;
using SAL;
//using Customer;

namespace HomeAway.Controllers;

public class BookingController : Controller
{
    private readonly ILogger<BookingController> _logger;

    CustomerService cservice = new CustomerService();
    BookingService bService=new BookingService();
    RoomService rservice = new RoomService();
    public BookingController(ILogger<BookingController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult BookRoom(int userid, int roomid)
    {
        //int a=3;
        TempData.Keep();
        Customer customer = cservice.GetCustomerById(userid);
        RoomDetails room = rservice.GetRoomById(roomid);

        if (customer is not null && room is not null)
        {
            ViewData["customer"] = customer;
            ViewData["room"] = room;
        }
        return View();
    }

    public IActionResult GetAllBookingDetails()
    {
        List<Booking> bookingDetails=bService.GetAllBookingDetails();

            if(bookingDetails is not null){
                ViewData["bookingDetails"]=bookingDetails;
            }
            else{
                return Content("Room is not book...");
            }
        return View();
    }



}
