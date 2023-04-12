using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class BDViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public BDViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedBD = RouteData?.Values["burialDepth"];

            var bd = repo.burialmain.Select(x => x.depth)
                .Distinct()
                .OrderBy(x => x);

            return View(bd);
        }
    }
}

