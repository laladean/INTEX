using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        private intex2Context context { get; set; }
        public HomeController(intex2Context temp) => context = temp;
        public IActionResult Index()
        {
            var x = context.burialmain.ToList();
            return View(x);
        }
    }
}
