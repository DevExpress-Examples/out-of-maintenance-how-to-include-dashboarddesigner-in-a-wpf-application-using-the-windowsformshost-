<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfDashboardWFH/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfDashboardWFH/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfDashboardWFH/MainWindow.xaml.cs) (VB: [MainWindow.xaml](./VB/WpfDashboardWFH/MainWindow.xaml))
<!-- default file list end -->
# How to include DashboardDesigner in a WPF application using the WindowsFormsHost control

The Dashboard Suite provides the [WPF Dashboard Viewer](https://docs.devexpress.com/Dashboard/119813/building-the-designer-and-viewer-applications/wpf-viewer) control to to display dashboards in a WPF application. 

Prior to WPF Dashboard Viewer development, we suggested a workaround which uses the <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.integration.windowsformshost.aspx">WindowsFormsHost</a> element designed to display any Windows Forms control inside a WPF application. In this example the WindowsFormsHost element contains the [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) control which enables you to create and edit a dashboard.

