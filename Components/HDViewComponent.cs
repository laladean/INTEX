using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class HDViewComponent:ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public HDViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHD = RouteData?.Values["headDirection"];

            var hd = repo.burialmain.Select(x => x.headdirection)
                .Distinct()
                .OrderBy(x => x);

            return View(hd);
        }
    }
}
