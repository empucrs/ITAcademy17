using _01_mvcCEP.Models;
namespace _01_mvcCEP.Services;
public interface ICEPServices
{
    public IEnumerable<CEPViewModel> listaCEPs();
    public void cadastraCEPs(CEPViewModel p);
    public CEPViewModel? buscaCEPs(string cep);
    public void eliminaCEP(string cep);
    
}