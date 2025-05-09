﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsEfCoreApp
{
    public class AppDbContext : DbContext
    {
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
       => options.UseSqlite("Data Source=calendarApp.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.CalendarEvents)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
