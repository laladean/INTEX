using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace INTEX.Components
{
    public class LENViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public LENViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHC = RouteData?.Values["stature"];

            var len = repo.burialmain.Select(x => x.length)
                .Distinct()
                .OrderBy(x => x);

            return View(len);
        }
    }
}
