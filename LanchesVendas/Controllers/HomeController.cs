using LanchesVendas.Repositories.Interfaces;
using LanchesVendas.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancherepository)
        {
            _lancheRepository = lancherepository;
        }

        public IActionResult Index()
        {
            var lancheDoDia = _lancheRepository.LanchesDoDia;

            var lancheHomeVM = new HomeViewModel()
            {
                LanchesDoDia = lancheDoDia
            };

            return View(lancheHomeVM);
        }
    }
}