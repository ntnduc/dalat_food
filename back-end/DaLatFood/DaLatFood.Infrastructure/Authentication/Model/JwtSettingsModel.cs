namespace DaLatFood.Infrastructure.Authentication.Model;

public class JwtSettingsModel
{
    public const string SectionName = "JwtSettings";
    public string Issuer { get; set; } = null!;
    public int ExpiryMinutes { get; set; }
    public string Secret { get; set; } = null!;
    public string Audience { get; set; } = null!;
}