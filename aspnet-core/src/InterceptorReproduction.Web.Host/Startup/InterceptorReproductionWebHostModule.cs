using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InterceptorReproduction.Configuration;

namespace InterceptorReproduction.Web.Host.Startup
{
    [DependsOn(
       typeof(InterceptorReproductionWebCoreModule))]
    public class InterceptorReproductionWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InterceptorReproductionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InterceptorReproductionWebHostModule).GetAssembly());
        }
    }
}
