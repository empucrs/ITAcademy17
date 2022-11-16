using Microsoft.AspNetCore.Mvc;

namespace priojAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WebAPIServiceController : ControllerBase
{
     private readonly ILogger<WebAPIServiceController> _logger;

    public WebAPIServiceController(ILogger<WebAPIServiceController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        _logger.LogInformation("GET sem parametros");
        return "teste";
    }

    [HttpGet("{nome}")]
    public string Get(string nome)
    {
        _logger.LogInformation("GET com nome");
        return $"Retornando o valor {nome}";
    }


    [HttpGet("{parametro}/acao")]
    public string OutroGet(string parametro){
        _logger.LogInformation("GET com url customizada");
        return $"Retornando do valor {parametro} a partir de url customizada";
    }

}
