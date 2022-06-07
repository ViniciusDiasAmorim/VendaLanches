using LanchesVendas.Context;
using LanchesVendas.Models;
using LanchesVendas.Repositories.Interfaces;

namespace LanchesVendas.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AplicandoDbContext _context;
        private readonly CarrinhoDeCompra _carrinhoDeCompra;

        public PedidoRepository(AplicandoDbContext context, CarrinhoDeCompra carrinhoCompra)
        {
            _context = context;
            _carrinhoDeCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _context.Pedidos.Add(pedido);

            if (_carrinhoDeCompra.CarrinhoCompraItems != null)
            {
                _context.SaveChanges();

                var carrinho = _carrinhoDeCompra.CarrinhoCompraItems;
                foreach (var item in carrinho)
                {
                    var details = new PedidoItem()
                    {
                        LancheId = item.Lanche.LancheId,
                        Preco = item.Lanche.Preco,
                        Quantidade = item.Quantidade,
                        PedidoId = pedido.PedidoId
                    };

                    _context.PedidoItems.Add(details);

                }
                _context.SaveChanges();
            }
        }
    }
}
