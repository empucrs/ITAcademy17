
namespace namespaceCliente
{    
    class Cliente{

        // CAMPOS DA CLASSE
        public string nome;
        public decimal limiteCredito;
        private uint clienteID;
        public uint CID{get;set;}
        public uint outraCoisa{
            get { return clienteID;}
            set {clienteID = value%10;}
        }

        //CONSTANTE DA CLASSE
        public const int valor = 1024;


        //METODO DE INSTANCIA
        public void aumentarLimite(decimal quantia){
            limiteCredito+=quantia;
        }

        //METODO DE INSTANCIA COM USO DE OUT
        public void adicionarUm(int x, int y, out int z){
            Console.WriteLine($"O valor de x é {x}");
            x++;
            Console.WriteLine($"O valor de y é {y}");
            y++;            
            //PARAMETRO Z NÃO PODE SER USADO POIS É CONSIDERADO COMO POTENCIALMENTE NÃO INICIALIZADO
            //Console.WriteLine($"O valor de z é {z}");
            z=100;
        }

        public void adicionarDois(int x, int y, ref int z){
            Console.WriteLine($"O valor de x é {x}");
            x++;
            Console.WriteLine($"O valor de y é {y}");
            y++;            
            Console.WriteLine($"O valor de z é {z}");
            z++;
        }

        public void listaParams(params int[] args){
            Console.WriteLine("Foram recebidos {0} argumentos por parametro. São eles",args.Length);
            foreach (var item in args)
                Console.WriteLine("  -> "+item);
        }

        public void teste(out int xaxa){
            //Console.WriteLine("Eu até escreveria em xuxu... mas não quero.." + xaxa);
            xaxa = 102;
        }




    }
}