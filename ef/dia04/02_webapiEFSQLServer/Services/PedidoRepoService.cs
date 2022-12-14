using Microsoft.EntityFrameworkCore;
using _02_webapiEFSQLServer.Models;

namespace _02_webapiEFSQLServer.Services;

public class PedidoRepoService : IPedidoRepo
{
    private readonly LojaContext _dbLoja;

    public PedidoRepoService(LojaContext _dbParam)
    {
        _dbLoja=_dbParam;
    }

    public async Task<Pedido> adicionaPedido(Pedido p)
    {
        await _dbLoja.pedidos.AddAsync(p);
        await _dbLoja.SaveChangesAsync();
        return p;
    }

    public async Task<Pedido?> pedidoEspecifico(int id)
    {
        var pedido =  await _dbLoja.pedidos.Where(p => p.id==id)
                                            .Include(p => p.cliente)
                                            .Include(p => p.itens)                                            
                                            .ThenInclude(i => i.produto)
                                            .FirstOrDefaultAsync();
        return pedido;
    }
}
