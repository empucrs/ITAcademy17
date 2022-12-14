using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.DTOs;

public class ProdutoDTO{

    public int id {get; set;}
    public string nome{get; set;}=null!;
    public string? descricao{get;set;}
    public string valorUnitario {get; set;}=null!;

    public static ProdutoDTO converteModel2DTO(Produto prod){
        ProdutoDTO aux = new ProdutoDTO();
        aux.id = prod.id;
        aux.nome=prod.nome;
        aux.descricao=prod.descricao;
        aux.valorUnitario = $"{prod.valorUnitario/100M:C}";
        return aux;
    }

}
