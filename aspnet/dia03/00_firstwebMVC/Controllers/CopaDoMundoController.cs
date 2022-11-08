using System;
using Microsoft.AspNetCore.Mvc;
namespace _00_firstwebMVC.Controllers;
public class CopaDoMundoController : Controller{

    public void Acao01()
    {
        Console.WriteLine("vai saber");
        
    }

    public string Acao02(){
        return "A copa do mundo é nossa";
    }

    public IActionResult Acao03(){
        Console.WriteLine("Entrou na Acao03");
        return View();
    }

    public IActionResult Acao04(){
        Console.WriteLine("Entrou na Acao04");
        return View("Acao03");
    }

    public string Acao05(string id){
        return System.Web.HttpUtility.HtmlEncode($"Olá {id}. Seja bem vindo ao nosso lindo site!!");
    }

    public string Acao06(string nome, int idade){
        return "Olá "+nome+". Me disseram q vc tem "+idade+" anos.";
    }

    public IActionResult Acao07(int id){
        switch (id){
            case 1: return NotFound(); 
            case 2: return Ok();
            case 3: return Accepted();            
            default: return View("Acao03");
        }
    }

    public IActionResult Acao08(){
        ViewBag.AlgumaCoisa="CTRLR: Um texto bonito";
        ViewData["OutraCoisa"]="Outro texto que gostaria que estivesse presente";
        Console.WriteLine(ViewBag.AlgumaCoisa);
        ViewResult viewDaAcao = View();
        Console.WriteLine(ViewBag.AlgumaCoisa);
        return viewDaAcao;
    }
    public string Acao09(string id){
        if(ModelState.IsValid)
            return $"Olá {id}. Seja bem vindo ao nosso lindo site!!";
        else
            return "Deu algo de errado";
    }


}
