using System.Threading.Tasks;
using AspNetMac.Data;
using AspNetMac.Models;
using Microsoft.AspNet.Mvc;

namespace AspNetMac.Controllers
{
    public class HomeController : Controller
    {
        private AppDataContext _db;
        
        public HomeController(AppDataContext context)
        {
            _db = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Add(product);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }
}