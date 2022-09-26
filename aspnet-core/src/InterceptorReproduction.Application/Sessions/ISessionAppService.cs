using System.Threading.Tasks;
using Abp.Application.Services;
using InterceptorReproduction.Sessions.Dto;

namespace InterceptorReproduction.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
