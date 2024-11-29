using InformacionLogsBots.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace InformacionLogsBots.DataAccess.DataBase
{
    public class LogContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public LogContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LogContext).Assembly);
            modelBuilder.HasDefaultSchema(DataBaseConfiguration.Schema);
        }
    }
}
