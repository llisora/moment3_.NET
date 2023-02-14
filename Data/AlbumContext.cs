using AlbumDirectory.Models;
using Microsoft.EntityFrameworkCore;

namespace AlbumDirectory.Data
{
    public class AlbumContext : DbContext
    {
        public AlbumContext(DbContextOptions<AlbumContext> options) : base(options)
        {

        }

        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<User> User { get; set; }

    }

}