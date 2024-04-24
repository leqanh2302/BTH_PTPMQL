using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(Person ps )
        {
        string strResult = "Hello"+ ps.PersonID+"-"+ps.FullName+"-"+ps.Address;
            ViewBag.thongbao = strResult;
            return View();
        }
    }
}