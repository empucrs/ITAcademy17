namespace _02_webapiEFSQLServer.Models;

class Produto
{
    public int id {get; set;}
    public string nome{get; set;}=null!;
    public string? descricao{get;set;}
    public int preco {get; set;}
    public List<Item> itens {get; set;}=null!;
    
}
