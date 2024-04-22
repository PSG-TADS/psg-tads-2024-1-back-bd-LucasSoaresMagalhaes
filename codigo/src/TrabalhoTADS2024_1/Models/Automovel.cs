using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoTADS2024_1.Models
{
    public class Automovel
    {
        [Key]
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Cor { get; set; }
        public string? Modelo { get; set; }
        [ForeignKey("Id_Reserva")]
        public string? Id_Reserva { get; set; }

    }
}

