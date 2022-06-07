using LanchesVendas.Models;
using LanchesVendas.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesVendas.Controllers
{
    public class PedidoController : Controller
    {
        private readonly CarrinhoDeCompra _carrinhoDeCompra;
        private readonly IPedidoRepository _pedidoRepository;

        public PedidoController(CarrinhoDeCompra carrinhoDeCompra, IPedidoRepository pedidoRepository)
        {
            _carrinhoDeCompra = carrinhoDeCompra;
            _pedidoRepository = pedidoRepository;
        }
        
        public IActionResult EncerrarPedido()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EncerrarPedido(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal pedidoPrecoTotal = 0;

            List<CarrinhoCompraItem> items = _carrinhoDeCompra.GetCarrinhoCompraItens();
            _carrinhoDeCompra.CarrinhoCompraItems = items;

            if (_carrinhoDeCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Voce nao adicionou nenhum item no carrinho");
            }

            foreach (var obj in items)
            {
                totalItensPedido += obj.Quantidade;
                pedidoPrecoTotal += (obj.Quantidade * obj.Lanche.Preco);
            }
            pedido.TotalDePedidos = totalItensPedido;
            pedido.PedidoTotal = pedidoPrecoTotal;
         
            if (ModelState.IsValid)
            {

                _pedidoRepository.CriarPedido(pedido);

                ViewBag.Concluido = "Pedido realizado com sucesso";
                ViewBag.TotalPedido = _carrinhoDeCompra.GetCarrinhoCompraTotal();

                _carrinhoDeCompra.LimparCarrinho();

                return View("~/Views/Pedido/EncerrarPedidoPost.cshtml", pedido);
            }
            return View(pedido);
        }
    }
}

