using System.ComponentModel.DataAnnotations;

namespace AvaVendas.Models
{
    public class NivelAcesso
    {
        [Key]
        [Display(Name = "ID de acesso")]
        [Required]
        public int NivelID { get; set; }

        [Display(Name = "Nome do Nível de acesso")]
        public string? Acesso { get; set; }
    }
}
