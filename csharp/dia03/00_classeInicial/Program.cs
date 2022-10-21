using namespaceCliente;



Cliente c = new Cliente();

Console.WriteLine("Cliente criado: " + c.ToString());
Console.WriteLine("Cliente criado: " + c.nome??"Não tem um nome definido");

Console.WriteLine("Constante acessada via classe: " + Cliente.valor);

// OPERACAO INVÁLIDA - RECURSO SOMENTE ACESSÍVEL VIA CLASSE
//Console.WriteLine("Constante acessada via objeto: " + c.valor);


