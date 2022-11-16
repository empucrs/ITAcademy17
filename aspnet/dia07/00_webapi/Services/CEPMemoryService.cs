using priojAPI.Models;
using System.Collections.Concurrent;
namespace priojAPI.Services;
public class CEPMemoryService: ICEPServices
{    
   private readonly ConcurrentDictionary<string, CEPModel> listaDeCEPs = new ConcurrentDictionary<string, CEPModel>();
 
    IEnumerable<CEPModel> ICEPServices.listaCEPs()
    {
        return listaDeCEPs.Values;
    }

    CEPModel? ICEPServices.buscaCEPs(string cep)
    {
        CEPModel? searchResult;
        listaDeCEPs.TryGetValue(cep, out searchResult);
        return searchResult;
    }

    public void adicionaCEP(CEPModel cep)
    {
        listaDeCEPs.TryAdd(cep.CEP, cep);
    }

    public CEPMemoryService(){
        CEPModel aux = new CEPModel{
                CEP="90619900",
                Bairro="Partenon",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="Av. Ipiranga 6681"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
        aux = new CEPModel{
                CEP="90840450",
                Bairro="Santa Tereza",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="R. Alvaro Caetano, 106"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
        aux = new CEPModel{
                CEP="90850130",
                Bairro="Menino Deus",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="R. Dona Augusta 333"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
    }
}