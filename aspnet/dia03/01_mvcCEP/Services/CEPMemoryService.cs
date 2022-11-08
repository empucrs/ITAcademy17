using _01_mvcCEP.Models;
using System.Collections.Concurrent;
namespace _01_mvcCEP.Services;
public class CEPMemoryService: ICEPServices
{    
   private readonly ConcurrentDictionary<string, CEPViewModel> listaDeCEPs = new ConcurrentDictionary<string, CEPViewModel>();
 
    IEnumerable<CEPViewModel> ICEPServices.listaCEPs()
    {
        return listaDeCEPs.Values;
    }

    void ICEPServices.cadastraCEPs(CEPViewModel p)
    {
        listaDeCEPs.TryAdd(p.CEP, p);
    }

    CEPViewModel? ICEPServices.buscaCEPs(string cep)
    {
        CEPViewModel? searchResult;
        listaDeCEPs.TryGetValue(cep, out searchResult);
        return searchResult;
    }

    public CEPMemoryService(){
        CEPViewModel aux = new CEPViewModel{
                CEP="90619900",
                Bairro="Partenon",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="Av. Ipiranga 6681"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
        aux = new CEPViewModel{
                CEP="90840450",
                Bairro="Santa Tereza",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="R. Alvaro Caetano, 106"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
        aux = new CEPViewModel{
                CEP="90850130",
                Bairro="Menino Deus",
                Cidade="Porto Alegre",
                UF="RS",
                Logradouro="R. Dona Augusta 333"
            };
        listaDeCEPs.TryAdd(aux.CEP, aux );
    }
}