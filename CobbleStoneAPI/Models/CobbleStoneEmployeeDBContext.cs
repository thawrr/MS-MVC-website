using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CobbleStoneAPI.Models
{
    public partial class CobbleStoneEmployeeDBContext : DbContext
    {
        public CobbleStoneEmployeeDBContext()
        {
        }

        public CobbleStoneEmployeeDBContext(DbContextOptions<CobbleStoneEmployeeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasKey(e => e.id);

                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Age);
            });
        }

    }//end class
}//end nameSpace
