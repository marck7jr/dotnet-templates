using Project1.Application.Interfaces;

namespace Project1.Infrastructure.Services;
public class DateTimeService : IDateTimeService
{
    public DateTime GetUtcNow() => DateTime.UtcNow;
}