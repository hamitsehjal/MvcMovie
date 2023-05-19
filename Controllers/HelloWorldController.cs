using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        // GET: /HelloWorld
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name,int count=1) {
            ViewData["greeting"] = "Hi " + name + " !! How are you doing??";
            ViewData["count"] = count;
            return View();

        }
    }
}
