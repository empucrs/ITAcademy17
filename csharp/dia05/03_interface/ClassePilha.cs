using namespaceInterfacePilha;

namespace namespaceClassePilha
{

    public interface teste{
        void empilhar(object obj);
    }

    public class ClassePilha: InterfacePilha, teste
    {

        private List<Object> minhaLsta;
        private int nElementos;
        
        public ClassePilha(){
            nElementos=0;
            minhaLsta = new List<object>();
        }
        public void empilhar(object obj){
            minhaLsta.Add(obj);
            nElementos++;
        }
/*
        // IMPLEMENTAÇÃO COM A EXPLICITAÇÃO DA INTERFACE NÃO FUNCIONA
        void InterfacePilha.empilhar(object obj){
            minhaLsta.Add(obj);
            nElementos++;
        }
        void teste.empilhar(object obj){
            Console.WriteLine("faria o empilhamento de teste");
        }
*/
/*
        public void empilhar(object o){
            InterfacePilha.empilhar(o);
        }
*/
        public object desempilha(){
            Object aux= topo;
            minhaLsta.RemoveAt(nElementos-1);
            nElementos--;
            return aux;
        }

        public object topo{get{
          return minhaLsta[nElementos-1];
        }}

        public int tamanho(){
            return nElementos;
        }
        
    }
    
}