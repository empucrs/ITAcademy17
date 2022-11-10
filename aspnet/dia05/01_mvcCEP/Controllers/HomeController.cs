using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _01_mvcCEP.Models;
using _01_mvcCEP.Services;

namespace _01_mvcCEP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICEPServices _localCEPServices;

    public HomeController(ILogger<HomeController> logger, ICEPServices paramCEPService)
    {
        _logger = logger;
        _localCEPServices=paramCEPService;
    }

    public IActionResult Index()
    {
        var ceps = _localCEPServices.listaCEPs();
        return View(ceps);
    }

    public IActionResult Eliminar(string id){
        if(ModelState.IsValid)
            _localCEPServices.eliminaCEP(id);

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(CEPViewModel novoCEP)
    {
        if(ModelState.IsValid){
            _localCEPServices.cadastraCEPs(novoCEP);
            return RedirectToAction("Index");
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Search(string id){
        CEPViewModel? cepBuscado=null;
        if(!string.IsNullOrEmpty(id))
            cepBuscado = _localCEPServices.buscaCEPs(id);
        return View(cepBuscado);
    }

}
