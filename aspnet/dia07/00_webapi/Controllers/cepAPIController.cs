using Microsoft.AspNetCore.Mvc;
using priojAPI.Services;
using priojAPI.Models;

namespace priojAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class cepAPIController : ControllerBase
{
     private readonly ILogger<WebAPIServiceController> _logger;
     private readonly ICEPServices _cepService;

    public cepAPIController(ILogger<WebAPIServiceController> logger, ICEPServices paramCEPServiceImplementation)
    {
        _logger = logger;
        _cepService=paramCEPServiceImplementation;
    }

    [HttpGet]
    public IEnumerable<CEPModel> GetAll()
    {
        _logger.LogInformation("GET no cepAPI sem parametros");

        return _cepService.listaCEPs().OrderBy(p => p.Bairro).ToArray();
        
    }

    [HttpGet("{codigo}")]
    [ProducesResponseType(200)]
    [ProducesResponseType(404)]
    public ActionResult<CEPModel> GetCEPEspecifico(String codigo){

        CEPModel? aux = _cepService.buscaCEPs(codigo);

        if(aux == null)
            return NotFound();

        return aux;

    }

    [HttpPost]
    public ActionResult<CEPModel> addCEP([FromBody] CEPModel cep){
        _cepService.adicionaCEP(cep);
        return cep;
    }
}