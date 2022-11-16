using Microsoft.EntityFrameworkCore;

namespace consoleEF.Models;

public class CEPDBContext: DbContext
{

    public DbSet<CEPModel> ceps {get; set;} = null!;

    public string dbpath {get; set;}

    public CEPDBContext(){
        var diretorioEspecial = Environment.SpecialFolder.LocalApplicationData;
        var caminhoEspecial = Environment.GetFolderPath(diretorioEspecial);
        dbpath = Path.Join(caminhoEspecial, "baseCEP.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={dbpath}");
    }

}