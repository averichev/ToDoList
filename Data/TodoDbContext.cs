using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class TodoDbContext : DbContext
{
    internal DbSet<TodoItem> TodoItems { get; set; }
    internal DbSet<User> Users { get; set; }
    private string DbPath { get; }

    public TodoDbContext()
    {
        const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Path.Join(Environment.GetFolderPath(folder), "database.db");
        DbPath = path;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoItem>()
            .HasOne(n => n.User)
            .WithMany()
            .HasForeignKey(n => n.UserId);

        modelBuilder.Entity<User>()
            .HasIndex(n => n.Username)
            .IsUnique();
    }
}