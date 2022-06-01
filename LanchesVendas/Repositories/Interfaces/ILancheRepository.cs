using VendasDeLanches.Models;

namespace LanchesVendas.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesDoDia { get; }
        Lanche GetLancheById(int lancheId);
    }
}
