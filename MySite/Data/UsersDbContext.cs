using Microsoft.EntityFrameworkCore;
using MySite.Models;

namespace MySite.Data;

public sealed class UsersDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }

    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyDbSchema;Username=root;Password=asdfzxcv");
    }
}