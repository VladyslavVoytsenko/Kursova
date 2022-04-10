using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using testKursova.Pages;
using System.Windows.Controls.Primitives;
namespace testKursova
{
    
    public partial class SideBar : UserControl
    {
        private readonly Home _dfpdl = new Home();
        public SideBar()
        {
            InitializeComponent();
        }
        //private MainWindow _mainWindow = new MainWindow();
        private void SideBar_Dashboard_ListBoxItem_OnSelected(object sender, RoutedEventArgs e)
        {
           //_mainWindow.PagesNavigation.Navigate(new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }
        

        private void SideBarDashboardListBoxItem_OnMouseLeave(object sender, MouseEventArgs e)
        {
            PopupUc.Visibility = Visibility.Collapsed;
            PopupUc.IsOpen = false;
        }

        private void SideBarMailListBoxItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            PopupUc.PlacementTarget = SideBarMailListBoxItem;
            PopupUc.Placement = PlacementMode.Right;
            PopupUc.IsOpen = true;
            Header.PopupText.Text = "Send";
        }

        private void SideBarCustomerListBoxItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            PopupUc.PlacementTarget = SideBarCustomerListBoxItem;
            PopupUc.Placement = PlacementMode.Right;
            PopupUc.IsOpen = true;
            Header.PopupText.Text = "Customer";
        }

        private void SideBarAnalyticsListBoxItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            PopupUc.PlacementTarget = SideBarAnalyticsListBoxItem;
            PopupUc.Placement = PlacementMode.Right;
            PopupUc.IsOpen = true;
            Header.PopupText.Text = "Print";
        }

        private void SideBarSettingsListBoxItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            PopupUc.PlacementTarget = SideBarSettingsListBoxItem;
            PopupUc.Placement = PlacementMode.Right;
            PopupUc.IsOpen = true;
            Header.PopupText.Text = "Settings";
        }

        private void SideBarDashboardListBoxItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            PopupUc.PlacementTarget = SideBarDashboardListBoxItem;
            PopupUc.Placement = PlacementMode.Right;
            PopupUc.IsOpen = true;
            Header.PopupText.Text = "Home";
        }
        
    }
}