namespace DataDiaMesAno
{
    public class Data{
        private int dia, mes, ano;

        public Data(int _dia, int _mes, int _ano){
            this.dia=_dia;
            this.mes=_mes;
            this.ano=_ano;
            Console.WriteLine("Construtor Data com TRES parametros");
        }

        /*
        // CONSTRUTOR CONFLITA COM A VERSÃO INICIAL DE TRES PARAMETROS
        public Data(int _ANOCLONE, int _DIACLONE, int _MESCLONE){
            this.dia=_DIACLONE;
            this.mes=_MESCLONE;
            this.ano=_ANOCLONE;
            Console.WriteLine("Construtor Data com TRES parametros - COISAS COM CLONE");
        }
        */

        public Data(int _ANOCLONE, int _DIACLONE, int _MESCLONE, string algo){
            this.dia=_DIACLONE;
            this.mes=_MESCLONE;
            this.ano=_ANOCLONE;
            Console.WriteLine("Construtor A Data com QUATRO parametros - COISAS COM CLONE - "+algo);
        }

        public Data(string algo, int _ANOCLONE, int _DIACLONE, int _MESCLONE){
            this.dia=_DIACLONE;
            this.mes=_MESCLONE;
            this.ano=_ANOCLONE;
            Console.WriteLine("Construtor B Data com QUATRO parametros - COISAS COM CLONE - "+algo);
        }

        public Data(int _ANOCLONE, string algo, int _DIACLONE, int _MESCLONE){
            this.dia=_DIACLONE;
            this.mes=_MESCLONE;
            this.ano=_ANOCLONE;
            Console.WriteLine("Construtor C Data com QUATRO parametros - COISAS COM CLONE - "+algo);
        }

        public Data(Data _d){
            this.dia=_d.dia;
            this.mes=_d.mes;
            this.ano=_d.ano;
            Console.WriteLine("Construtor Data com um parametro");
        }
        /*
        //CONSTRUTOR CONFLITANTE COMO CONTRUTOR ACIMA - NÃO PODEM EXISTIR CONJUNTAMENTE
        public Data(Data _d) : this(_d.dia, _d.mes, _d.ano){
            Console.WriteLine("Construtor Data com um parametro - CRIA CONFLITO");
        }
        */

        public int getDia(){
            Console.WriteLine("Entrando do getdia que retorna inteiro");
            return this.dia;
        }

        /*
        // tipo de retorno do metodo não cria assinatura diferente. como consequencia, 
        //   o compilador não entende como sobrecarga, mas sim como redundancia e erro de código
        public string getDia(){
            Console.WriteLine("Entrando do getdia que retorna string");
            return this.dia.ToString();
        }
        */




    }
    
}