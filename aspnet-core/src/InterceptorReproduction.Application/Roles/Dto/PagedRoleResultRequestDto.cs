using Abp.Application.Services.Dto;

namespace InterceptorReproduction.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

