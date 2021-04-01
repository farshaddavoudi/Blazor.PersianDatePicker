using System.ComponentModel.DataAnnotations;
// ReSharper disable CheckNamespace

namespace Blazor.PersianDatePicker
{
    public enum PickerTheme
    {
        [Display(Name = "default-theme")]
        Default,

        [Display(Name = "dark-theme")]
        Dark,

        [Display(Name = "blue-theme")]
        Blue,

        [Display(Name = "cheerup-theme")]
        Cheerup,

        [Display(Name = "redblack-theme")]
        RedBlack
    }
}