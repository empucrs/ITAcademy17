using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.DTOs;

public class ItemDTO{

    public int idProduto {get; set;}
    public String nomeDoProduto {get; set;}=null!;
    public int quantidade{get; set;}
    public decimal valorUnitario{get; set;}
    public decimal subtotalProduto {get; set;}

    public static ItemDTO converteModel2DTO(Item item){
        ItemDTO aux = new ItemDTO();
        aux.idProduto=item.produto.id;
        aux.nomeDoProduto=item.produto.nome;
        aux.quantidade=item.quantidade;
        aux.valorUnitario=item.produto.valorUnitario/100M;
        aux.subtotalProduto=(item.quantidade * item.produto.valorUnitario)/100M;
        return aux;
    }

}
