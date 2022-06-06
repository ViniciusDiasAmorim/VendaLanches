using LanchesVendas.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesVendas.Context
{
    public class AplicandoDbContext : DbContext
    {
        public AplicandoDbContext(DbContextOptions<AplicandoDbContext> options) : base(options)
        {
        }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    }
}
