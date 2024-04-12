using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        public string Index()
        {
            return "Hello Emp";
        }
        public string Welcome()
        {
            return "This is ....";

        }
    }
}
    