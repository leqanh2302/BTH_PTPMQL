using System.Runtime.Serialization;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HeThongPhanPhoiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(HeThongPhanPhoi HT)
        {
            string strResult = "Hello" + HT.MaHTPP + " - " + HT.TenHTPP  + "!" ;
            ViewBag.thongbao = strResult;
            return View();
        }

    }
}