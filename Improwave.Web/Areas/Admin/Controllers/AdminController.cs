using Microsoft.AspNetCore.Mvc;

namespace Improwave.Web.Areas.Admin.Controllers;

public class AdminController : Controller
{
    [Area("Admin")]
    public IActionResult Index()
    {
        return View();
    }
}