Imports System.Windows

Namespace WpfDashboardHost
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()

			Dim userControl1 As New System.Windows.Forms.UserControl()
			Dim dashboardDesigner1 As New DevExpress.DashboardWin.DashboardDesigner()
			userControl1.Controls.Add(dashboardDesigner1)
			dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
			dashboardDesigner1.CreateRibbon()
			dashboardHost.Child = userControl1
		End Sub
	End Class
End Namespace
