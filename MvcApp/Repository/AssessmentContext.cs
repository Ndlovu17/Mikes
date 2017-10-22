using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcApp.Models;
using MvcApp.Repository;

namespace MvcApp.Repository
{
    public class AssessmentContext : DbContext
    {
        public AssessmentContext()
            : base("AssConn")
        {
            Database.SetInitializer(new AssessmentDBInitializer());
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(primK => primK.Id);
            modelBuilder.Entity<Client>().Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<Client>().Property(c => c.Surname).IsRequired().HasMaxLength(15);
            modelBuilder.Entity<Client>().Property(c => c.FirstName).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Client>().Property(c => c.IdNumber).IsRequired().HasMaxLength(13);
            modelBuilder.Entity<Client>().Property(c => c.IDType).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<Client>().Property(c => c.DateOfBirth).IsRequired().HasColumnType("smalldatetime");

        }


    }

}