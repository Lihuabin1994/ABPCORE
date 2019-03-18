using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VueCore.MultiTenancy.Dto;

namespace VueCore.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

