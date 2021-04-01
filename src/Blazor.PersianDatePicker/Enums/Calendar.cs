// ReSharper disable once CheckNamespace

namespace Blazor.PersianDatePicker
{
    public enum Calendar
    {
        /// <summary>
        /// Both Jalali (Persian) and Miladi (Gregorian) calendars, with default set to Jalali 
        /// </summary>
        DualModeJalaliDefault,

        /// <summary>
        /// Both Jalali (Persian) and Miladi (Gregorian) calendars, with default set to Miladi 
        /// </summary>
        DualModeMiladiDefault,

        /// <summary>
        /// Only Jalali (Persian) calendar
        /// </summary>
        SingleModeJalali,

        /// <summary>
        /// Only Miladi (Gregorian) calendar
        /// </summary>
        SingleModeMiladi
    }
}