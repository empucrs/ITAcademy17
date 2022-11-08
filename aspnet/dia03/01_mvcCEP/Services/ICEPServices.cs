using _01_mvcCEP.Models;
namespace _01_mvcCEP.Services;
public interface ICEPServices
{
    IEnumerable<CEPViewModel> listaCEPs();
    void cadastraCEPs(CEPViewModel p);
    CEPViewModel? buscaCEPs(string cep);
    
}