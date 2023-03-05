using DaLatFood.Application.Authentication.Dto;
using DaLatFood.Constracts.Ums;

namespace DaLatFood.Application.Authentication.Service;

public interface IAuthenticationService
{
    Task<LoginDto> LoginAsync(LoginDto loginDto);
    Task<RegisterDto> RegisterAsync(RegisterModel registerDto);
}