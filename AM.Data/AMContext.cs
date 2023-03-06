
using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{
    public class AMContext : DbContext
    {
        //Parametre l'acces a la BD

        public DbSet<Passenger> passenger { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Plane> Plane { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Traveller> travellers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                        Initial Catalog = Airport;  
                        Integrated Security = true");

        }
    }
}