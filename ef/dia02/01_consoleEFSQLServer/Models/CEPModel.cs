namespace consoleEFSQLServer.Models;
public class CEPModel
{    
    public int id{get; set;}
    public string CEP{get; set;}=null!;
    public string UF{get; set;}=null!;
    public string Cidade{get; set;}=null!;
    public string Bairro{get; set;}=null!;
    public string Logradouro{get; set;}=null!;


    public override string ToString()
    {
        return $"  CEP => id:{this.id}, cep:{this.CEP}, UF:{this.UF}, cidade:{this.Cidade}, Bairro:{this.Bairro}, Logradouro:{this.Logradouro}";
    }


}