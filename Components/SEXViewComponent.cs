using INTEX.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace INTEX.Components
{
    public class SEXViewComponent : ViewComponent
    {
        private IIntexRepository repo { get; set; }
        public SEXViewComponent(IIntexRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {

            ViewBag.SelectedSEX = RouteData?.Values["bSex"];

            var sex = repo.burialmain.Select(x => x.sex)
                .Distinct()
                .OrderBy(x => x);

            return View(sex);
        }
    }
}
