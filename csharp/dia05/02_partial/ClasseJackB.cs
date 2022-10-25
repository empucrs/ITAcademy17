public partial class ClasseJack{
    public int B;
    public void imprimeB(){
        Console.WriteLine("O valor do atributo B é "+ B);
    }
    public void mostraTudo(){
        Console.WriteLine("A="+A+" e B="+B);
    }

    public ClasseJack(int _a, int _b){
        A=_a;
        B=_b;
    }
}