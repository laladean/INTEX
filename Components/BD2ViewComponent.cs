using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class BD2ViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public BD2ViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedBD = RouteData?.Values["burialDepth"];

            var bd2 = repo.burialmain.Select(x => x.depth)
                .Distinct()
                .OrderBy(x => x);

            return View(bd2);
        }
    }
}

