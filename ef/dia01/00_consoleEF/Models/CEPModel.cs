using System.ComponentModel.DataAnnotations;

namespace consoleEF.Models;
public class CEPModel
{    
    public int id{get; set;}
    public string CEP{get; set;}=null!;
    public string UF{get; set;}=null!;
    public string Cidade{get; set;}=null!;
    public string Bairro{get; set;}=null!;
    public string Logradouro{get; set;}=null!;
    
}