using Abp.Authorization;
using InterceptorReproduction.Authorization.Roles;
using InterceptorReproduction.Authorization.Users;

namespace InterceptorReproduction.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
