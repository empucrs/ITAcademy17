using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.DTOs;

public class PedidoDTO{

    public int id {get; set;}
    public string nomeCliente{get; set;}=null!;
    public string dataDoPedido{get;set;}=null!;
    public decimal totalDoPedido{get;set;}
    //public IEnumerable<ItemDTO> itensDoPedido{get;set;}=null!;
    public IEnumerable<ItemDTO> itensDoPedido{get;set;}=null!;
    

    public static PedidoDTO converteModel2DTO(Pedido pedido){
        PedidoDTO aux = new PedidoDTO();
        aux.id=pedido.id;
        aux.dataDoPedido=pedido.dataDaAquisicao.ToShortDateString();
        aux.nomeCliente=pedido.cliente.nome;
        aux.totalDoPedido = pedido.itens.Sum( i => i.quantidade * i.produto.valorUnitario)/100M;
        aux.itensDoPedido = pedido.itens.Select(i => ItemDTO.converteModel2DTO(i));
        return aux;
    }

}
