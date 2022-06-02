using LanchesVendas.Context;
using LanchesVendas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using VendasDeLanches.Models;

namespace LanchesVendas.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AplicandoDbContext _context;

        public LancheRepository(AplicandoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(x => x.Categoria);

        public IEnumerable<Lanche> LanchesDoDia => _context.Lanches.Where(x => x.LancheDoDia == true).Include(x => x.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(x => x.LancheId == lancheId);
        }
    }
}
