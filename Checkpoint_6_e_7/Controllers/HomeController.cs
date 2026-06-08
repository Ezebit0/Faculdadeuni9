using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Checkpoint_6_e_7.Models;

namespace Checkpoint_6_e_7.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Boletim()
    {
        List<string> disciplinas = new()
        {
            "Front-End",
            "Desenvolvimento para internet",
            "IOT",
            "Arquitetura de computadores",
            "Cidadania e ética"
        };

        List<double> notas = new()
        {
            9.5,
            8.0,
            6.5,
            4.0,
            10.0
        };

        ViewBag.Disciplinas = disciplinas;
        ViewBag.Notas = notas;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}