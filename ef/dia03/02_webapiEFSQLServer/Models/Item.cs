namespace _02_webapiEFSQLServer.Models;

public class Item
{
    public int quantidade {get;set;}
    public Produto produto {get; set;}=null!;
    public Pedido pedido {get; set;}=null!;    
}