using Microsoft.AspNetCore.Mvc;

namespace Webgentle.bookStore.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This String is coming from index index controller";
        }
    }
}