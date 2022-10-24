namespace NamespaceUmaClasse
{
    public delegate void FazAlgoDelegate(int x);

    public class UmaClasse
    {

        public event FazAlgoDelegate umEventoQualquer;

        public void oDisparadorDeUmEvento(int z){

            if(umEventoQualquer!=null) umEventoQualquer(z);
            else
                Console.WriteLine("Não foi associado nenhuma função ao evento");
        }        

        public void FuncaoUm(int a){
            Console.WriteLine("O valor passado por referencia é "+a);
        }

        public static void funcaoEstatica(int valor){
            Console.WriteLine("Seja lá o q for o método vem de um método de classe... o valor passado por parametro foi "+valor);
        }

        // CODIGOS DE EXPLORAÇÃO SOBRE LAMBDA
        public static int Soma(int a, int b){
            return a+b;
        }
        public Func<int, int, int> umMetodoDelegate = Soma;

        public Func<int, int, int> umOutroMetodoDelegate = delegate(int x, int y){
            return x+y;
        };

        public Func<int, int, int> umLambdaQualquer = (m, y) => m+y;
    
    }
}