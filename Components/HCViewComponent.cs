using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class HCViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public HCViewComponent (IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHC = RouteData?.Values["hairColor"];

            var hc = repo.burialmain.Select(x => x.haircolor)
                .Distinct()
                .OrderBy(x => x);

            return View(hc);
        }
    }
}
