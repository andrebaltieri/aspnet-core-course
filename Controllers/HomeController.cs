using System.Threading.Tasks;
using AspNetMac.Data;
using AspNetMac.Models;
using Microsoft.AspNet.Mvc;

namespace AspNetMac.Controllers
{
    public class HomeController : Controller
    {    
        public HomeController(AppDataContext context)
        {
            _db = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}