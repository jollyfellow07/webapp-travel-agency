using Microsoft.EntityFrameworkCore;
using Viaggiatore.Models;

namespace Viaggiatore.Data
{
    public class ViaggioContext : DbContext
    {
        public DbSet<Pacchetto> pacchetti { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=DbViaggioAgenzia; Integrated Security=True");
        }
    }
}
