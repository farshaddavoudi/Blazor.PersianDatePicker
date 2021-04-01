using System.ComponentModel.DataAnnotations;

// ReSharper disable InconsistentNaming
// ReSharper disable once CheckNamespace

namespace Blazor.PersianDatePicker
{
    public enum DateFormat
    {
        /// <summary>
        /// e.g. 1400/01/01
        /// </summary>
        [Display(Name = "YYYY/MM/DD")]
        yyyy_slash_MM_slash_dd,

        /// <summary>
        /// e.g. 1400-01-01
        /// </summary>
        [Display(Name = "YYYY-MM-DD")]
        yyyy_dash_MM_dash_dd
    }

    public static class DateFormatExtensions
    {
        public static string GetCSharpFormat(this DateFormat format)
        {
            if (format == DateFormat.yyyy_slash_MM_slash_dd)
                return "yyyy/MM/dd";

            if (format == DateFormat.yyyy_dash_MM_dash_dd)
                return "yyyy-MM-dd";

            return null;
        }

        public static string GetSeparator(this DateFormat format)
        {
            if (format == DateFormat.yyyy_slash_MM_slash_dd)
                return "/";

            if (format == DateFormat.yyyy_dash_MM_dash_dd)
                return "-";

            return null;
        }
    }
}

