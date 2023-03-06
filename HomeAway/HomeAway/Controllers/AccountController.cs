using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;
using BOL;
using SAL;
using DAL;
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
             TempData["msg"]=u.Email;
             return Redirect("Welcome");
        } //check customer role and redirect to resp page
        else if(u!=null && u.Role==2)
        {
            return Redirect("/Customer");
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