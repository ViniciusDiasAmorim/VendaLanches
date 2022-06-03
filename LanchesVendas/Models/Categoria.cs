using System.ComponentModel.DataAnnotations;

namespace VendasDeLanches.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe um nome para a categoria")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da categoria deve ter entre 3 e 100 caracteres")]
        public string CategoriaNome { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe uma descrição para a categoria")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 200 caracteres")]

        public string CategoriaDescricao { get; set; }
        public List<Lanche> Lanches { get; set; }
    }
}
