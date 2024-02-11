using ClothifyPOS.Infrastructure.IdentityFeatures.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothifyPOS.Infrastructure
{
    public class ApplicationDbContext(string connectionString, string migrationAssembly) 
        : IdentityDbContext<ApplicationUser,ApplicationRole, Guid,ApplicationUserClaim, ApplicationUserRole,
          ApplicationUserLogin, ApplicationRoleClaim, ApplicationUserToken>, IApplicationDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString, m => m.MigrationsAssembly(migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
