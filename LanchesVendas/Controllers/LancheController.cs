using LanchesVendas.Repositories.Interfaces;
using LanchesVendas.ViewModel;
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

            var lanchesVM = new LancheViewModel()
            {
                Lanches = lanchesNome
            };

            ViewBag.ProcuraLanche = "Todos os lanches";

            return View(lanchesVM);
        }
     
        public IActionResult Categoria(int id)
        {
            var lanchePorCategoria = _lancheRepository.Lanches.Where(x => x.CategoriaId == id);

            var categoria = _lancheRepository.Lanches.FirstOrDefault(x => x.CategoriaId == id);

            var lanchesVM = new LancheViewModel()
            {
                Lanches = lanchePorCategoria
            };

            ViewBag.Categorias = categoria.Categoria.CategoriaNome;

            return View(lanchesVM);
        }
        public IActionResult ProcuraLanche(string stringProcura)
        {
            if (string.IsNullOrEmpty(stringProcura))
            {
                var lancheProcurado = _lancheRepository.Lanches;

                var lanchesVM = new LancheViewModel()
                {
                    Lanches = lancheProcurado
                };
                ViewBag.ProcuraLanche = "Todos os lanches";

                return View("~/Views/Lanche/Index.cshtml", lanchesVM);
            }
            else
            {
                var lancheProcurado = _lancheRepository.Lanches.Where(x => x.LancheNome.ToLower().Contains(stringProcura.ToLower()));

                var lanchesVM = new LancheViewModel()
                {
                    Lanches = lancheProcurado
                };

                ViewBag.ProcuraLanche = stringProcura;

                return View("~/Views/Lanche/Index.cshtml", lanchesVM);
            }
        }
    }
}
