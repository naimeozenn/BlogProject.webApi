using BlogProjectFront.Models;
using System.Threading.Tasks;

namespace BlogProjectFront.ApiServices.Interfaces
{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}
