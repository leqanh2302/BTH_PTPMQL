using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
          return View();  
        }
        [HttpPost]
        public IActionResult Index(Person ps )
        {
            string strResult = "Hello"+ ps.Personid+"-"+ps.FullName+"-"+ps.Address;
            ViewBag.thongbao = strResult;
            return View();
        }
        
    }
}
