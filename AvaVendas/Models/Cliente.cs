using System.ComponentModel.DataAnnotations;

namespace AvaVendas.Models
{
    public class Cliente
    {
        [Display(Name = "Nível de acesso")]
        [Required]
        public int NivelID { get; set; }
        public int ClienteId { get; set; }

        [Display(Name = "Nome do cliente")]
        public string Name { get; set; }

        [Display(Name = "CPF cliente")]
        public string CPF { get; set; }

        [Display(Name = "Celular")]
        public string Telefone { get; set; }

        //tenho que pedir pra ele criar um email
    }
}
