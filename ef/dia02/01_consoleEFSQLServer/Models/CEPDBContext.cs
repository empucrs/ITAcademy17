using Microsoft.EntityFrameworkCore;

namespace consoleEFSQLServer.Models;

public class CEPDBContext: DbContext
{

    public DbSet<CEPModel> ceps {get; set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=baseCEP;Trusted_Connection=True;TrustServerCertificate=True;");
    }

}