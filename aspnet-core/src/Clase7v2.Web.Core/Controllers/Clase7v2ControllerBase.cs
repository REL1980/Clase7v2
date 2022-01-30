using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Clase7v2.Controllers
{
    public abstract class Clase7v2ControllerBase: AbpController
    {
        protected Clase7v2ControllerBase()
        {
            LocalizationSourceName = Clase7v2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
