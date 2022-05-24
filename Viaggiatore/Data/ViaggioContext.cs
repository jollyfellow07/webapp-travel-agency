using Microsoft.EntityFrameworkCore;
using Viaggiatore.Models;

namespace Viaggiatore.Data
{
    public class ViaggioContext : DbContext
    {
        public DbSet<Pacchetto> pacchetti { get; set; }
        public DbSet<RichiestaUtente> richiesteUtenti { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=DbViaggio; Integrated Security=True");
        }
    }
}
