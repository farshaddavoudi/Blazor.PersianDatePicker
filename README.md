﻿# Blazor.PersianDatePicker
 
[![NuGet Version](https://img.shields.io/nuget/v/Blazor.PersianDatePicker.svg?style=flat)](https://www.nuget.org/packages/Blazor.PersianDatePicker/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://raw.githubusercontent.com/farshaddavoudi/Blazor.PersianDatePicker/master/LICENSE)

<img src="https://github.com/fericode/Blazor.PersianDatePicker/blob/master/screenshot.png">

##### 🎈 Optimize design after `v2.0.0` | Mark holidays (optional) after `v3.5.0` — Thanks to [@Mostafa-Moradi](https://github.com/Mostafa-Moradi) for asking [the feature](https://github.com/farshaddavoudi/Blazor.PersianDatePicker/issues/93)

<img src="https://github.com/fericode/Blazor.PersianDatePicker/blob/master/screenshot-design-changes.png">

> ✨ **Important fix in v3.4.0 — update your package**: The 1403 Jalali leap year was miscalculated therefore all dates in the next Jalali year (1404) were wrong by one day. It is resolved now. Thanks to [@web724online](https://github.com/web724online) for creating [the issue](https://github.com/farshaddavoudi/Blazor.PersianDatePicker/issues/89).

> ✨ **Important fix in v3.2.0**: When we set the bound parameter value to some date by code (for example in the `OnInitialize` method of our component) and then click on the input, the selected date in the datepicker was always today, not that date. It is resolved now. Thanks to [@EsmaeelAmarloo](https://github.com/EsmaeelAmarloo) for creating [the issue](https://github.com/farshaddavoudi/Blazor.PersianDatePicker/issues/60#issuecomment-1820790657).

## Compatibility:
It is compatible and installable on all .NET 5, .NET 6, .NET 7 and .NET 8 Blazor projects

## Usage:

1- Install **Blazor.PersianDatePicker** from Nuget.org

2- Add `<script src="_content/Blazor.PersianDatePicker/datepicker.min.js" type="text/javascript"></script>` to your **index.html** or **_Host.cshtml** or **App.razor** *(in .NET8)*

3- Add `<link href="_content/Blazor.PersianDatePicker/datepicker.css" rel="stylesheet" />` to your **index.html** or **_Host.cshtml** or **App.razor** *(in .NET8)*

4- Add `@using Blazor.PersianDatePicker` to **_imports.razor**

5- Use the component **InputPersianDatePicker** 

## Options:

```csharp
<InputPersianDatePicker 
       // Html input element id attribute 
       Id="myInputDatePicker" //Optional

       // Bind input value to local variable or dto etc
       @bind-Value="_myComponentField"

       // Html input element name attribute
       Name="myInputName" //Optional

       // Control visibility of input
       Visible="true" //Default: true

       // Disabled make input disabled. This means only showing value and the picker popup won't open
       Disabled="false" //Default: false

       // Readonly make input readonly. This means the user cannot change the picker value e.g. by typing
       ReadOnly="true" //Default: true

       // Picker'align relative to input
       // Options: Align.Right | Align.Left
       PickerAlign="Align.Right" //Default: Align.Right

       // Show calendar icon on text input
       ShowCalendarIcon="true" //Default: true

       // Calendar icon position relative to input
       // Options: IconPosition.BasedOnAlign | IconPosition.Left | IconPosition.Right
       CalendarIconPosition="IconPosition.BasedOnAlign" //Default: IconPosition.BasedOnAlign

       // Can be used in changing the vertical position of the picker popup relative to the input
       PickerOffsetTopPositionInPixels="2" //Default: 2

       // Initial value for the input set today
       InitialValueSetOnToday="false" //Default: false

       // Calendar type for date picker including Dual, Single, etc
       // Options: Calendar.DualModeJalaliDefault | Calendar.DualModeMiladiDefault | Calendar.SingleModeJalali | Calendar.SingleModeMiladi
       CalendarType="Calendar.DualModeJalaliDefault" //Default: Calendar.DualModeJalaliDefault

       // Control the digit type showing in the input after selecting by the picker
       // Options: DigitType.BasedOnCalendar | DigitType.Persian | DigitType.English
       DigitType="DigitType.BasedOnCalendar" //Default: DigitType.BasedOnCalendar

       // Format of date to show in the input after selecting by picker, e.g. 1400/01/01 or 1400-01-01
       // Options: DateFormat.yyyy_slash_MM_slash_dd | DateFormat.yyyy_dash_MM_dash_dd
       DateFormat="DateFormat.yyyy_slash_MM_slash_dd" //Default: DateFormat.yyyy_slash_MM_slash_dd

       // Prevent the user from selecting a date before today
       MinDateSetOnToday="true" //Default: true

       // Input placeholder
       Placeholder="Select date"

       // CSS class for input element
       CssClass="form-control"

       // Inline styles for input element
       Style="border:1px solid red; width:50%"

       // Choose a theme for changing the look and feel of the picker
       // Options: PickerTheme.Default | PickerTheme.Dark | PickerTheme.Blue | PickerTheme.Cheerup | PickerTheme.RedBlack
       // Themes can be seen in the image
       Theme="PickerTheme.Default"

       // Mark holidays red color in Persian calendar
       MarkHolidays="true" //Default: true

       // Mark red color for the dates provided here in the calendar
       // Both "/" seperated and "-" seperated Jalali date formats are valid
       MarkedDates="@(["1403-06-25", "1403/06/27", "1403/06/28"])" //Optional

       // Input change event
       OnChange="@(() => Console.WriteLine("OK"))"
                        
       // Input text clear event (by pressing close button)
       OnClear="@(() => Console.WriteLine("Cleared"))" />

```

> #### 💡 You can add multi-instances of InputPersianDatePicker components on a page and all of them work independently without any problem

## Sample template for fast usage:
#### Copy from here then paste in your project; change some options and you're done.

```razor
<InputPersianDatePicker Id="myInputDatePicker"
                        @bind-Value="_variable4"
                        Name="myInputName"
                        Visible="true"
                        Disabled="false"
                        PickerAlign="Align.Right"
                        PickerOffsetTopPositionInPixels="1"
                        InitialValueSetOnToday="false"
                        CalendarType="Calendar.SingleModeJalali"
                        DigitType="DigitType.BasedOnCalendar"
                        DateFormat="DateFormat.yyyy_slash_MM_slash_dd"
                        MinDateSetOnToday="true"
                        Placeholder="Select date"
                        CssClass="form-control"
                        Style="border:1px solid green; width:20%; float:right"
                        Theme="PickerTheme.RedBlack"
                        MarkHolidays="true"
                        MarkedDates="@(["1403-06-25", "1403/06/27", "1403/06/28"])"
                        OnChange="@(() => Console.WriteLine("OK"))" />
```

## Performance:

   * `js` size (gzipped) ⇒ **35 kb** 

   * `css` size (gzipped) ⇒ **5 kb** 

   * `dll` size (gzipped) ⇒‌ **9 kb** 


## Special Thanks:
  *This project is ported from [pwt.datepicker](https://github.com/babakhani/pwt.datepicker) project with a lot of customizations and optimizations for easy and fast use for Blazor applications. Therefore, I appreciate the great effort of Reza Babakhani @babakhani and all contributors of that project*

