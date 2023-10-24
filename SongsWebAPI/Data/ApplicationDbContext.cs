﻿using Microsoft.EntityFrameworkCore;
using SongsWebAPI.Models;

namespace SongsWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
