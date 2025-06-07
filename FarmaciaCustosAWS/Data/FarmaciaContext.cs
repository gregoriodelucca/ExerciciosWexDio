using Microsoft.EntityFrameworkCore;
using FarmaciaCustosAWS.Models;

namespace FarmaciaCustosAWS.Data
{
    public class FarmaciaContext : DbContext
    {
        public FarmaciaContext(DbContextOptions<FarmaciaContext> options) : base(options)
        {
        }

        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
