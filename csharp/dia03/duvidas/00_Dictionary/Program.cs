using System.Collections.Generic;

public class Program{
    public static void Main(){
        Dictionary<int, string> paises = new Dictionary<int, string>(); 
        paises[44] = "Reino Unido"; 
        paises[33] = "França"; 
        paises[55] = "Brasil"; 
        Console.WriteLine("Country: "); 
        string country = Console.ReadLine();

        foreach (var item in paises) { //como fazer isso com metodos do dictionary?
            int codigo = item.Key; 
            string pais = item.Value; 
            if(country == pais){
                Console.WriteLine($"O DDI deste pais é: {codigo}"); 
            }
        }

    }
}