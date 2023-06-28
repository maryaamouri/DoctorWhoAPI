using Microsoft.EntityFrameworkCore;
using DoctorWhoDomain;
using System.Reflection.Metadata;

namespace DoctorWhoData
{
    public class DoctorWhoDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Episode> Episodes { get; set;}
        public DbSet<EpisodeEnemy> EpisodeEnemies { get;set; }
        public DbSet<EpisodeCompanion> EpisodeCompanions { get;set; }
        public DbSet<ViewEpisode> ViewEpisodes { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoDB"
            );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<Doctor>()
            .HasMany(e => e.Episodes)
            .WithOne(e => e.doctor)
            .IsRequired();

        modelBuilder.Entity<Author>()
            .HasMany(e => e.Episodes)
            .WithOne(e => e.author)
            .IsRequired();

        modelBuilder.Entity<Episode>()
            .HasMany(e => e.Companions)
            .WithMany(e => e.Episodes)
            .UsingEntity<EpisodeCompanion>();

        modelBuilder.Entity<Episode>()
            .HasMany(e=>e.Enemies)
            .WithMany(e=>e.Episodes)
            .UsingEntity<EpisodeEnemy>();
            modelBuilder.Entity<ViewEpisode>()
                    .HasNoKey()
                    .ToView("ViewEpisodes");
            Seeder.Seed(modelBuilder);
    }
    }
}