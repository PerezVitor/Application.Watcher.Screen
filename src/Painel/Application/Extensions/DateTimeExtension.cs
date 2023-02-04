namespace Painel.Application.Extensions;
public static class DateTimeExtension
{
    public static string FormatDate(this DateTime date)
        => date.ToString("MM/dd/yyyy HH:mm:ss");
}