using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using BOL;
using SAL;

namespace HomeAway.Controllers
{
    public class RoomDetailsController : Controller
    {
        private readonly ILogger<RoomDetailsController> _logger;

        RoomService rservice = new RoomService();
        public RoomDetailsController(ILogger<RoomDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult AddRoomDetails()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoomDetails(string pname, int floorno, string status,
            double rent, double deposit, string facility, string address, string gender,
            string roomtype, string url1, string url2, string url3,int ownerid)
        {
            RoomDetails roomDetails = new RoomDetails
            {
                
                PropertyName = pname,
                FloorNo = floorno,
                RoomStatus = status,
                RoomRent = rent,
                RoomDeposit = deposit,
                RoomFacility = facility,
                RoomAddress = address,
                Gender = gender,
                RoomType = roomtype,
                URL1 = url1,
                URL2 = url2,
                URL3 = url3,
                OwnerId=ownerid,
            };
            bool status1 = rservice.AddRoomDetails(roomDetails);
            if (status1)
            {

                return Content("Added Successfully");
            }
            return View();
        }

        [HttpGet]
        public IActionResult ShowRoomDetails()
        {
            List<RoomDetails> rlist = new List<RoomDetails>();
            rlist = rservice.ShowRoomDetails();
            if (rlist is not null)
            {
                ViewData["rlist"] = rlist;
            }

            return View();
        }

        [HttpGet]
        public IActionResult UpdateRoomDetails(int RoomId)
        {
            RoomDetails room = rservice.UpdateRoomDetails(RoomId);

            if (room is not null)
            {
                ViewData["room"] = room;
            }
            return View();
        }

        [HttpPost]
        public IActionResult UpdateRoom(string ownerid,string roomid, string pname, string floorno, string status,
              string rent, string deposit, string facility, string address, string gender,
              string roomtype, string url1, string url2, string url3)
        {
            int Ownerid = int.Parse(ownerid);
            int Roomid = int.Parse(roomid);
            int Floorno = int.Parse(floorno);
            double Rent = double.Parse(rent);
            double Deposit = double.Parse(deposit);

            RoomDetails rroom = new RoomDetails
            {
                RoomId = Roomid,
                PropertyName = pname,
                FloorNo = Floorno,
                RoomStatus = status,
                RoomRent = Rent,
                RoomDeposit = Deposit,
                RoomFacility = facility,
                RoomAddress = address,
                Gender = gender,
                RoomType = roomtype,
                URL1 = url1,
                URL2 = url2,
                URL3 = url3,
                OwnerId=Ownerid
            };
            bool status1 = rservice.UpdateRoom(rroom);

            return Content("Updated Successfully");
            //return Content(<script>alert('Updated Successfully');</script>);
        }


        [HttpGet]
        public IActionResult DeleteRoom(string RoomId)
        {
            int Roomid = int.Parse(RoomId);

            bool status = rservice.DeleteRoom(Roomid);
            if (status)
            {
                return Content("Deleted Successfully");
            }
            return Content("Not deleted");
        }


        [HttpGet]
        public IActionResult SearchRoom()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SearchRoomDetails(string btn)
        {

            //return Content(btn);
            List<RoomDetails> rlist = new List<RoomDetails>();
            rlist = rservice.SearchRoomDetails(btn);
            if (rlist is not null)
            {
                ViewData["rlist"] = rlist;
            }
            return View();
        }
        [HttpPost]
        public IActionResult SearchRoomDetailsByPriceRange(int min,int max)
        {
            //return Content(btn);
            List<RoomDetails> rlist = new List<RoomDetails>();
            rlist = rservice.SearchRoomDetailsByPriceRange(min,max);
            if (rlist is not null)
            {
                ViewData["rlist"] = rlist;
            }
            return View();
        }

        public IActionResult SearchRoomDetailsByPropertyName(string pname)
        {
            //return Content(btn);
            List<RoomDetails> rlist = new List<RoomDetails>();
            rlist = rservice.SearchRoomDetailsByPropertyName(pname);
            if (rlist is not null)
            {
                ViewData["rlist"] = rlist;
            }
            return View();
        }
    }
}