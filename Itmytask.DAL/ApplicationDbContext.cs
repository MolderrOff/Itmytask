using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itmytask.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Itmytask.DAL          
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)       
        {
            Database.EnsureCreated(); 
        }
        public DbSet<Work> Work { get; set; }  
        public ApplicationDbContext() { }
        public ApplicationDbContext(string connection)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseMySql(
                "Host = localhost; Port=3306; Database = TaskPriceFull;  Username = root; Password = ghgkyUYTUY456;"
                ,
            new MySqlServerVersion(new Version(8, 0, 40)))
            .UseLazyLoadingProxies()
            .LogTo(Console.WriteLine)
            ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Work>(entity =>
            {
                entity.HasKey(w => w.Id)
                    .HasName("work_pk");

                entity.ToTable("workfull");

                entity.Property(pr => pr.NameTask)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(pr => pr.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal(18, 2)"); ;
            }
            );
        }
    }
}
