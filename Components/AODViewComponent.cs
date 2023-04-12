using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class AODViewComponent : ViewComponent
    {
         
        private IIntexRepository repo { get; set; }
        public AODViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedAOD = RouteData?.Values["ageAtDeath"];

            var aod = repo.burialmain.Select(x => x.ageatdeath)
                .Distinct()
                .OrderBy(x => x);

            return View(aod);
        }
    }
}
