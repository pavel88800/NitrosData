using Microsoft.EntityFrameworkCore;
using NitrosData.DB.Models;

namespace NitrosData.DB
{
    public class NitrosDbContext : DbContext
    {
        public NitrosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UsersUsers> UsersUsers { get; set; }


        /// <summary>
        ///     Инициализация контекста.
        /// </summary>
        public void Init()
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}