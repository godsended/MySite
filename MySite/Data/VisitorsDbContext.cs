using Microsoft.EntityFrameworkCore;
using MySite.Models;

namespace MySite.Data;

public sealed class VisitorsDbContext : DbContext
{
    public DbSet<Visitor>? Visitors { get; set; }

    public VisitorsDbContext(DbContextOptions<VisitorsDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyDbSchema;Username=root;Password=asdfzxcv");
    }
}