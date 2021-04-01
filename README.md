# Blazor Jalali DatePicker

<img src="https://github.com/fericode/blazor-jalali-datepicker/blob/main/screenshot.png">

## Usage:

1- Install **BlazorJalaliDatePicker** from Nuget

2- Add `<script src="_content/BlazorJalaliDatePicker/jalali-datepicker.min.js" type="text/javascript"></script>` to your **index.html** or **_Host.cshtml**

3- Add `<link href="_content/BlazorJalaliDatePicker/jalali-datepicker.css" rel="stylesheet" />` to your **index.html** or **_Host.cshtml**

4- Add `@using BlazorJalaliDatePicker` to **_imports.razor**

5- Use the component :)


```
<JalaliDatePicker Id="Id1"
                  Name="Name1"
                  CalendarType="Calendar.Jalali"
                  @bind-Value="@_value1"
                  OnChange=@(args => OnChange(args)) />

```

## Performance:

   * **js size: 33 KB** => gzipped (IIS server uses compressed gzip files out of the box (as default) for Blazor Web Assembly Hosted applications. For Blazor Standalone app, though, some manual steps is required)

   * **css size: 3 KB** => gzipped

   * **dll size: 14 KB**
