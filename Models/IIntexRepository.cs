using Microsoft.AspNetCore.Razor.Language;
using System.Linq;

namespace INTEX.Models
{
    public interface IIntexRepository
    {
        void Add(burialmain bm);
        void Remove(burialmain bm);
        void SaveChanges();

        IQueryable<burialmain> burialmain { get; }

    }
}
