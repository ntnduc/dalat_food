namespace DaLatFood.Application.Authentication.Dto;

public class RegisterDto
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string RequiredPassword { get; set; }
    public string Token { get; set; }
}