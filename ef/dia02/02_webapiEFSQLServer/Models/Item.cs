namespace _02_webapiEFSQLServer.Models;

class Item
{
    public int quantidade {get;set;}
    public Produto produto {get; set;}=null!;
    public Pedido pedido {get; set;}=null!;    
}