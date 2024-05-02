using System.ComponentModel.DataAnnotations;

namespace AvaVendas.Models
{
    public class Login
    {
        [Display(Name = "ID de acesso")] //apenas o adm pode cadastrar
        [Required]
        public int NivelID { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "O e-mail fornecido não é válido.")]
        [Display(Name = "E-mail")]
        [Required]
        public string Usuario { get; set; }

        [StringLength(10, MinimumLength = 6, ErrorMessage = "Máximo de 10, mínimo de 6 caracteres")]
        [Required]
        public string? Senha { get; set; }
    }
}
