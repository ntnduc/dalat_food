using DaLatFood.Application.Common.Interface.DateTimeProvider;

namespace DaLatFood.Infrastructure.DateTimeProvider.Service;

public class DateTimeProviderService : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}