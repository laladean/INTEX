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

        public   DbSet<analysis> analysis { get; set; }
        public   DbSet<analysistextile> analysistextile { get; set; }
        public   DbSet<artifactfagelgamousregister> artifactfagelgamousregister { get; set; }
        public   DbSet<artifactfagelgamousregisterburialmain> artifactfagelgamousregisterburialmain { get; set; }
        public   DbSet<artifactkomaushimregister> artifactkomaushimregister { get; set; }
        public   DbSet<artifactkomaushimregisterburialmain> artifactkomaushimregisterburialmain { get; set; }
        public   DbSet<biological> biological { get; set; }
        public   DbSet<biologicalc14> biologicalc14 { get; set; }
        public   DbSet<bodyanalysischart> bodyanalysischart { get; set; }
        public   DbSet<books> books { get; set; }
        public   DbSet<burialmain> burialmain { get; set; }
        public   DbSet<burialmainbiological> burialmainbiological { get; set; }
        public   DbSet<burialmainbodyanalysischart> burialmainbodyanalysischart { get; set; }
        public   DbSet<burialmaincranium> burialmaincranium { get; set; }
        public   DbSet<burialmaintextile> burialmaintextile { get; set; }
        public   DbSet<c14> c14 { get; set; }
        public   DbSet<color> color { get; set; }
        public   DbSet<colortextile> colortextile { get; set; }
        public   DbSet<cranium> cranium { get; set; }
        public   DbSet<decoration> decoration { get; set; }
        public   DbSet<decorationtextile> decorationtextile { get; set; }
        public   DbSet<dimension> dimension { get; set; }
        public   DbSet<dimensiontextile> dimensiontextile { get; set; }
        public   DbSet<newsarticle> newsarticle { get; set; }
        public   DbSet<photodata> photodata { get; set; }
        public   DbSet<photodatatextile> photodatatextile { get; set; }
        public   DbSet<photoform> photoform { get; set; }
        public   DbSet<structure> structure { get; set; }
        public   DbSet<structuretextile> structuretextile { get; set; }
        public   DbSet<teammember> teammember { get; set; }
        public   DbSet<textile> textile { get; set; }
        public   DbSet<textilefunction> textilefunction { get; set; }
        public   DbSet<textilefunctiontextile> textilefunctiontextile { get; set; }
        public   DbSet<yarnmanipulation> yarnmanipulation { get; set; }
        public   DbSet<yarnmanipulationtextile> yarnmanipulationtextile { get; set; }


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
