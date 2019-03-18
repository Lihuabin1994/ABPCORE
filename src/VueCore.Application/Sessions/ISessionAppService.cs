using System.Threading.Tasks;
using Abp.Application.Services;
using VueCore.Sessions.Dto;

namespace VueCore.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
