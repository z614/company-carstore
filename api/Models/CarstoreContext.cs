using Microsoft.EntityFrameworkCore;

namespace Company.Carstore.Api.Models
{
    public class CarstoreContext : DbContext
    {
        public CarstoreContext(DbContextOptions<CarstoreContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}