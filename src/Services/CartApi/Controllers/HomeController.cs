using Microsoft.AspNetCore.Mvc;

namespace CartApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/ui");
        }
    }
}