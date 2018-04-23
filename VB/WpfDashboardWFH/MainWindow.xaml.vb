Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace WpfDashboardWFH
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim uc As New System.Windows.Forms.UserControl()
            Dim dd As New DevExpress.DashboardWin.DashboardDesigner()
            uc.Controls.Add(dd)
            dd.Dock = System.Windows.Forms.DockStyle.Fill
            dd.CreateRibbon()
            dashboardHost.Child = uc
        End Sub
    End Class
End Namespace
