namespace _02_webapiEFSQLServer.Models;

class Pedido
{
    public int id {get; set;}

    public Cliente cliente {get; set;}=null!;  

    public List<Item> itens {get; set;}=null!;
    
}
