using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using InterceptorReproduction.Authorization.Roles;
using InterceptorReproduction.Authorization.Users;
using InterceptorReproduction.MultiTenancy;

namespace InterceptorReproduction.EntityFrameworkCore
{
    public class InterceptorReproductionDbContext : AbpZeroDbContext<Tenant, Role, User, InterceptorReproductionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public InterceptorReproductionDbContext(DbContextOptions<InterceptorReproductionDbContext> options)
            : base(options)
        {
        }
    }
}
