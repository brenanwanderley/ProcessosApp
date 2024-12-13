using Microsoft.EntityFrameworkCore;
using ProcessosApp.Models;

namespace ProcessosApp.Contexts;

public class ProcessosContext : DbContext
{
    public DbSet<Processo> Processos => Set<Processo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=processos.sqlite3");
    }
}
