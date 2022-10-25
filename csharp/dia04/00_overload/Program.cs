using DataDiaMesAno;

Data d1 = new Data(8, 10, 1976);

Data d2 = new Data(d1);

Data d3 = new Data(1976, 8, 10, "Edson");

Data d4 = new Data("Silvia", 1976, 8, 10);

int intValor = d4.getDia();
Console.WriteLine("O dia vindo de um metodo q retorna int é "+intValor);

string strValor=d4.getDia();
Console.WriteLine("O dia vindo de um metodo q retorna int é "+strValor);



