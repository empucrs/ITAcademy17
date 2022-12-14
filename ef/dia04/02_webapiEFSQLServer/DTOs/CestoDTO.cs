using System.ComponentModel.DataAnnotations;
using _02_webapiEFSQLServer.Models;
namespace _02_webapiEFSQLServer.DTOs;

public class cestoDTO{

    [Required(ErrorMessage = "IdCliente é um campo obrigatório")]
    public int idCliente {get; set;}
    [Required(ErrorMessage = "Os itens do pedido devem ser informados")]
    public IEnumerable<ItemCestoDTO> itens {get; set;}=null!;

}

public class ItemCestoDTO{
    [Required(ErrorMessage = "IdProduto é um campo obrigatório")]
    public int idProduto {get; set;}
    [Required(ErrorMessage = "O campo quantidade é obrigatório")]
    [Range(1,10,ErrorMessage = "a qtde min é 1 e max é 10")]
    public int quantidade {get; set;}
}
