using DaLatFood.Application.Authentication.Dto;
using DaLatFood.Application.Authentication.Service;
using DaLatFood.Constracts.Ums;
using DaLatFood.WebApi.Common;
using Microsoft.AspNetCore.Mvc;

namespace DaLatFood.WebApi.Controllers.Authentication;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [Route("login")]
    [HttpPost]
    public async Task<ApiResponse<LoginDto>> Login(LoginDto loginDto)
    {
        var result = await _authenticationService.LoginAsync(loginDto);
        return ApiResponse<LoginDto>.Ok(result);
    }

    [Route("register")]
    [HttpPost]
    public async Task<ApiResponse<RegisterDto>> Register(RegisterModel registerModel)
    {
        var result = await _authenticationService.RegisterAsync(registerModel);
        return ApiResponse<RegisterDto>.Ok(result);
    }
}