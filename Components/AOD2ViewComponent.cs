using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class AOD2ViewComponent : ViewComponent
    {
         
        private IIntexRepository repo { get; set; }
        public AOD2ViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedAOD = RouteData?.Values["ageAtDeath"];

            var aod2 = repo.burialmain.Select(x => x.ageatdeath)
                .Distinct()
                .OrderBy(x => x);

            return View(aod2);
        }
    }
}
