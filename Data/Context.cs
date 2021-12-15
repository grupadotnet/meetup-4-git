using meet_up_4_git.Models;
using Microsoft.EntityFrameworkCore;

namespace meet_up_4_git.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}