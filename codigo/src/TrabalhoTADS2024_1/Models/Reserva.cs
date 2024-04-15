using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoTADS2024_1.Models
{
    public class Reserva
    {
        public string? Id_Reserva { get; set; }
        public string? DataInicioReserva { get; set; }
        public string? DataFimReserva { get; set; }
        [ForeignKey("CPF")]
        public string? CPF_UsuarioC { get; set; }
        [ForeignKey("Placa")]
        public string? Automovel { get; set; }
    }
}
