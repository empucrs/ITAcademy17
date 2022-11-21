using Microsoft.AspNetCore.Mvc;
using _02_webapiEFSQLServer.Models;
using _02_webapiEFSQLServer.Services;
using _02_webapiEFSQLServer.DTOs;


namespace _02_webapiEFSQLServer.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{

    private readonly ILogger<PedidoController> _logger;
    private readonly IPedidoRepo _pedidoRepo;
    private readonly IClienteRepo _clienteRepo;
    private readonly IProdutoRepo _produtoRepo;

    public PedidoController(ILogger<PedidoController> logger, IPedidoRepo _paramPedido, IClienteRepo _paramCliente, IProdutoRepo _paramProduto)
    {
        _logger = logger;
        _pedidoRepo=_paramPedido;
        _clienteRepo=_paramCliente;
        _produtoRepo=_paramProduto;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PedidoDTO?>> retornaPedidoEspecifico(int id){
        var consulta = await _pedidoRepo.pedidoEspecifico(id);
        if(consulta == null)
            return NotFound();
        var auxDTO = PedidoDTO.converteModel2DTO(consulta);
        return auxDTO;
    }

    [HttpPost]
    public async Task<ActionResult<PedidoDTO>> lancaPedido(cestoDTO umCesto){
        var pedido = new Pedido();
        pedido.dataDaAquisicao = DateTime.Now;

        var cliente = await _clienteRepo.clienteEspecifico(umCesto.idCliente);
        if(cliente==null)
            return BadRequest();
        pedido.cliente=cliente;
        pedido.itens = new List<Item>();
        foreach (var item in umCesto.itens)        
        {
            var produto = await _produtoRepo.produtoEspecifico(item.idProduto);
            if(produto==null)
                return BadRequest();
            var novoItem = new Item();
            novoItem.quantidade=item.quantidade;
            novoItem.produto=produto;
            //novoItem.pedido=pedido;
            pedido.itens.Add(novoItem);            
        }

        var pedidoAdicionado = await _pedidoRepo.adicionaPedido(pedido);

        return PedidoDTO.converteModel2DTO(pedidoAdicionado);

    }


}