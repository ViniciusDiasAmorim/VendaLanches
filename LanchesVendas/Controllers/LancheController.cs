using LanchesVendas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var lanchesNome = _lancheRepository.Lanches;
            return View(lanchesNome);
        }
    }
}
