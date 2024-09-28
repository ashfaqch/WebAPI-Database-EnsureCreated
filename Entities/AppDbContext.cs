using Microsoft.EntityFrameworkCore;

namespace WebAPI.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TodoItem> TodoItems { get; set; }
}