using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Clase7v2.Authorization.Roles;
using Clase7v2.Authorization.Users;
using Clase7v2.MultiTenancy;
using Clase7v2.Domain;

namespace Clase7v2.EntityFrameworkCore
{
    public class Clase7v2DbContext : AbpZeroDbContext<Tenant, Role, User, Clase7v2DbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Product> Products { get; set; }
        
        public Clase7v2DbContext(DbContextOptions<Clase7v2DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfig());
        }
    }
}
