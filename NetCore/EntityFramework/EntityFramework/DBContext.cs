using System;
using System.Collections.Generic;
using System.Text;
using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    class DBContext : DbContext
    {
        public static string connectString =
            @"Server =SHALL955\SQLEXPRESS2014;Database=TestDB;Trusted_Connection=True";

        public DBContext()
        {
            //Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectString, options => options.EnableRetryOnFailure());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GroupWithUser>().HasKey(sr => new {sr.GroupId, sr.UserId});
            //modelBuilder.Entity<GroupWithUser>().HasOne(p=>p.UserId).WithMany(p=>p.)
        }
    }
}
