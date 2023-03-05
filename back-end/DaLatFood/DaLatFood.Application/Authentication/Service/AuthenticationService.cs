using DaLatFood.Application.Authentication.Dto;
using DaLatFood.Application.Common.Interface.Authentication;
using DaLatFood.Constracts.Ums;

namespace DaLatFood.Application.Authentication.Service;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<LoginDto> LoginAsync(LoginDto loginDto)
    {
        //find user

        return loginDto;
    }

    public async Task<RegisterDto> RegisterAsync(RegisterModel registerModel)
    {
        //check existed user
        
        //create new user
        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GeneratorToken(userId, registerModel.FirstName, registerModel.LastName);
        var result = new RegisterDto
        {
            UserName = registerModel.UserName,
            FirstName = registerModel.FirstName,
            LastName = registerModel.LastName,
            Email = registerModel.LastName,
            Password = registerModel.Password,
            RequiredPassword = registerModel.RequiredPassword,
            Token = token
        };
        return result;
    }
}