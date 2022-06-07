using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LanchesVendas.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        [Required(ErrorMessage ="Informe seu Nome")]
        [Display(Name ="Nome")]
        [StringLength(50)]
        public string ClienteNome { get; set; }
        [Required(ErrorMessage = "Informe seu Sobrenome")]
        [Display(Name = "Sobrenome")]
        [StringLength(50)]
        public string ClienteSobrenome { get; set; }
        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço")]
        [StringLength(75)]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Informe sua cidade")]
        [StringLength(50)]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe um numero de telefone")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe seu Email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int TotalDePedidos { get; set; }
        public decimal PedidoTotal { get; set; }
        public DateTime PedidoEnviado { get; set; }
        public DateTime? PedidoEntregue { get; set; }
        [ValidateNever]
        public List<PedidoItem> PedidoItems { get; set; }

    }
}
