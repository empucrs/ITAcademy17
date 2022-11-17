using consoleEFSQLServer.Models;

Console.WriteLine("Inicio do meu programa");
using var db = new CEPDBContext();

var umCEP = new CEPModel(){
        CEP="90840450",
        UF="RS",
        Cidade="Porto Alegre",
        Bairro="Santa Tereza",
        Logradouro="Rua um, 234"
    };
db.Add(umCEP);

umCEP = new CEPModel(){
        CEP="90810240",
        UF="RS",
        Cidade="Porto Alegre",
        Bairro="Praia de Belas",
        Logradouro="Av. Padre Cacique 891"
    };
db.Add(umCEP);

umCEP = new CEPModel(){
        CEP="91030310",
        UF="RS",
        Cidade="Porto Alegre",
        Bairro="Santa Maria Goretti",
        Logradouro="Rua Padre Hildebrando, 1100"
    };
db.Add(umCEP);

db.SaveChanges();

Console.WriteLine("Consumindo todos os dado da base de dados");
var listaDeCEPs = db.ceps;
foreach (var cep in listaDeCEPs)
    Console.WriteLine(cep);

/*
Console.WriteLine("Consumindo dado da base de dados baseado em condição");
var selectDaListaDeCEPs = db.ceps.Where( p => p.Bairro.ToUpper().Contains("SANTA") );
foreach (var cep in selectDaListaDeCEPs)
    Console.WriteLine(cep);


Console.WriteLine("Consumindo um dado específico da base de dados baseado");
var umCEPEspecifico = db.ceps.Find(3);
Console.WriteLine(umCEPEspecifico);
umCEPEspecifico!.Logradouro = "Rua das palmeiras, nro 1234";
db.SaveChanges();

db.SaveChangesAsync();


Console.WriteLine("Elininando o primeiro elemento da base de dados");
db.Remove(listaDeCEPs.First());
db.SaveChanges();

Console.WriteLine("Consumindo todos os dado da base de dados");
listaDeCEPs = db.ceps;
foreach (var cep in listaDeCEPs)
    Console.WriteLine(cep);
*/

Console.WriteLine("FIM do meu programa");
