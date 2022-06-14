using Microsoft.AspNetCore.Mvc;

namespace Webgentle.bookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult  Index()
        {
            return View();
        }
        
        public ViewResult  About()
        {
            return View();
        }
    }
}