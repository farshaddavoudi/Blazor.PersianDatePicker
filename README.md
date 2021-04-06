# PersianDatePicker

<img src="https://github.com/fericode/Blazor.PersianDatePicker/blob/master/screenshot.png">

## Usage:

1- Install **Blazor.PersianDatePicker** from Nuget

2- Add `<script src="_content/Blazor.PersianDatePicker/datepicker.min.js" type="text/javascript"></script>` to your **index.html** or **_Host.cshtml**

3- Add `<link href="_content/Blazor.PersianDatePicker/datepicker.css" rel="stylesheet" />` to your **index.html** or **_Host.cshtml**

4- Add `@using Blazor.PersianDatePicker` to **_imports.razor**

5- Use the component **InputPersianDatePicker** 

## Options:

```
<InputPersianDatePicker 
                        // Html input element id attribute 
                        Id="myInputDatePicker" //Required 

                        // Bind input value to local variable or dto etc
                        @bind-Value="_myComponentField"

                        // Html input element name attribute
                        Name="myInputName" //Optional

                        // Control visibility of input
                        Visible="true" //Default: true

                        // Disabled make input disabled. Meaning only showing value and picker popup won't open
                        Disabled="false" //Default: false

                        // Picker align relative to input
                        // Options: Align.Right | Align.Left
                        PickerAlign="Align.Right" //Default: Align.Right

                        // Show calendar icon on text input
                        ShowCalendarIcon="true" //Default: true

                        // Calendar icon position relative to input
                        // Options: IconPosition.BasedOnAlign | IconPosition.Left | IconPosition.Right
                        CalendarIconPosition="IconPosition.BasedOnAlign" //Default: IconPosition.BasedOnAlign

                        // Can be used in changing vertical position of picker popup relative to input
                        PickerOffsetTopPositionInPixels="2" //Default: 2

                        // Initial value for input set on today
                        InitialValue="false" //Default: false

                        // Calendar type for date picker including Dual, Single, etc
                        // Options: Calendar.DualModeJalaliDefault | Calendar.DualModeMiladiDefault | Calendar.SingleModeJalali | Calendar.SingleModeMiladi
                        CalendarType="Calendar.DualModeJalaliDefault" //Default: Calendar.DualModeJalaliDefault

                        // Control the digit type showing in input after selecting by picker
                        // Options: DigitType.BasedOnCalendar | DigitType.Persian | DigitType.English
                        DigitType="DigitType.BasedOnCalendar" //Default: DigitType.BasedOnCalendar

                        // Format of date to show in input after selecting by picker, e.g. 1400/01/01 or 1400-01-01
                        // Options: DateFormat.yyyy_slash_MM_slash_dd | DateFormat.yyyy_dash_MM_dash_dd
                        DateFormat="DateFormat.yyyy_slash_MM_slash_dd" //Default: DateFormat.yyyy_slash_MM_slash_dd

                        // Prevent user select date before today
                        MinDateSetOnToday="true" //Default: true

                        // Input placeholder
                        Placeholder="Select date"

                        // CSS class for input element
                        CssClass="form-control"

                        // Inline styles for input element
                        Style="border:1px solid red; width:50%"

                        // Choose a theme for changing look and feel of picker
                        // Options: PickerTheme.Default | PickerTheme.Dark | PickerTheme.Blue | PickerTheme.Cheerup | PickerTheme.RedBlack
                        // Themes can be seen in the image
                        Theme="PickerTheme.Default"

                        // Input onchange event
                        OnChange="@(() => Console.WriteLine("OK"))" />

```

## Performance:

   * **js size: 35 KB** => gzipped 

   * **css size: 5 KB** => gzipped 

   * **dll size: 9 KB** =>‌ gzipped 

   – IIS server uses compressed gzip files out of the box (as default) for Blazor Web Assembly Hosted applications. For Blazor Standalone app, though, some manual steps is required. [More info](https://docs.microsoft.com/en-us/aspnet/core/blazor/host-and-deploy/webassembly?view=aspnetcore-5.0#compression)


## Special Thanks:
  *This project is ported from [pwt.datepicker](https://github.com/babakhani/pwt.datepicker) project with a lot of customizations and optimizations for easy and fast use for Blazor applications. Therefore, I appreciate the great effort of Reza Babakhani @babakhani and all contributors of that project*

## Contribute:
* Please pull-request for changes you want.

