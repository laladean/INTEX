﻿using INTEX.Components;
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

        public IActionResult Burials(string hairColor, string ageAtDeath, string burialDepth, string bSex, int pageNum = 1)
        {
            int pageSize = 100;

            var x = new BurialsViewModel
            {
                burials = repo.burialmain
                .Where(b => (hairColor == null || b.haircolor == hairColor) &&
                (ageAtDeath == null || b.ageatdeath == ageAtDeath) &&
                (burialDepth == null || b.depth == burialDepth) &&
                (bSex == null || b.sex == bSex))
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
                        (bSex == null || b.sex == bSex))
                        .Count()),
                    ProjectsPerPage = pageSize,
                    CurrentPage = pageNum
                }

            };

            ViewBag.SelectedHairColor = hairColor;
            ViewBag.SelectedAgeAtDeath = ageAtDeath;
            ViewBag.SelectedBurialDepth = burialDepth;
            ViewBag.SelectedSex = bSex;


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
      
    }
}
