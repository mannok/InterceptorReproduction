using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InterceptorReproduction.Configuration;
using InterceptorReproduction.EntityFrameworkCore;
using InterceptorReproduction.Migrator.DependencyInjection;

namespace InterceptorReproduction.Migrator
{
    [DependsOn(typeof(InterceptorReproductionEntityFrameworkModule))]
    public class InterceptorReproductionMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public InterceptorReproductionMigratorModule(InterceptorReproductionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(InterceptorReproductionMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                InterceptorReproductionConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InterceptorReproductionMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
