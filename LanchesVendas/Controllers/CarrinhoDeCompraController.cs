using LanchesVendas.Models;
using LanchesVendas.Repositories.Interfaces;
using LanchesVendas.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class CarrinhoDeCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoDeCompra _carrinhoDeCompra;

        public CarrinhoDeCompraController(ILancheRepository lancheRepository, CarrinhoDeCompra carrinhoDeCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoDeCompra = carrinhoDeCompra;
        }

        public ActionResult Index()
        {
            var itens = _carrinhoDeCompra.GetCarrinhoCompraItens();

            _carrinhoDeCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoDeCompraViewModel
            {
                CarrinhoDeCompra = _carrinhoDeCompra,
                CarrinhoDeCompraTotal = _carrinhoDeCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }
        public ActionResult AdicionarItemAoCarrinho(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(x => x.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoDeCompra.AdicionarAoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }

        public ActionResult RemoverItemDoCarrinho(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(x => x.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoDeCompra.RemoverDoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
