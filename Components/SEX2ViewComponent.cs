using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class SEX2ViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public SEX2ViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedSEX = RouteData?.Values["bSex"];

            var sex2 = repo.burialmain.Select(x => x.sex)
                .Distinct()
                .OrderBy(x => x);

            return View(sex2);
        }
    }
}
