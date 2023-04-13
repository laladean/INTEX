using System.Linq;

namespace INTEX.Models
{
    public class EFIntexRepository : IIntexRepository
    {
        private intex2Context context { get; set; }
        public EFIntexRepository (intex2Context temp)
        {
            context = temp;

        }
        public void Add(burialmain bm)
        {
            context.burialmain.Add(bm);
        }
        public void Remove(burialmain bm)
        {
            context.burialmain.Remove(bm);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        

        public IQueryable<burialmain> burialmain => context.burialmain;
        public IQueryable<analysis> analysis => context.analysis;
        public IQueryable<analysistextile> analysistextile => context.analysistextile;
        public IQueryable<artifactfagelgamousregister> artifactfagelgamousregister => context.artifactfagelgamousregister;
        public IQueryable<artifactfagelgamousregisterburialmain> artifactfagelgamousregisterburialmain => context.artifactfagelgamousregisterburialmain;
        public IQueryable<artifactkomaushimregister> artifactkomaushimregister => context.artifactkomaushimregister;
        public IQueryable<artifactkomaushimregisterburialmain> artifactkomaushimregisterburialmain => context.artifactkomaushimregisterburialmain;
        public IQueryable<biological> biological => context.biological;
        public IQueryable<biologicalc14> biologicalc14 => context.biologicalc14;
        public IQueryable<bodyanalysischart> bodyanalysischart => context.bodyanalysischart;
        public IQueryable<books> books => context.books;
        public IQueryable<burialmainbiological> burialmainbiological => context.burialmainbiological;
        public IQueryable<burialmainbodyanalysischart> burialmainbodyanalysischart => context.burialmainbodyanalysischart;
        public IQueryable<burialmaincranium> burialmaincranium => context.burialmaincranium;
        public IQueryable<burialmaintextile> burialmaintextile => context.burialmaintextile;
        public IQueryable<c14> c14 => context.c14;
        public IQueryable<color> color => context.color;
        public IQueryable<colortextile> colortextile => context.colortextile;
        public IQueryable<cranium> cranium => context.cranium;
        public IQueryable<decoration> decoration => context.decoration;
        public IQueryable<decorationtextile> decorationtextile => context.decorationtextile;
        public IQueryable<dimension> dimension => context.dimension;
        public IQueryable<dimensiontextile> dimensiontextile => context.dimensiontextile;
        public IQueryable<newsarticle> newsarticle => context.newsarticle;
        public IQueryable<photodata> photodata => context.photodata;
        public IQueryable<photodatatextile> photodatatextile => context.photodatatextile;
        public IQueryable<structure> structure => context.structure;
        public IQueryable<structuretextile> structuretextile => context.structuretextile;
        public IQueryable<teammember> teammember => context.teammember;
        public IQueryable<textile> textile => context.textile;
        public IQueryable<textilefunction> textilefunction => context.textilefunction;
        public IQueryable<textilefunctiontextile> textilefunctiontextile => context.textilefunctiontextile;
        public IQueryable<yarnmanipulation> yarnmanipulation => context.yarnmanipulation;
        public IQueryable<yarnmanipulationtextile> yarnmanipulationtextile => context.yarnmanipulationtextile;
      

    }
}
