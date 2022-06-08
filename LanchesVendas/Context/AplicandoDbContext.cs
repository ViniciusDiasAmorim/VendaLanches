using LanchesVendas.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LanchesVendas.Context
{
    public class AplicandoDbContext : IdentityDbContext<IdentityUser>
    {
        public AplicandoDbContext(DbContextOptions<AplicandoDbContext> options) : base(options)
        {
        }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItems { get; set; }

    }
}
