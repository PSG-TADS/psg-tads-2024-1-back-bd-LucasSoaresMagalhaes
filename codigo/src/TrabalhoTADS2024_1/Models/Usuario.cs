using System.ComponentModel.DataAnnotations;

namespace TrabalhoTADS2024_1.Models
{
    public class Usuario
    {
        [Key]
        public string? CPF { get; set; }
        public string? Nome { get; set; }
        private string? Senha { get; set; }
        public string? Email { get; set; }
    }
}
