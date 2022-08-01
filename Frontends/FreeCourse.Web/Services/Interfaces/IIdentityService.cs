using FreeCourse.Shared.Dtos;
using IdentityModel.Client;
using FreeCourse.Web.Models;
namespace FreeCourse.Web.Services.Interfaces;

public interface IIdentityService
{
    Task<Response<bool>> SignIn(SignInInput signinInput);

    Task<TokenResponse> GetAccessTokenByRefreshToken();

    Task RevokeRefreshToken();
}