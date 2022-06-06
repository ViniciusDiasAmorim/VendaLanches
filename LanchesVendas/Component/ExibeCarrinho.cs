using LanchesVendas.Models;
using LanchesVendas.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Component
{
    public class ExibeCarrinho : ViewComponent
    {
        private readonly CarrinhoDeCompra _carrinhoDeCompra;

        public ExibeCarrinho(CarrinhoDeCompra carrinhoCompra)
        {
            _carrinhoDeCompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
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
    }
}
