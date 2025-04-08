using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Events.db");
    }
}
