using Microsoft.EntityFrameworkCore;

namespace SongsWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {

        }
    }
}
