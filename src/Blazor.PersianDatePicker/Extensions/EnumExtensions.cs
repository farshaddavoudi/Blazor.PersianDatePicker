using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Blazor.PersianDatePicker.Extensions
{
    public static class EnumExtensions
    {
        public static string? ToDisplayName(this Enum value, bool showEnumStringIfNoDisplayName = true)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var displayName = value.GetType()
                .GetMember(value.ToString())
                .First()
                ?.GetCustomAttributes<DisplayAttribute>()
                .FirstOrDefault()
                ?.GetName();
            return displayName ?? (showEnumStringIfNoDisplayName ? value.ToString() : null);
        }
    }
}