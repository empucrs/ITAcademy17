using System.Collections;
//using System;

class Program
{

    public static void Main(){

        ArrayList al = new ArrayList();
        al.Add(new string("Edson"));
        al.Add(new string("silvia"));
        al.Add(new string("Francisco"));
        al.Add(new string("Antonio"));

        foreach (string valor in al)
            Console.WriteLine(valor);

        Console.WriteLine("-=Reapresentando a família=-");

        List<String> ls = new List<String>();
        ls.Add("Edson");
        Console.WriteLine("A capacidade da lista de inteiros é {0}", ls.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", ls.Count);
        ls.Add("Silvia");
        Console.WriteLine("A capacidade da lista de inteiros é {0}", ls.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", ls.Count);
        ls.Add("Francisco");
        Console.WriteLine("A capacidade da lista de inteiros é {0}", ls.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", ls.Count);
        ls.Add("Antonio");
        Console.WriteLine("A capacidade da lista de inteiros é {0}", ls.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", ls.Count);
        ls.Add("Mais alguem");
        Console.WriteLine("A capacidade da lista de inteiros é {0}", ls.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", ls.Count);
        foreach (string novoValor in ls)
            Console.WriteLine(novoValor);

        Console.WriteLine("-= Listagem de valores inteiros =-");
        List<Int16> li = new List<Int16>();
        li.Add(10);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(16);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(32);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(23);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(27);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(21);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        li.Add(2);
        Console.WriteLine("A capacidade da lista de inteiros é {0}", li.Capacity);
        Console.WriteLine("A lista de inteiros tem {0} elementos", li.Count);
        foreach (Int16 valorInteiro in li)
            Console.WriteLine(valorInteiro);

        LinkedList<Int32> lli = new LinkedList<Int32>();
        lli.AddFirst(1);
        Console.WriteLine("A lista de inteiros tem {0} elementos", lli.Count);
        lli.AddFirst(2);
        Console.WriteLine("A lista de inteiros tem {0} elementos", lli.Count);
        lli.AddFirst(3);
        Console.WriteLine("A lista de inteiros tem {0} elementos", lli.Count);
        lli.AddFirst(4);
        Console.WriteLine("A lista de inteiros tem {0} elementos", lli.Count);
        lli.AddFirst(5);
        Console.WriteLine("A lista de inteiros tem {0} elementos", lli.Count);
        foreach (Int32 valorLLI in lli)
            Console.WriteLine(valorLLI);

    }
    
}