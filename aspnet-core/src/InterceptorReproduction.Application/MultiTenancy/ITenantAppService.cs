using Abp.Application.Services;
using InterceptorReproduction.MultiTenancy.Dto;

namespace InterceptorReproduction.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

