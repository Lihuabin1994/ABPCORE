using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using VueCore.Configuration.Dto;

namespace VueCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : VueCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
