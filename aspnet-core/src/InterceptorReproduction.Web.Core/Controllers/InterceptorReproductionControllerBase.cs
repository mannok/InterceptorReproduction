using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InterceptorReproduction.Controllers
{
    public abstract class InterceptorReproductionControllerBase: AbpController
    {
        protected InterceptorReproductionControllerBase()
        {
            LocalizationSourceName = InterceptorReproductionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
