using namespaceCliente;
using namespaceClienteComConstrutor;



Cliente c = new Cliente();

Console.WriteLine("Cliente criado: " + c.ToString());
Console.WriteLine("Cliente criado: " + c.nome??"Não tem um nome definido");

Console.WriteLine("Constante acessada via classe: " + Cliente.valor);

// OPERACAO INVÁLIDA - RECURSO SOMENTE ACESSÍVEL VIA CLASSE
//Console.WriteLine("Constante acessada via objeto: " + c.valor);

Console.WriteLine("O limite do cliente eh : {0}", c.limiteCredito);
c.aumentarLimite(100);
Console.WriteLine("O novo limite do cliente eh : {0}", c.limiteCredito);


//EXPLORACAO DE METODOS
int x,y,z;
x=1;
y=2;
//z=3;
c.adicionarUm(x,y,out z);
Console.WriteLine("O valor de x na main é "+x);
Console.WriteLine("O valor de y na main é "+y);
Console.WriteLine("O valor de z na main é "+z);

c.adicionarDois(x,y,ref z);
Console.WriteLine("O valor de x na main é "+x);
Console.WriteLine("O valor de y na main é "+y);
Console.WriteLine("O valor de z na main é "+z);

Console.WriteLine("-=-=-=-=-=-=-=-");
int [] listaDeValores = {1,2,3,4};
c.listaParams(listaDeValores);
Console.WriteLine("-=-=-=-=-=-=-=-");
c.listaParams(2,4,6,8,0);
Console.WriteLine("-=-=-=-=-=-=-=-");
c.listaParams(123);

//EXPLORACAO DO CONCEITO DE PROPRIEDADE COM CLIENTEID
Console.WriteLine("O valor de ClienteID é "+c.CID);
c.CID=345;
Console.WriteLine("O novo valor de ClienteID é "+c.CID);

Console.WriteLine("O valor de ClienteID é "+c.outraCoisa);
c.outraCoisa=345;
Console.WriteLine("O novo valor de ClienteID é "+c.outraCoisa);
c.outraCoisa+=100;
Console.WriteLine("O mais novo valor de ClienteID é "+c.outraCoisa);


//EXPLORANDO CONSTRUTOR NA CLASSE CLIENTECOMCONSTRUTOR
//CRIAÇÃO DO OBJETO É INVÁLIDA - É NECESSÁRIO USAR O CONSTRUTOR COM PARAMETROS
//ClienteComConstrutor ccc = new ClienteComConstrutor();

ClienteComConstrutor ccc = new ClienteComConstrutor("Edson", 2260);
Console.WriteLine("Criado o cliente " +ccc.nome+" com o id "+ccc.outraCoisa);

Console.WriteLine("Usando o indexador em C# ->" + ccc[3]);