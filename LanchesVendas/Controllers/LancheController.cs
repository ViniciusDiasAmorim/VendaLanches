using LanchesVendas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        private readonly ICategoriaRepository _categoriaRepository;

        public LancheController(ILancheRepository lancheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index()
        {
            var lanchesNome = _lancheRepository.Lanches;

            return View(lanchesNome);
        }

        public IActionResult Categoria(int id)
        {
            var categoriaLanches = _lancheRepository.Lanches.Where(x => x.CategoriaId == id);

            var categorias = _categoriaRepository.Categorias.FirstOrDefault(x => x.CategoriaId == id);

            ViewBag.Categorias = categorias.CategoriaNome;

            return View(categoriaLanches);

        }
    }
}
