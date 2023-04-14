using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class HC2ViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public HC2ViewComponent (IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHC = RouteData?.Values["hairColor"];

            var hc2 = repo.burialmain.Select(x => x.haircolor)
                .Distinct()
                .OrderBy(x => x);

            return View(hc2);
        }
    }
}
