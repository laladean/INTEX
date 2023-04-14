using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class HD2ViewComponent:ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public HD2ViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedHD2 = RouteData?.Values["headDirection"];

            var hd2 = repo.burialmain.Select(x => x.headdirection)
                .Distinct()
                .OrderBy(x => x);

            return View(hd2);
        }
    }
}
