using System.Threading.Tasks;
using VueCore.Configuration.Dto;

namespace VueCore.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
