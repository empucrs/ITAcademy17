public class ClasseExemplo{
    public int valorUm, valorDois;
    public readonly int valorUnico;
    public void imprime(){
        Console.WriteLine($"V1={valorUm}; V2={valorDois}");
    }

    public ClasseExemplo(int valor){
        valorUnico=valor;
    }
}