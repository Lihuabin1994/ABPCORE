using System.Threading.Tasks;
using Abp.Application.Services;
using VueCore.Authorization.Accounts.Dto;

namespace VueCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
