using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace INTEX.Components
{
    public class LEN2ViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public LEN2ViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHC = RouteData?.Values["stature"];

            var len2 = repo.burialmain.Select(x => x.length)
                .Distinct()
                .OrderBy(x => x);

            return View(len2);
        }
    }
}
