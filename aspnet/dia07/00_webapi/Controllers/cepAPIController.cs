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
}