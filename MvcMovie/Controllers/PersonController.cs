using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers
{
    public class PersonController : Controller
    {
        public string Index()
        {
            return "Hello";
        }
        public string Welcome()
        {
            return "This is ....";

        }
    }
}