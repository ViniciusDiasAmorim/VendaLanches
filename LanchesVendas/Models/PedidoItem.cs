using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesVendas.Models
{
    public class PedidoItem
    {
        public int PedidoItemId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Lanche Lanche { get; set; }
        public int LancheId { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
