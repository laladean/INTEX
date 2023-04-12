using INTEX.Models;
using INTEX.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        private IIntexRepository repo;

        public HomeController (IIntexRepository temp)
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
    }
}
