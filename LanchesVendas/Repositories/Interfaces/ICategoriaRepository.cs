using VendasDeLanches.Models;

namespace LanchesVendas.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
