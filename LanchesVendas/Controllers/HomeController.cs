using LanchesVendas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancherepository;

        public HomeController(ILancheRepository lancherepository)
        {
            _lancherepository = lancherepository;
        }

        public IActionResult Index()
        {
            var lancheDoDia = _lancherepository.LanchesDoDia;

            return View(lancheDoDia);
        }
    }
}