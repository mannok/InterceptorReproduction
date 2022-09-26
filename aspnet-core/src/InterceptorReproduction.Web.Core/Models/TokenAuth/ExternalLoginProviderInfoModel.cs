using Abp.AutoMapper;
using InterceptorReproduction.Authentication.External;

namespace InterceptorReproduction.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
