using Microsoft.AspNetCore.Mvc;

namespace Improwave.Web.Areas.Admin.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}