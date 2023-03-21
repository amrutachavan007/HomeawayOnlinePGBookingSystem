using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HomeAway.Models;

namespace HomeAway.Controllers;

public class PaymentController : Controller
{
    private readonly ILogger<PaymentController> _logger;

    public PaymentController(ILogger<PaymentController> logger)
    {
        _logger = logger;
    }

    public IActionResult PaymentPage()
    {
        return View();
    }
}
