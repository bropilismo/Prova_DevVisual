
using Microsoft.EntityFrameworkCore;

namespace Bruno1.Models;
public class AppDbContext : DbContext
{
    public DbSet<Folha> Folhas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=BrunoS_BrunoA.db");
    }
}