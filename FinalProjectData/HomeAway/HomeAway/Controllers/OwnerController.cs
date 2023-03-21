using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using SAL;
using BOL;
namespace HomeAway.Controllers;

public class OwnerController : Controller
{
    private readonly ILogger<OwnerController> _logger;

    OwnerService oservice=new OwnerService();
    public OwnerController(ILogger<OwnerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult AddOwner()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddOwner(string oname, string contactNo, string email)
    {
        Owner owner=new Owner{
            OwnerName=oname,
            OwnerContactNo=contactNo,
            OwnerEmail=email
        };
        bool status=oservice.AddOwner(owner);
        if(status){
            //Redirect to login page 
            return RedirectToAction("Index","Admin");
           
        }
       // return Content("<script>alert('Please enter valid details');</script>");
        return View();
    }

    [HttpGet]
    public IActionResult ShowOwnerDetails(){
        List<Owner> olist=new List<Owner>();
        olist=oservice.ShowOwnerDetails();
        if(olist is not null)
        {
            ViewData["olist"]=olist;
        }
        return View();
    }

    [HttpGet]
    public IActionResult UpdateOwner(int OwnerId){
        Owner owner=oservice.UpdateOwner(OwnerId);

        if(owner is not null){
            ViewData["owner"]=owner;
        } 
        return View();
    }

    [HttpPost]
    public IActionResult UpdateOwner(string id1,string oname, string contactNo, string email){
        int Id1=int.Parse(id1);
        Console.WriteLine(Id1);
        Owner owner=new Owner{
            OwnerId=Id1,
            OwnerName=oname,
            OwnerContactNo=contactNo,
            OwnerEmail=email   
        };
        bool status=oservice.UpdateOwner(owner);

        if(status)
        return Content("<script>Updated Successfully</script>");
        else
        return Content("Can't update");
        //return Content(<script>alert('Updated Successfully');</script>);
    }

    [HttpGet]
    public IActionResult DeleteOwner(string OwnerId)
    {
        int OwnerId1 = int.Parse(OwnerId);
        Console.WriteLine(OwnerId);
        bool status = oservice.DeleteOwner(OwnerId1);
        if (status)
        {
            return Content("Deleted Successfully");
        }
        return Content("Not deleted");
    }
}
