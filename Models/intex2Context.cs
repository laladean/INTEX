using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace INTEX.Models
{
    public class intex2Context : DbContext
    {
        public intex2Context()
        {
        }

        public intex2Context(DbContextOptions<intex2Context> options)
            : base(options)
        {
        }

        public   DbSet<analysis> Analysis { get; set; }
        public   DbSet<analysistextile> AnalysisTextile { get; set; }
        public   DbSet<artifactfagelgamousregister> Artifactfagelgamousregister { get; set; }
        public   DbSet<artifactfagelgamousregisterburialmain> ArtifactfagelgamousregisterBurialmain { get; set; }
        public   DbSet<artifactkomaushimregister> Artifactkomaushimregister { get; set; }
        public   DbSet<artifactkomaushimregisterBurialmain> ArtifactkomaushimregisterBurialmain { get; set; }
        public   DbSet<biological> Biological { get; set; }
        public   DbSet<biologicalc14> BiologicalC14 { get; set; }
        public   DbSet<bodyanalysischart> Bodyanalysischart { get; set; }
        public   DbSet<books> Books { get; set; }
        public   DbSet<burialmain> burialmain { get; set; }
        public   DbSet<burialmainbiological> BurialmainBiological { get; set; }
        public   DbSet<burialmainbodyanalysischart> BurialmainBodyanalysischart { get; set; }
        public   DbSet<burialmaincranium> BurialmainCranium { get; set; }
        public   DbSet<burialmaintextile> BurialmainTextile { get; set; }
        public   DbSet<c14> C14 { get; set; }
        public   DbSet<color> Color { get; set; }
        public   DbSet<colortextile> ColorTextile { get; set; }
        public   DbSet<cranium> Cranium { get; set; }
        public   DbSet<decoration> Decoration { get; set; }
        public   DbSet<decorationtextile> DecorationTextile { get; set; }
        public   DbSet<dimension> Dimension { get; set; }
        public   DbSet<dimensiontextile> DimensionTextile { get; set; }
        public   DbSet<newsarticle> Newsarticle { get; set; }
        public   DbSet<photodata> Photodata { get; set; }
        public   DbSet<photodatatextile> PhotodataTextile { get; set; }
        public   DbSet<photoform> Photoform { get; set; }
        public   DbSet<structure> Structure { get; set; }
        public   DbSet<structuretextile> StructureTextile { get; set; }
        public   DbSet<teammember> Teammember { get; set; }
        public   DbSet<textile> Textile { get; set; }
        public   DbSet<textilefunction> Textilefunction { get; set; }
        public   DbSet<textilefunctiontextile> TextilefunctionTextile { get; set; }
        public   DbSet<yarnmanipulation> Yarnmanipulation { get; set; }
        public   DbSet<yarnmanipulationtextile> YarnmanipulationTextile { get; set; }

        
    }
}
