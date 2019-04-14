using Company.Carstore.Api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.Carstore.Api.Data
{
    public class CarstoreContext : IdentityDbContext <ApplicationUser>
    {
        public CarstoreContext(DbContextOptions<CarstoreContext> options) : base(options)
        {}
        

        protected CarstoreContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder) =>
base.OnModelCreating(builder);

        public DbSet<Car> Cars { get; set; }
    }
}