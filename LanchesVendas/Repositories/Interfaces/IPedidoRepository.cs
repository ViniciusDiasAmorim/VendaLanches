using LanchesVendas.Models;

namespace LanchesVendas.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        public void CriarPedido(Pedido pedido);
    }
}
