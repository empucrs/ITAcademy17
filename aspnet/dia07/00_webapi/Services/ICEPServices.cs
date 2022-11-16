using priojAPI.Models;
namespace priojAPI.Services;
public interface ICEPServices
{
    public IEnumerable<CEPModel> listaCEPs();
    public CEPModel? buscaCEPs(string cep);
    public void adicionaCEP(CEPModel cep);
    
}