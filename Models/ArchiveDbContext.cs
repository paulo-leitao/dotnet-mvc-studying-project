using System;
using Microsoft.EntityFrameworkCore; 

namespace mvc_web_app.Models
{
    public class ArchiveDbContext : DbContext
    {
        public ArchiveDbContext(DbContextOptions<ArchiveDbContext> options)
        : base(options)
        { }
        public DbSet<Archive> Archive { get; set; }
    }
}
