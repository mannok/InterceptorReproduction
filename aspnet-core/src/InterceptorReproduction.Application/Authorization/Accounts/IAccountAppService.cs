using System.Threading.Tasks;
using Abp.Application.Services;
using InterceptorReproduction.Authorization.Accounts.Dto;

namespace InterceptorReproduction.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
