using Abp.Authorization;
using VueCore.Authorization.Roles;
using VueCore.Authorization.Users;

namespace VueCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
