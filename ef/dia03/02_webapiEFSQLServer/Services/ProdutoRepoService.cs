
using Microsoft.EntityFrameworkCore;
using _02_webapiEFSQLServer.Models;

namespace _02_webapiEFSQLServer.Services;

public class ProdutoRepoService : IProdutoRepo
{
    private readonly LojaContext _dbLoja;

    public ProdutoRepoService(LojaContext _dbParam)
    {
        _dbLoja=_dbParam;
    }

    public IEnumerable<Produto> listaDeProdutos()
    {
        var lista = _dbLoja.produtos;
        return lista;
        
    }

    public async Task<Produto?> produtoEspecifico(int id)
    {
        var prod =  await _dbLoja.produtos.Where( p => p.id== id).FirstOrDefaultAsync();
        return prod;
    }
}
