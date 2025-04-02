using Microsoft.EntityFrameworkCore;
using CalendarApi.Models;

namespace CalendarApi.Data
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) { }

        public DbSet<Event> Events { get; set; }
    }
}