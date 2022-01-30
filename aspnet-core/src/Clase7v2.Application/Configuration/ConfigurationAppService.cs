using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Clase7v2.Configuration.Dto;

namespace Clase7v2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Clase7v2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
