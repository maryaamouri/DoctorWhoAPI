using DoctorWhoDomain;
using Microsoft.EntityFrameworkCore;

namespace DoctorWhoData
{
    internal static class Seeder
    {
        internal static void Seed(ModelBuilder modelBuilder)
        {
            SeedAuthors(modelBuilder);
            SeedEnemy(modelBuilder);
            SeedDoctor(modelBuilder);
            SeedEpisode(modelBuilder);
            SeedEpisodeEnemy(modelBuilder);
            SeedCompinion(modelBuilder);
            SeedEpisodeCompanion(modelBuilder);
        }
        private static void SeedAuthors(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorId = 1, Name = "Author 1" },
                new Author { AuthorId = 2, Name = "Author 2" },
                new Author { AuthorId = 3, Name = "Author 3" },
                new Author { AuthorId = 4, Name = "Author 4" },
                new Author { AuthorId = 5, Name = "Author 5" }
            );
        }
        private static void SeedEnemy(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enemy>().HasData(
                new Enemy { EnemyId = 1, Name = "Enemy 1", Description = "Description 1" },
                new Enemy { EnemyId = 2, Name = "Enemy 2", Description = "Description 2" },
                new Enemy { EnemyId = 3, Name = "Enemy 3", Description = "Description 3" },
                new Enemy { EnemyId = 4, Name = "Enemy 4", Description = "Description 4" },
                new Enemy { EnemyId = 5, Name = "Enemy 5", Description = "Description 5" }
        );
        }
        private static void SeedDoctor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { DoctorId = 1, Number = "Doctor 1", Name = "Doctor Name 1", BirthDate = DateTime.Now, FirstEpisodeDate = DateTime.Now, LastEpisodeDate = DateTime.Now },
                new Doctor { DoctorId = 2, Number = "Doctor 2", Name = "Doctor Name 2", BirthDate = DateTime.Now, FirstEpisodeDate = DateTime.Now, LastEpisodeDate = DateTime.Now },
                new Doctor { DoctorId = 3, Number = "Doctor 3", Name = "Doctor Name 3", BirthDate = DateTime.Now, FirstEpisodeDate = DateTime.Now, LastEpisodeDate = DateTime.Now },
                new Doctor { DoctorId = 4, Number = "Doctor 4", Name = "Doctor Name 4", BirthDate = DateTime.Now, FirstEpisodeDate = DateTime.Now, LastEpisodeDate = DateTime.Now },
                new Doctor { DoctorId = 5, Number = "Doctor 5", Name = "Doctor Name 5", BirthDate = DateTime.Now, FirstEpisodeDate = DateTime.Now, LastEpisodeDate = DateTime.Now }
            );
        }
        private static void SeedEpisode(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Episode>().HasData(
                new Episode { EpisodeId = 1, Number = 1, SeriesNumber = 1, Type = "Type 1", Title = "Episode 1", EpisodeDate = DateTime.Now, AuthorId = 1, DoctorId = 1, Notes = "Note 1" },
                new Episode { EpisodeId = 2, Number = 2, SeriesNumber = 1, Type = "Type 1", Title = "Episode 2", EpisodeDate = DateTime.Now, AuthorId = 2, DoctorId = 2, Notes = "Note 2" },
                new Episode { EpisodeId = 3, Number = 3, SeriesNumber = 1, Type = "Type 1", Title = "Episode 3", EpisodeDate = DateTime.Now, AuthorId = 3, DoctorId = 3, Notes = "Note 3" },
                new Episode { EpisodeId = 4, Number = 4, SeriesNumber = 1, Type = "Type 1", Title = "Episode 4", EpisodeDate = DateTime.Now, AuthorId = 4, DoctorId = 4, Notes = "Note 4" },
                new Episode { EpisodeId = 5, Number = 5, SeriesNumber = 1, Type = "Type 1", Title = "Episode 5", EpisodeDate = DateTime.Now, AuthorId = 5, DoctorId = 5, Notes = "Note 5" }
            );
        }
        private static void SeedEpisodeEnemy(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeEnemy>().HasData(
                 new EpisodeEnemy { EpisodeEnemyId = 1, EpisodeId = 1, EnemyId = 1 },
                 new EpisodeEnemy { EpisodeEnemyId = 2, EpisodeId = 2, EnemyId = 2 },
                 new EpisodeEnemy { EpisodeEnemyId = 3, EpisodeId = 3, EnemyId = 3 },
                 new EpisodeEnemy { EpisodeEnemyId = 4, EpisodeId = 4, EnemyId = 4 },
                 new EpisodeEnemy { EpisodeEnemyId = 5, EpisodeId = 5, EnemyId = 5 }
             );
        }
        private static void SeedCompinion(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Companion>().HasData(
                new Companion { CompanionId = 1, Name = "Companion 1", WhoPlayed = "Actor 1" },
                new Companion { CompanionId = 2, Name = "Companion 2", WhoPlayed = "Actor 2" },
                new Companion { CompanionId = 3, Name = "Companion 3", WhoPlayed = "Actor 3" },
                new Companion { CompanionId = 4, Name = "Companion 4", WhoPlayed = "Actor 4" },
                new Companion { CompanionId = 5, Name = "Companion 5", WhoPlayed = "Actor 5" }
            );
        }
        private static void SeedEpisodeCompanion(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodeCompanion>().HasData(
                new EpisodeCompanion { EpisodeCompanionId = 1, EpisodeId = 1, CompanionId = 1 },
                new EpisodeCompanion { EpisodeCompanionId = 2, EpisodeId = 2, CompanionId = 2 },
                new EpisodeCompanion { EpisodeCompanionId = 3, EpisodeId = 3, CompanionId = 3 },
                new EpisodeCompanion { EpisodeCompanionId = 4, EpisodeId = 4, CompanionId = 4 },
                new EpisodeCompanion { EpisodeCompanionId = 5, EpisodeId = 5, CompanionId = 5 }
            );
        }
    }

}