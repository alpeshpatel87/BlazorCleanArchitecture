using Microsoft.EntityFrameworkCore;
using Domain.Entities;


namespace Infrastructure.Contexts
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }
        public DbSet<Projects> Projects { get; set; }
    }
}
