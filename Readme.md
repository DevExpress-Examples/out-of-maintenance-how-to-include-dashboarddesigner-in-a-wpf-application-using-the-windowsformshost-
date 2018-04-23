# How to include DashboardDesigner in a WPF application using the WindowsFormsHost control


<p>The Dashboard Suite does not provide WPF controls. The only way to display dashboards in a WPF application is to use the standard <a href="http://msdn.microsoft.com/en-us/library/system.windows.forms.integration.windowsformshost.aspx">WindowsFormsHost</a> element, which allows displaying any Windows Forms control inside a WPF application. <br>In this case, you can generate a Ribbon Bar, which is used to configure dashboards using the <a href="https://documentation.devexpress.com/Dashboard/clsDevExpressDashboardWinDashboardDesignertopic.aspx">DashboardDesigner</a> control by executing the <a href="https://documentation.devexpress.com/Dashboard/DevExpressDashboardWinDashboardDesigner_CreateRibbontopic.aspx">CreateRibbon</a> method. Note that while Ribbon mostly works correctly, there can be some issues with certain features caused by the platforms difference: e.g. <a href="https://www.devexpress.com/Support/Center/p/Q344849">Ribbon in RibbonForm not responding to keyboard shortcuts</a>.</p>

<br/>


