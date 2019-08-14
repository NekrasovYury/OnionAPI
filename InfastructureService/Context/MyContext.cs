using Infastructure.Models;
using InfastructureService.Configuration;
using Microsoft.EntityFrameworkCore;
using Users.InfrastructureServices.Configurations;

namespace Users.InfrastructureServices.Contexts
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public virtual DbSet<InfastructureUsers> Users { get; set; }

        public virtual DbSet<ReqestLogEntry> ReqestLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new UserConfiguration())
                .ApplyConfiguration(new RequestLogEntryConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
