using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InterceptorReproduction.Authorization;

namespace InterceptorReproduction
{
    [DependsOn(
        typeof(InterceptorReproductionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class InterceptorReproductionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            MeasureDurationInterceptorRegistrar.Initialize(IocManager.IocContainer.Kernel);

            Configuration.Authorization.Providers.Add<InterceptorReproductionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(InterceptorReproductionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
