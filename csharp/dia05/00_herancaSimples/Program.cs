public class ClasseOriginal{
    public int umValor;
    public void imprimeValor(){
         Console.WriteLine("O valor do atribuito da classe original é "+umValor);
    }
    public ClasseOriginal(int qqValor){
        umValor=qqValor;
    }

    public virtual void olaMundo(){
        Console.WriteLine("Olá mundo, eu sou a classe original");
    }
}

public class ClasseDerivada: ClasseOriginal{
    public int valorDerivado;
    public void imprimeDeValorDerivado(){
        Console.WriteLine("O valor do atributo na classe derivada é "+valorDerivado);
    }
    public ClasseDerivada():base(77){

    }

    public ClasseDerivada(int parametro):base(parametro-10){
        valorDerivado=parametro;
    }

    public override void olaMundo(){
        Console.WriteLine("hi people... eu sou uma classe mais moderna que meu pai...");
    }
/*    
    public ClasseDerivada(int qualquerValor){
        valorDerivado=qualquerValor;
    }
*/
}

public class Programa{
    public static void Main(){
        ClasseOriginal co = new ClasseOriginal(87);
        //co.umValor=11;
        co.imprimeValor();


        ClasseDerivada cd = new ClasseDerivada();
        cd.valorDerivado=19;
        cd.imprimeDeValorDerivado();
        //cd.umValor=16;
        cd.imprimeValor();

/*
        ClasseDerivada cd = new ClasseDerivada(37);
        cd.imprimeDeValorDerivado();
        cd.umValor=16;
        cd.imprimeValor();
*/

        cd = new ClasseDerivada(55);
        cd.imprimeValor();
        cd.imprimeDeValorDerivado();

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        co.olaMundo();
        cd.olaMundo();

    }
}