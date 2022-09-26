using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InterceptorReproduction.EntityFrameworkCore;
using InterceptorReproduction.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace InterceptorReproduction.Web.Tests
{
    [DependsOn(
        typeof(InterceptorReproductionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class InterceptorReproductionWebTestModule : AbpModule
    {
        public InterceptorReproductionWebTestModule(InterceptorReproductionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InterceptorReproductionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(InterceptorReproductionWebMvcModule).Assembly);
        }
    }
}