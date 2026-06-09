using Microsoft.AspNetCore.Mvc;
using Checkpoint_10.Models;

namespace Checkpoint_10.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Resultado(EnderecoModel model)
        {
            return View(model);
        }
    }
}