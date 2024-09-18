using Microsoft.AspNetCore.Mvc;

namespace Improwave.Web.Controllers;

public class AccountController : Controller
{
    // GET
    public IActionResult Register()
    {
        return View();
    }
    
    public IActionResult Login()
    {
        return View();
    }
}