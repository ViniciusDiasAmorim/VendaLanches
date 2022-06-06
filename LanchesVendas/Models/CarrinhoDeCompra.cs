using LanchesVendas.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesVendas.Models
{
    public class CarrinhoDeCompra
    {
        public string CarrinhoDeCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        private readonly AplicandoDbContext _context;

        public CarrinhoDeCompra(AplicandoDbContext context)
        {
            _context = context;
        }

        public static CarrinhoDeCompra GetCarrinho(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AplicandoDbContext>();

            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            session.SetString("CarrinhoId", carrinhoId);

            return new CarrinhoDeCompra(context)
            {
                CarrinhoDeCompraId = carrinhoId
            };
        }
        public void AdicionarAoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.FirstOrDefault(x => x.Lanche.LancheId == lanche.LancheId);

            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoDeCompraId = CarrinhoDeCompraId,
                    Lanche = lanche,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItems.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }
        public void RemoverDoCarrinho(Lanche lanche)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItems.SingleOrDefault(x => x.Lanche.LancheId == lanche.LancheId && x.CarrinhoDeCompraId == CarrinhoDeCompraId);

            if (carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                }
                else
                {
                    _context.CarrinhoCompraItems.Remove(carrinhoCompraItem);
                }
            }
            _context.SaveChanges();
        }
        public List<CarrinhoCompraItem> GetCarrinhoCompraItens()
        {
            return CarrinhoCompraItems ??(_context.CarrinhoCompraItems.Where(x => x.CarrinhoCompraItemId == x.CarrinhoCompraItemId).Include(x => x.Lanche).ToList());
    
        }
        public void LimparCarrinho()
        {
            var carrinho = _context.CarrinhoCompraItems.Where(x => x.CarrinhoDeCompraId == CarrinhoDeCompraId);

            _context.CarrinhoCompraItems.RemoveRange(carrinho);
            _context.SaveChanges();
        }
        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItems.Where(x => x.CarrinhoDeCompraId == CarrinhoDeCompraId).Select(x => x.Quantidade * x.Lanche.Preco).Sum();

            return total;
        }
    }
}
