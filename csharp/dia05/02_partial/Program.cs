
ClasseJack cj = new ClasseJack();
cj.A=10;
cj.B=12;
cj.imprimeA();
cj.imprimeB();

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-");
cj = new ClasseJack();
cj.mostraTudo();

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-");
cj = new ClasseJack(77, 53);
cj.mostraTudo();

Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-");
ClasseExemplo ce = new ClasseExemplo(100);
ce.imprime();

ce = new ClasseExemplo(100){valorUm=32, valorDois=53};
ce.imprime();


Console.WriteLine("-=-=-=-=-=-=-=-=-==-=-");
//ce.valorUnico=10;
Console.WriteLine("O valor unico é "+ce.valorUnico);
//ce.valorUnico=23;
//Console.WriteLine("O valor unico é "+ce.valorUnico);
