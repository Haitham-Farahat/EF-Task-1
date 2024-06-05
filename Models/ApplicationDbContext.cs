using EF_Task_1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task_entity.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Taask> Taasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-VNBM3RAB;Initial " +
                "Catalog=FirstDB504;Integrated " +
                "Security=True;TrustServerCertificate=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taask>()
                .Property(e => e.TaaskDescription)
                .IsRequired(false); ///

            modelBuilder.Entity<Taask>()
                .ToTable("NewTask");

            modelBuilder.Entity<Taask>()
                .Property(b => b.TaaskDate)
                .HasColumnName("Deadline");
        }

    }
}
