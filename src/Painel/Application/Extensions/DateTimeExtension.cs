namespace Painel.Application.Extensions;
public static class DateTimeExtension
{
    public static bool IsBetween(this DateTime date, DateTime startDate, DateTime endDate)
        => date >= startDate && date <= endDate;
}
