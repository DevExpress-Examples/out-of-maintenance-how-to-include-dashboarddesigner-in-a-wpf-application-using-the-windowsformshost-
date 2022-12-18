<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581169/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T408053)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfDashboardHost/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfDashboardHost/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfDashboardHost/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfDashboardHost/MainWindow.xaml.vb))
<!-- default file list end -->
# How to Use the WinForms DashboardDesigner Control in WPF application

The [WPF Dashboard Control](https://docs.devexpress.com/Dashboard/119813) control is designed to display dashboards in a WPF application. We suggest that new dashboards are designed with Winforms or ASP.NET dashboard designer controls.

There is a workaround that uses the [WindowsFormsHost](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.integration.windowsformshost) element designed to display any WinForms control inside a WPF application. 

In this example, the WindowsFormsHost element contains the [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) control to enable you create and edit a dashboard.

![screenshot](/images/screenshot.png)
