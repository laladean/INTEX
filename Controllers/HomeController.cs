using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        private IIntexRepository repo;

        public HomeController(IIntexRepository temp)
        {
            repo = temp;
        }

        public IActionResult Burials(string hairColor, string ageAtDeath, string burialDepth, int pageNum = 1)
        {
            int pageSize = 100;

            var x = new BurialsViewModel
            {
                burials = repo.burialmain
                .Where(b => (hairColor == null || b.haircolor == hairColor) &&
                (ageAtDeath == null || b.ageatdeath == ageAtDeath) &&
                (burialDepth == null || b.depth == burialDepth))
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalProjects =
                    ((hairColor == null && ageAtDeath == null)
                    ? repo.burialmain.Count()
                    : repo.burialmain
                        .Where(b => (hairColor == null || b.haircolor == hairColor) &&
                        (ageAtDeath == null || b.ageatdeath == ageAtDeath) &&
                        (burialDepth == null || b.depth == burialDepth))
                        .Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };


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









    }
}
