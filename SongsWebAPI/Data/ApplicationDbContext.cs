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
                    Title = "You Shall Rise (feat. Merethe Soltvedt)",
                    Artist = "Rob Westwood",
                    Album = "Remnant 2 OST",
                    ReleaseDate = new DateTime(2023, 6, 25),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 2,
                    Title = "BB's Theme (from Death Stranding)",
                    Artist = "Ludvig Forssell",
                    Album = "Death Stranding OST",
                    ReleaseDate = new DateTime(2020, 6, 1),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 3,
                    Title = "BFG Division 2020 (Fortress of Doom Combat Theme)",
                    Artist = "Mick Gordon",
                    Album = "Doom Eternal OST",
                    ReleaseDate = new DateTime(2020, 3, 20),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 4,
                    Title = "Disposal Unit (Imperium Mix)",
                    Artist = "Jesper Kyd",
                    Album = "Warhammer 40,000: Darktide OST",
                    ReleaseDate = new DateTime(2022, 2, 2),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 5,
                    Title = "Annihilation",
                    Artist = "Rob Westwood",
                    Album = "Remnant 2 OST",
                    ReleaseDate = new DateTime(2023, 6, 25),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 6,
                    Title = "Sha'Hala: Guardian of N'Erud (Physical)",
                    Artist = "Rob Westwood",
                    Album = "Remnant 2 OST",
                    ReleaseDate = new DateTime(2023, 6, 25),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 7,
                    Title = "Sha'Hala: Guardian of N'Erud (Spectral)",
                    Artist = "Rob Westwood",
                    Album = "Remnant 2 OST",
                    ReleaseDate = new DateTime(2023, 6, 25),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 8,
                    Title = "Shades of Root (Cancer)",
                    Artist = "Rob Westwood",
                    Album = "Remnant 2 OST",
                    ReleaseDate = new DateTime(2023, 6, 25),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 9,
                    Title = "Vagrant Song (Deep South)",
                    Artist = "Ryan Ike",
                    Album = "Where the Water Tastes Like Wine OST",
                    ReleaseDate = new DateTime(2018, 2, 1),
                    Genre = "Game OST"
                },
                new Song
                {
                    Id = 10,
                    Title = "Rise Up Dead Man",
                    Artist = "Port Sulphur Band",
                    Album = "The Sinners Songbook (From: Hunt: Showdown)",
                    ReleaseDate = new DateTime(2021, 1, 1),
                    Genre = "Game OST"
                }
            );
        }
    }
}
