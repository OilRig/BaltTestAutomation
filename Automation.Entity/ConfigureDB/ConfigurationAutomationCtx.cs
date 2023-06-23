using Automation.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Automation.Entity.ConfigureDB
{
    public static class ConfigurationAutomationCtx
    {
        private static ModelBuilder ConfigureActions(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>(ent =>
            {
                ent.ToTable("Actions");
                ent.HasKey(x => x.Id);

                ent.Property(x => x.Result).HasColumnType("bit").IsRequired();
                ent.Property(x => x.Action).HasMaxLength(30).IsRequired();
                ent.Property(x => x.DateTimeStarting).HasColumnType("dateTime2");
                ent.Property(x => x.DateTimeFinishing).HasColumnType("dateTime2");
                ent.Property(x => x.Order).HasColumnType("int").IsRequired();
                ent.Property(x => x.CaseId).HasColumnType("int").IsRequired();

                ent.HasOne(x => x.Case).WithMany(x => x.Actions).HasForeignKey(x=>x.CaseId).OnDelete(DeleteBehavior.Cascade);
            });

            return modelBuilder;
        }
        private static ModelBuilder ConfigureCases(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Case>(ent =>
            {
                ent.ToTable("Cases");
                ent.HasKey(x => x.Id);

                ent.Property(x => x.Name).HasMaxLength(50).IsRequired();
                ent.Property(x => x.CreatedDate).HasColumnType("dateTime2");
                ent.Property(x => x.Contents).HasMaxLength(100).IsRequired();

            });

            return modelBuilder;
        }
        public static ModelBuilder ConfigureDataBase(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ConfigureCases()
                .ConfigureActions();
        }
    }
}
