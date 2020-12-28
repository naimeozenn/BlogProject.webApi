using BlogProject.Entities.Concrete;

namespace BlogProject.Business.Tools.JWTTool
{
    public interface IJwtService
    {
        JwtToken GenerateJwt(AppUser appUser);
    }
}
