using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using InterceptorReproduction.Configuration.Dto;

namespace InterceptorReproduction.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InterceptorReproductionAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
