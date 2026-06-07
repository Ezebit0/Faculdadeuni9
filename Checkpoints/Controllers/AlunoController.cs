using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Eduardo Mendes";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View();
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}