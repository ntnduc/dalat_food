using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using DaLatFood.Application.Common.Interface.Authentication;
using DaLatFood.Application.Common.Interface.DateTimeProvider;
using DaLatFood.Infrastructure.Authentication.Model;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace DaLatFood.Infrastructure.Authentication.Service;

public class JwTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;
    private readonly JwtSettingsModel _jwtSettingsModel;

    public JwTokenGenerator(IDateTimeProvider dateTimeProvider, IOptions<JwtSettingsModel> jwtSettingsModel)
    {
        _dateTimeProvider = dateTimeProvider;
        _jwtSettingsModel = jwtSettingsModel.Value;
    }

    public string GeneratorToken(Guid userId, string firstName, string lastName)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettingsModel.Secret)), SecurityAlgorithms.HmacSha256);
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var securityToken = new JwtSecurityToken(
            issuer: _jwtSettingsModel.Issuer,
            audience: _jwtSettingsModel.Audience,
            expires: _dateTimeProvider.UtcNow.AddMinutes(_jwtSettingsModel.ExpiryMinutes),
            claims: claims,
            signingCredentials: signingCredentials
        );
        var tokenString = new JwtSecurityTokenHandler().WriteToken(securityToken);
        return tokenString;
    }
}