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
          
            ViewBag.ProcuraLanche = "Todos os lanches";

            return View(lanchesNome);
        }
     
        public IActionResult Categoria(int id)
        {
            var categoriaLanches = _lancheRepository.Lanches.Where(x => x.CategoriaId == id);

            var categoria = _lancheRepository.Lanches.FirstOrDefault(x => x.CategoriaId == id);

            ViewBag.Categorias = categoria.Categoria.CategoriaNome;

            return View(categoriaLanches);
        }
        public IActionResult ProcuraLanche(string stringProcura)
        {
            if (string.IsNullOrEmpty(stringProcura))
            {
                var lancheProcurado = _lancheRepository.Lanches;
                ViewBag.ProcuraLanche = "Todos os lanches";
                return View("~/Views/Lanche/Index.cshtml", lancheProcurado);
            }
            else
            {
                var lancheProcurado = _lancheRepository.Lanches.Where(x => x.LancheNome.ToLower().Contains(stringProcura.ToLower()));
                ViewBag.ProcuraLanche = stringProcura;
                return View("~/Views/Lanche/Index.cshtml", lancheProcurado);
            }
        }
    }
}
