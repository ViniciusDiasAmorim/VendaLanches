using LanchesVendas.Context;
using LanchesVendas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using VendasDeLanches.Models;

namespace LanchesVendas.Repositories
{
    public class CategoriaReposiory : ICategoriaRepository
    {
        private readonly AplicandoDbContext _context;
        public CategoriaReposiory(AplicandoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
