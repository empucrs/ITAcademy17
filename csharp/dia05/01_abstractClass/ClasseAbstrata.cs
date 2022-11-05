public abstract class ClasseAbstrata{

    public abstract decimal CalculaSalario();
    public abstract string codigo{get; set;}

    public void mensagem(){
        Console.WriteLine("Este metodo não faz sentido ser mudado");
    }

}

public class ClasseDerivada: ClasseAbstrata{
    private decimal salario;
    public ClasseDerivada(decimal valor){
        salario=valor;
    }
    public override decimal CalculaSalario(){
        return salario*1.1m;
    }
    public override string codigo{get; set;}
}