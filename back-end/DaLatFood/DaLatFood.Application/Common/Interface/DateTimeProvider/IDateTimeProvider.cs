namespace DaLatFood.Application.Common.Interface.DateTimeProvider;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}