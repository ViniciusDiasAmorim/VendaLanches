using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LanchesVendas.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Infome o nome de usuario")]
        public string Usuario { get; set; }
        [Required(ErrorMessage = "Infome a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        public string ReturnUrl { get; set; }
    }
}
