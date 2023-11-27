using Refit;
using RefitSample.Models;

namespace RefitSample;

public interface IUserService
{
    [Post("/user")]
    Task<ApiResponse> CreateUser([Body] User user);

    [Get("/user/login")]
    Task<IApiResponse<string>> LoginUser([Query] string username, [Query] string password);
}