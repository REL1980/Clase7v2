using Abp.Authorization;
using Clase7v2.Authorization.Roles;
using Clase7v2.Authorization.Users;

namespace Clase7v2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
