using System.Linq;

namespace INTEX.Models
{
    public interface IIntexRepository
    {
        IQueryable<burialmain> burialmain { get; }
    }
}
