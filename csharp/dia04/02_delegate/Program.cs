using NamespaceUmaClasse;
using namespaceOutraClasse;


UmaClasse uc = new UmaClasse();

uc.oDisparadorDeUmEvento(10);

uc.umEventoQualquer += new FazAlgoDelegate(uc.FuncaoUm);
uc.oDisparadorDeUmEvento(11);

uc.umEventoQualquer += new FazAlgoDelegate(UmaClasse.funcaoEstatica);
uc.oDisparadorDeUmEvento(14);

OutraClasse oc = new OutraClasse();
uc.umEventoQualquer += new FazAlgoDelegate(oc.funcaoDeInstancia);
uc.oDisparadorDeUmEvento(15);

uc.umEventoQualquer += new FazAlgoDelegate(OutraClasse.funcaoDeClasse);
uc.oDisparadorDeUmEvento(16);

//EXPLORANDO EXPRESSÕES LAMBDA
Console.WriteLine("O resultado da soma usando UmaClasse.Soma(4,5) é " + UmaClasse.Soma(4,5));
Console.WriteLine("O resultado da soma usando umMetodoDelegate(4,5) é " + uc.umMetodoDelegate(4,5));
Console.WriteLine("O resultado da soma usando umMetodoDelegate(4,5) é " + uc.umOutroMetodoDelegate(4,5));
Console.WriteLine("O resultado da soma usando umMetodoDelegate(4,5) é " + uc.umLambdaQualquer(4,5));
