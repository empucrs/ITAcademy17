using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.Services;
public interface IProdutoRepo{

    public IEnumerable<Produto> listaDeProdutos();
    public Task<Produto?> produtoEspecifico(int id);

}