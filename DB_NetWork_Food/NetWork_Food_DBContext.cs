using NetWork_Food.DB_NetWork_Food.Entities;
using Microsoft.EntityFrameworkCore;

namespace NetWork_Food.DB_NetWork_Food
{
    public class NetWork_Food_DBContext : DbContext
    {
        public NetWork_Food_DBContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
            //Database.EnsureDeleted();
        }

        public DbSet<User> Users { get; set; }
    }
}
