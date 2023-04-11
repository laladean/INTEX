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
        public   DbSet<artifactkomaushimregisterburialmain> ArtifactkomaushimregisterBurialmain { get; set; }
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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<analysistextile>()
                .HasKey(m => new { m.mainanalysisid, m.maintextileid });

            modelBuilder.Entity<artifactfagelgamousregisterburialmain>()
                .HasKey(m => new { m.mainartifactfagelgamousregisterid, m.mainburialmainid });

            modelBuilder.Entity<artifactkomaushimregisterburialmain>()
                .HasKey(m => new { m.mainartifactkomaushimregisterid, m.mainburialmainid });

            modelBuilder.Entity<biologicalc14>()
                .HasKey(m => new { m.mainbiologicalid, m.mainc14id });
            
            modelBuilder.Entity<burialmainbiological>()
                .HasKey(m => new { m.mainburialmainid, m.mainbiologicalid });

            modelBuilder.Entity<burialmainbodyanalysischart>()
                .HasKey(m => new { m.mainburialmainid, m.mainbodyanalysischartid });

            modelBuilder.Entity<burialmaincranium>()
                .HasKey(m => new { m.mainburialmainid, m.maincraniumid });

            modelBuilder.Entity<burialmaintextile>()
                .HasKey(m => new { m.mainburialmainid, m.maintextileid });

            modelBuilder.Entity<colortextile>()
                .HasKey(m => new { m.maincolorid, m.maintextileid });

            modelBuilder.Entity<decorationtextile>()
                .HasKey(m => new { m.maindecorationid, m.maintextileid });

            modelBuilder.Entity<dimensiontextile>()
                .HasKey(m => new { m.maindimensionid, m.maintextileid });

            modelBuilder.Entity<photodatatextile>()
                .HasKey(m => new { m.mainphotodataid, m.maintextileid });

            modelBuilder.Entity<structuretextile>()
                .HasKey(m => new { m.mainstructureid, m.maintextileid });

            modelBuilder.Entity<textilefunctiontextile>()
                .HasKey(m => new { m.maintextilefunctionid, m.maintextileid });

            modelBuilder.Entity<yarnmanipulationtextile>()
                .HasKey(m => new { m.mainyarnmanipulationid, m.maintextileid });

        }

    }
}
