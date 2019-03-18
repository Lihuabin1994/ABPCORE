using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using VueCore.Roles.Dto;
using VueCore.Users.Dto;

namespace VueCore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
       // Task GetName(UserDto name);
    }
}
