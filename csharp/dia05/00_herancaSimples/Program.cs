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
    // OVERIDE INVALIDO POIS O METODO NAO FOI DEFINIDO COMO VIRTUAL NA CLASSE BASE
    public override void imprimeValor(){
        Console.WriteLine("Modifiquei o imprime valor da classe base");
    }
    */
/*    
    public ClasseDerivada(int qualquerValor){
        valorDerivado=qualquerValor;
    }
*/
}

public class Neto: ClasseDerivada{
    public void imprimeAlgo(){
        Console.WriteLine("Eu sou a classe Neto");
    }
    public override void olaMundo()
    {
        //base.olaMundo();
        Console.WriteLine("Um ola mundo pela paz mundial...");
    }
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
        /*
        // METODO IMPRIMEVALOR NÃO PODE SER OVERIDE POIS NÃO FOI DEFINIDO COMO VIRTUAL NA CLASSE ORIGINAL
        co.imprimeValor();
        cd.imprimeValor();
        */
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Neto n = new Neto();
        n.imprimeAlgo();
        n.imprimeValor();
        n.imprimeDeValorDerivado();
        n.olaMundo();

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");        
        Console.WriteLine("Classe original como classe Original");
        Console.WriteLine("  Classe original é classe Original? "+(co is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(co is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(co is Neto));
        co = new ClasseDerivada();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");        
        Console.WriteLine("Classe original como classe Derivada");
        Console.WriteLine("  Classe original é classe Original? "+(co is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(co is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(co is Neto));
        co = new Neto();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");        
        Console.WriteLine("Classe original como Neto");
        Console.WriteLine("  Classe original é classe Original? "+(co is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(co is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(co is Neto));
        
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Classe Derivada como classe Derivada");
        Console.WriteLine("  Classe original é classe Original? "+(cd is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(cd is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(cd is Neto));
        cd = new Neto();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");        
        Console.WriteLine("Classe Derivada como Neto");
        Console.WriteLine("  Classe original é classe Original? "+(cd is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(cd is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(cd is Neto));

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Classe Neto como classe Neto");
        Console.WriteLine("  Classe original é classe Original? "+(n is ClasseOriginal));
        Console.WriteLine("  Classe original é classe Derivada? "+(n is ClasseDerivada));
        Console.WriteLine("  Classe original é classe Neto? "    +(n is Neto));
        
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        (co as ClasseOriginal).olaMundo();
        (co as ClasseDerivada).olaMundo();
        (co as Neto).olaMundo();
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=");
        ClasseOriginal co2 = (co as ClasseOriginal);
        co2.olaMundo();        

    }
}