using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using BOL;
using SAL;
using DAL;
using System.Text.Json;
namespace HomeAway.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;


    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
    
    public ActionResult Index()  
    {  
        return View();  
    } 
    public ActionResult Login()  
    {  
        return View();  
    } 
    public IActionResult Register()
    {
        return View();
    }
        [HttpPost]
    public IActionResult Login(string email,string pwd)
    {
        AccountService aservice=new AccountService();
        User u=aservice.GetUser(email,pwd);
        if(u!=null && u.Role==1)
        {
             Console.WriteLine(u.Email);
             ViewData["msg"]=u;
             return RedirectToAction("Index","Admin");
        } //check customer role and redirect to resp page
        else if(u!=null && u.Role==2)
        {
            TempData["msg"]=JsonSerializer.Serialize(u);
            Console.WriteLine(u.Email);
            return RedirectToAction("Index","Customer");
        }
        if(u==null)//wrong credentials
        TempData["msg"]="Login Failed Check your credentials!!!";
        return Redirect("Index");       
    }
    public IActionResult Welcome()
    {
        return View();
    }
}