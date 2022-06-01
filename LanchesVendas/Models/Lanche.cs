using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VendasDeLanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Informe o nome do lanche")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O lanche deve ter entre 3 e 100 caracteres")]
        public string LancheNome { get; set; }
        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Informe uma descrição para o lanche")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "A descrição deve ter entre 5 e 200 caracteres")]
        public string Descricao { get; set; }
        [Display(Name = "Imagem Url")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Lanche do dia")]
        public bool LancheDoDia { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
