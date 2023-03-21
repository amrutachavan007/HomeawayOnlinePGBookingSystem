using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using SAL;
using BOL;
namespace HomeAway.Controllers;

public class CustomerController : Controller
{
    private readonly ILogger<CustomerController> _logger;

    CustomerService cservice=new CustomerService();
    RoomService rservice=new RoomService();
    public CustomerController(ILogger<CustomerController> logger)
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
    [HttpGet]
    public IActionResult RegisterCustomer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult RegisterCustomer(string cname, string contactNo, string email,string password)
    {
        string customerName=cname;
        Customer customer=new Customer{
            CustomerName=cname,
            CustomerContactNo=contactNo,
            CustomerEmail=email,
            CustomerPassword=password
        };
        bool status=cservice.RegisterCustomer(customer);
        if(status){
            //Redirect to login page 
            return RedirectToAction("Index","Account");
           // return RedirectToAction("Login","Customer");
        }
       // return Content("<script>alert('Please enter valid details');</script>");
        return View();
    }

    [HttpGet]
    public IActionResult ShowCustomerDetails(){
        List<Customer> clist=new List<Customer>();
        clist=cservice.ShowCustomerDetails();
        if(clist is not null)
        {
            ViewData["clist"]=clist;
        }
        return View();
    }

    [HttpGet]
    public IActionResult UpdateCustomer(int CustomerId){
        Customer customer=cservice.UpdateCustomer(CustomerId);

        if(customer is not null){
            ViewData["customer"]=customer;
        } 
        return View();
    }

    [HttpPost]
    public IActionResult UpdateCustomer(string id1,string cname, string contactNo, string email,string password){
        int Id1=int.Parse(id1);
        Console.WriteLine(Id1);
        Customer customer=new Customer{
            CustomerId=Id1,
            CustomerName=cname,
            CustomerContactNo=contactNo,
            CustomerEmail=email,
            CustomerPassword=password
        };
        bool status=cservice.UpdateCustomer(customer);

        if(status)
        return Content("<script>Updated Successfully</script>");
        else
        return Content("Can't update");
        //return Content(<script>alert('Updated Successfully');</script>);
    }

    [HttpGet]
    public IActionResult DeleteCustomer(string CustomerId)
    {
        //int CustomerId=id1;
        int CustomerId1 = int.Parse(CustomerId);
        Console.WriteLine(CustomerId);
        bool status = cservice.DeleteCustomer(CustomerId1);
        if (status)
        {
            return Content("Deleted Successfully");
        }
        return Content("Not deleted");
    }
}
