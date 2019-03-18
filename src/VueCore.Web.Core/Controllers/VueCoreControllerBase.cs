using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace VueCore.Controllers
{
    public abstract class VueCoreControllerBase: AbpController
    {
        protected VueCoreControllerBase()
        {
            LocalizationSourceName = VueCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
