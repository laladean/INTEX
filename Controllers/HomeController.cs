using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace INTEX.Controllers
{
    public class HomeController : Controller
    {

        private intex2Context context { get; set; }
        public HomeController(intex2Context temp) => context = temp;
        public IActionResult Index()

        private IIntexRepository repo;


        public HomeController (IIntexRepository temp)

        {
            var x = context.burialmain.ToList();
            return View(x);
        }


        public IActionResult BurialDetail()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddBurial()
        {
            return View("BurialForm");
        }

        [HttpPost]
        public IActionResult AddBurial (burialmain bm) {

            repo.Add(bm);
            repo.SaveChanges();
            
            return View("Confirmation");
        }

        public IActionResult Edit (int id)
        {
            var burial = repo.burialmain.Single(x => x.id == id);
            return View("BurialForm", burial);

        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var burial = repo.burialmain.Single(x => x.id == id);
            return View(burial);
        }

        [HttpPost]
        public IActionResult Delete(burialmain bm)
        {
            repo.Remove(bm);
            repo.SaveChanges();
            return RedirectToAction("Burials");
        }













>>>>>>> Stashed changes
    }
}
