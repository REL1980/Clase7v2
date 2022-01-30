using System.Threading.Tasks;
using Clase7v2.Configuration.Dto;

namespace Clase7v2.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
