namespace DaLatFood.Application.Common.Interface.Authentication;

public interface IJwtTokenGenerator
{
    string GeneratorToken(Guid userId, string firstName, string lastName);
}