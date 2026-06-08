using Microsoft.AspNetCore.Mvc;

namespace Checkpoint_9.Controllers
{
    public class ImcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double peso, double altura)
        {
            if (altura <= 0)
            {
                ViewBag.Resultado = "Altura inválida";
                return View();
            }

            double imc = peso / (altura * altura);

            string classificacao;

            if (imc < 18.5)
                classificacao = "Abaixo do peso";
            else if (imc < 25)
                classificacao = "Peso normal";
            else if (imc < 30)
                classificacao = "Sobrepeso";
            else
                classificacao = "Obesidade";

            ViewBag.Resultado = $"IMC: {imc:F2} - {classificacao}";

            return View();
        }
    }
}