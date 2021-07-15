using Microsoft.AspNetCore.Mvc;

namespace chalestriunfoApi.Controllers
{
    public class products : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}