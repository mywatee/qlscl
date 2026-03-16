using System.Windows;
using System.Windows.Controls;
using QLSANCL.BadmintonManagement.Views;

namespace QLSANCL.BadmintonManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new DashboardView());
        }

        private void NavigationButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton button && MainFrame != null)
            {
                string tag = button.Tag.ToString();
                
                switch (tag)
                {
                    case "Dashboard":
                        MainFrame.Navigate(new DashboardView());
                        break;
                    case "Booking":
                        MainFrame.Navigate(new BookingView());
                        break;
                    case "Services":
                        MainFrame.Navigate(new ServicesView());
                        break;
                    case "Customers":
                        MainFrame.Navigate(new CustomersView());
                        break;
                    case "Staff":
                        MainFrame.Navigate(new StaffView());
                        break;
                    case "Reports":
                        MainFrame.Navigate(new ReportsView());
                        break;
                }
            }
        }
    }
}
