using LanchesVendas.Context;
using LanchesVendas.Repositories.Interfaces;
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

        public IEnumerable<Lanche> Lanches => _context.Lanches;

        public IEnumerable<Lanche> LanchesDoDia => _context.Lanches.Where(x => x.LancheDoDia == true);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(x => x.LancheId == lancheId);
        }
    }
}
