namespace _02_webapiEFSQLServer.Models;

public class Cliente
{
    public int id {get; set;}
    public string nome {get; set;}=null!;
    public string email {get;set;}=null!;
    public string? telefone{get;set;}

    public List<Pedido> pedidos {get; set;}=null!;
    
}
