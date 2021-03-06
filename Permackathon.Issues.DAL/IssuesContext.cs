﻿using Microsoft.EntityFrameworkCore;
using Permackathon.Issues.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.DAL
{
    public class IssuesContext : DbContext
    {
        public IssuesContext() { }
        public IssuesContext(DbContextOptions<IssuesContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder is null)
                throw new ArgumentNullException(nameof(optionsBuilder));

            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder./*UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FacilityDB;Trusted_Connection=True;")*/;
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<IssueEF> Issues { get; set; }
        public DbSet<LocationEF> Locations { get; set; }
        public DbSet<SectorEF> Sectors { get; set; }
        public DbSet<UserEF> Users { get; set; }
    }
}
