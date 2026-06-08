using Microsoft.AspNetCore.Mvc;

namespace SeuProjeto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            List<string> produtos = new List<string>
            {
                "Mouse",
                "Teclado",
                "Monitor",
                "Webcam",
                "Fio"
            };

            List<double> precos = new List<double>
            {
                50.00,
                120.00,
                899.90,
                80.00,
                150.00
            };

            ViewBag.Produtos = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}