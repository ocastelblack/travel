using Microsoft.EntityFrameworkCore;
using travel.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Libro> Libros { get; set; }
    public DbSet<Editorial> Editoriales { get; set; }
    public DbSet<Autor> Autores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Libro>()
            .HasKey(l => l.ISBN);

        modelBuilder.Entity<Autor>()
            .HasMany(a => a.Libros)
            .WithMany()
            .UsingEntity(j => j.ToTable("autores_has_libros"));
    }
}