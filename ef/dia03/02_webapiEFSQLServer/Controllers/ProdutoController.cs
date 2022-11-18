using Microsoft.AspNetCore.Mvc;
using _02_webapiEFSQLServer.Models;
using _02_webapiEFSQLServer.DTOs;
using _02_webapiEFSQLServer.Services;

namespace _02_webapiEFSQLServer.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly ILogger<ProdutoController> _logger;
    private readonly IProdutoRepo _prod;

    public ProdutoController(ILogger<ProdutoController> logger, IProdutoRepo _paramProd)
    {
        _logger = logger;
        _prod=_paramProd;
    }

    [HttpGet]
    public IEnumerable<ProdutoDTO> GetProdutos()
    {
        var lista =  _prod.listaDeProdutos();
        var resultado = lista.Select(prod => ProdutoDTO.converteModel2DTO(prod));
        return resultado;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProdutoDTO?>> GetProdutoEspecifico(int id){

        var prod = await _prod.produtoEspecifico(id);
        if(prod==null)
            return NotFound();
        
        return ProdutoDTO.converteModel2DTO(prod);

    }
}
