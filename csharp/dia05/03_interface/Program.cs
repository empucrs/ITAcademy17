using namespaceClassePilha;

ClassePilha cp = new ClassePilha();
cp.empilhar("xuxu1");
cp.empilhar("xuxu2");
cp.empilhar("xuxu3");
cp.empilhar("xuxu4");
cp.empilhar("xuxu5");

Console.WriteLine("A pilha tem {0} elementos", cp.tamanho());
Console.WriteLine("O último elemento da pilha é {0}", cp.topo);
cp.desempilha();
Console.WriteLine("A pilha tem {0} elementos", cp.tamanho());
Console.WriteLine("O último elemento da pilha é {0}", cp.topo);
cp.desempilha();
Console.WriteLine("A pilha tem {0} elementos", cp.tamanho());
Console.WriteLine("O último elemento da pilha é {0}", cp.topo);
cp.desempilha();
Console.WriteLine("A pilha tem {0} elementos", cp.tamanho());
Console.WriteLine("O último elemento da pilha é {0}", cp.topo);
cp.desempilha();
Console.WriteLine("A pilha tem {0} elementos", cp.tamanho());
Console.WriteLine("O último elemento da pilha é {0}", cp.topo);

namespaceInterfacePilha.InterfacePilha xuxu = new ClassePilha();
xuxu.empilhar("xaxa1");
xuxu.empilhar("xaxa2");
xuxu.empilhar("xaxa3");
xuxu.empilhar("xaxa4");
Console.WriteLine("Inteface --> " + xuxu.topo);