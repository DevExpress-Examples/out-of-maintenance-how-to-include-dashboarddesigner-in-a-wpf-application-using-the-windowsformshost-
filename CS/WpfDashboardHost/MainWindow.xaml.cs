using System.Windows;

namespace WpfDashboardHost
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            System.Windows.Forms.UserControl userControl1 = new System.Windows.Forms.UserControl();
            DevExpress.DashboardWin.DashboardDesigner dashboardDesigner1 = new DevExpress.DashboardWin.DashboardDesigner();
            userControl1.Controls.Add(dashboardDesigner1);
            dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill ;
            dashboardDesigner1.CreateRibbon();
            dashboardHost.Child = userControl1;
        }
    }
}
