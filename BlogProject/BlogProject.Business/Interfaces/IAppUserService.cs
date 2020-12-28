using BlogProject.DTO.DTOs.AppUserDtos;
using BlogProject.Entities.Concrete;
using System.Threading.Tasks;

namespace BlogProject.Business.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        Task<AppUser> CheckUserAsync(AppUserLoginDto appUserLoginDto);
        Task<AppUser> FindByNameAsync(string userName);
    }
}
