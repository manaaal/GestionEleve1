using GestionEleve1.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionEleve1.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) { }
        
        public DbSet<Eleve> Eleve { get; set; }
        public DbSet<Etablissement> Etablissement { get; set; }
    }
}
