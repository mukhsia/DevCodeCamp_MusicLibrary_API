using Microsoft.EntityFrameworkCore;
using SongsWebAPI.Models;

namespace SongsWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }

        // Model Seed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure Song entity
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Title1",
                    Artist = "Artist1",
                    Album = "Album1",
                    ReleaseDate = new DateTime(2021, 1, 1),
                    Genre = "Genre1"
                },
                new Song
                {
                    Id = 2,
                    Title = "Title2",
                    Artist = "Artist2",
                    Album = "Album2",
                    ReleaseDate = new DateTime(2022, 2, 2),
                    Genre = "Genre2"
                }
            );
        }
    }
}
