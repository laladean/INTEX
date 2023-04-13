using System.Linq;

namespace INTEX.Models.ViewModels
{
    public class BurialsViewModel
    {
        public IQueryable<burialmain> burials { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
