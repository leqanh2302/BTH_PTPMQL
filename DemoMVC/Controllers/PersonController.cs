using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    { 
        // GET: /Person/
        public IActionResult Index()
        {
            
            return View();
        }

        // GET: /Person/Welcome/ 
        public string Welcome()
        {
            return "Hello ...";
        }
    }
}
