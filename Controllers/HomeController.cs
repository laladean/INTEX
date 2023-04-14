using INTEX.Components;
using INTEX.Models;
using INTEX.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;

namespace INTEX.Controllers
{
    public class HomeController : Controller
    {
        private IIntexRepository repo;


        public HomeController (IIntexRepository temp)

        {
            repo = temp;
        }


        public IActionResult Burials(string hairColor, string ageAtDeath, string burialDepth, string bSex, string stature, int pageNum = 1)

        {
            int pageSize = 100;

            var x = new BurialsViewModel
            {
                burials = repo.burialmain
                .Where(b => (hairColor == null || b.haircolor == hairColor) &&
                (ageAtDeath == null || b.ageatdeath == ageAtDeath) &&
                (burialDepth == null || b.depth == burialDepth) &&
                (bSex == null || b.sex == bSex) &&
                (stature == null || b.length == stature))
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
                        (burialDepth == null || b.depth == burialDepth) &&
                        (bSex == null || b.sex == bSex) &&
                        (stature == null || b.length == stature))
                        .Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

            ViewBag.SelectedHairColor = hairColor;
            ViewBag.SelectedAgeAtDeath = ageAtDeath;
            ViewBag.SelectedBurialDepth = burialDepth;
            ViewBag.SelectedSex = bSex;
            ViewBag.SelectedLength = stature;

            return View(x);
        }



        public IActionResult BurialDetail(string burialidcomp)
        {
            var burial = repo.burialmain.FirstOrDefault(b => b.burialidcomp == burialidcomp);

            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        public IActionResult CRUD(string hairColor, string ageAtDeath, string burialDepth, string bSex, string stature, int pageNum = 1)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("InvalidCredentials");
            }

            
            var burials = repo.burialmain.Where(b => (hairColor == null || b.haircolor == hairColor) &&
                (ageAtDeath == null || b.ageatdeath == ageAtDeath) &&
                (burialDepth == null || b.depth == burialDepth) &&
                (bSex == null || b.sex == bSex) &&
                (stature == null || b.length == stature)).ToList();

            ViewBag.SelectedHairColor = hairColor;
            ViewBag.SelectedAgeAtDeath = ageAtDeath;
            ViewBag.SelectedBurialDepth = burialDepth;
            ViewBag.SelectedSex = bSex;
            ViewBag.SelectedLength = stature;


            return View(burials);
        }

        [HttpGet]
        public IActionResult AddBurial()
        {
            return View("BurialForm");
        }

        [HttpPost]
        public IActionResult AddBurial (burialmain bm) {

           if (!ModelState.IsValid)
            {
                return View("BurialForm");
            }

            repo.Add(bm);
            repo.SaveChanges();
            
            return View("Confirmation");
        }

        [HttpGet]
        public IActionResult Edit(string burialidcomp)
        {
            var burial = repo.burialmain.FirstOrDefault(b => b.burialidcomp == burialidcomp);

            if (burial == null)
            {
                return NotFound();
            }

            return View("BurialForm", burial);
        }

        [HttpPost]
        public IActionResult Edit(burialmain update)
        {
            // Makes sure required field have not been forgotten or intentionally left blank in updating
           
                repo.Update(update);
                repo.SaveChanges();

                return RedirectToAction("Confirmation");
            
          
        }

        [HttpGet]
        public IActionResult Delete(string burialidcomp)
        {
            var burial = repo.burialmain.FirstOrDefault(b => b.burialidcomp == burialidcomp);

            if (burial == null)
            {
                return NotFound();
            }

            return View(burial);
        }

        [HttpPost]
        public IActionResult Delete(burialmain bm)
        {
            repo.Remove(bm);
            repo.SaveChanges();
            return RedirectToAction("Burials");
        }


        public IActionResult Confirmation()
        {
          return View();
        }


        public IActionResult Unsupervised()

        {
            return View();
        }

        public IActionResult InvalidCredentials()
        {
            return View();
        }

    }
}
