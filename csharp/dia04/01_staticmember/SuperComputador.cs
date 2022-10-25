class SuperComputador
{
    // MEMBROS DEFINIDOS COMO SENDO DE CLASSE
    // TANTO ATRIBUTOS QUANTO METODOS
    private static int resposta = 42;
    public static int qualAResposta{
        get{ return resposta; }
    }
    public static string obterPergunta(){
        return "Qual o sentido da vida?";
    }

    // MEMBRO DE INSTANCIA
    public int algumValor;
    public string umaMensagem(){
        return "apenas que busquem conhecimento";
    }
    public SuperComputador(int _valor){
        this.algumValor=_valor;
    }
    
}