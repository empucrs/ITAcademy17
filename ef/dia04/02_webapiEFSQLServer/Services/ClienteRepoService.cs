using Microsoft.EntityFrameworkCore;
using _02_webapiEFSQLServer.Models;

namespace _02_webapiEFSQLServer.Services;

public class ClienteRepoService : IClienteRepo
{
    private readonly LojaContext _dbLoja;

    public ClienteRepoService(LojaContext _dbParam)
    {
        _dbLoja=_dbParam;
    }

    public async Task<Cliente?> clienteEspecifico(int id)
    {
        var cliente =  await _dbLoja.clientes.Where(c => c.id == id).FirstOrDefaultAsync();
        return cliente;
    }
}
