using Microsoft.EntityFrameworkCore;
using tictactoe.Models;

namespace tictactoe
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DatabaseContext()
        {
        }

        public DbSet<User> Users { get; set; }
        
    }
}
