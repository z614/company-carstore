using Company.Carstore.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Company.Carstore.Api.Data
{
    public class CarstoreContext : DbContext
    {
        public CarstoreContext(DbContextOptions<CarstoreContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) =>
base.OnModelCreating(builder);

        public DbSet<Car> Cars { get; set; }
    }
}