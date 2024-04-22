using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;

namespace TrabalhoTADS2024_1.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Administrador> Administradores { get; set;}
        public DbSet<Automovel> Automoveis { get; set;}
        public DbSet<Reserva> Reservas { get; set;}
        public DbSet<Usuario> Usuarios { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _=optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TrabalhoTADS1;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }
}
