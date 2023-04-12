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

        public IActionResult Burials(string hairColor, string ageAtDeath, int pageNum = 1)
        {
            int pageSize = 100;

            var x = new BurialsViewModel
            {
                burials = repo.burialmain
                .Where(b => b.haircolor == hairColor || hairColor == null)
                .Where(b => b.ageatdeath == ageAtDeath || ageAtDeath == null)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalProjects = repo.burialmain.Count(),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };
                
            
            return View(x);
        }
    }
}
