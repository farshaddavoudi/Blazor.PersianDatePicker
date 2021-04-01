# PersianDatePicker

<img src="https://github.com/fericode/blazor-jalali-datepicker/blob/main/screenshot.png">

## Usage:

1- Install **Blazor.PersianDatePicker** from Nuget

2- Add `<script src="_content/Blazor.PersianDatePicker/datepicker.min.js" type="text/javascript"></script>` to your **index.html** or **_Host.cshtml**

3- Add `<link href="_content/Blazor.PersianDatePicker/datepicker.css" rel="stylesheet" />` to your **index.html** or **_Host.cshtml**

4- Add `@using Blazor.PersianDatePicker` to **_imports.razor**

5- Use the component :)


```
<InputPersianDatePicker 
                        // Html input element id attribute 
                        **Id="myInputDatePicker"** //Required 
                        @bind-Value="_myComponentPrivateField"
                        // Html input element name attribute
                        Name="myInputName" //Optional
                        Visible="true"
                        ReadOnly="false"
                        PickerAlign="Align.Left"
                        PickerOffsetTopPositionInPixels="2"
                        InitialValue="false"
                        CalendarType="Calendar.DualModeJalaliDefault"
                        DigitType="DigitType.BasedOnCalendar"
                        DateFormat="DateFormat.yyyy_slash_MM_slash_dd"
                        MinDateSetOnToday="true"
                        Placeholder="Select date"
                        CssClass="form-control"
                        Style="border:1px solid red; width:50%"
                        Theme="PickerTheme.Default"
                        OnChange="@(() => Console.WriteLine("OK"))" />

```

## Performance:

   * **js size: 33 KB** => gzipped (IIS server uses compressed gzip files out of the box (as default) for Blazor Web Assembly Hosted applications. For Blazor Standalone app, though, some manual steps is required)

   * **css size: 3 KB** => gzipped

   * **dll size: 14 KB**
