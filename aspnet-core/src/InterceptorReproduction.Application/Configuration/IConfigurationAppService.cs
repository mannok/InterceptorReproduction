using System.Threading.Tasks;
using InterceptorReproduction.Configuration.Dto;

namespace InterceptorReproduction.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
