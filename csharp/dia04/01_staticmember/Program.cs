// ACESSANDO RECURSOS DE CLASSE A PARTIR DA CLASSE
Console.WriteLine(SuperComputador.obterPergunta());
Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
Console.WriteLine(SuperComputador.qualAResposta);

// ACESSANDO RECURSOS DE INSTANCIA A PARTIR DE UM OBJETO
SuperComputador sc = new SuperComputador(37);
Console.WriteLine("O valor do atributo de instancia é "+sc.algumValor);
Console.WriteLine("O valor do atributo de instancia é "+sc.umaMensagem());

/*
// ACESSO NÃO FOI VALIDADO
// ACESSANDO RECURSOS DE CLASSE A PARTIR DO OBJETO
Console.WriteLine("Atributo de classe via objeto "+sc.qualAResposta);
Console.WriteLine("metodo de classe via objeto "+sc.obterPergunta());
*/


/*
// ACESSO NÃO FOI VALIDADO
// ACESSANDO RECURSOS DE CLASSE A PARTIR DO OBJETO
Console.WriteLine("Atributo de instancia via classe "+SuperComputador.algumValor);
Console.WriteLine("metodo de instancia via classe "+SuperComputador.umaMensagem());
*/