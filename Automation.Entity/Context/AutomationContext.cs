using Automation.Entity.ConfigureDB;
using Automation.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Automation.Entity.Context
{
    public class AutomationContext : DbContext
    {
        public  DbSet<Actions> Actions { get; set; }
        public DbSet<Case> Cases { get; set; }


        public AutomationContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureDataBase();

        }
    }
}
