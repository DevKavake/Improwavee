using System.Globalization;

namespace Improwave.Application.Extensions;

public static class DateTimeExtension
{
    public static string ToShamsi(this DateTime dateTime)
    {
        PersianCalendar pc = new PersianCalendar();

        int year = pc.GetYear(dateTime);
        int month = pc.GetMonth(dateTime);
        int day = pc.GetDayOfMonth(dateTime);

        // 1402/09/10

        //1402/9/10
        return $"{year.ToString("0000")}/{month.ToString("00")}/{day.ToString("00")}";
    }
}

