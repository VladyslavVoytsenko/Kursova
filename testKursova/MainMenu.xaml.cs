using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace testKursova
{
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Reset_Control_OnClick(object sender, RoutedEventArgs e)
        {
            Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void App_ShutDown_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null) Application.Current.MainWindow.Close();
        }

        private void App_Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null && Application.Current.MainWindow.WindowState == WindowState.Normal)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;

                // Top, Bottom Border Collapsed
                if (Application.Current.MainWindow is MainWindow mw)
                {
                    mw.Window_Edge.Visibility = Visibility.Collapsed;
                }
            }
            else
            {
                if (Application.Current.MainWindow == null) return;
                Application.Current.MainWindow.WindowState = WindowState.Normal;

                // Top, Bottom Border Visible
                if (Application.Current.MainWindow is MainWindow mw1)
                {
                    mw1.Window_Edge.Visibility = Visibility.Visible;
                }
            }

        }

        private void App_Minimize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow != null)
                Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void MenuStatus_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MenuToggleButton.IsChecked = true;
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            MenuToggleButton.IsChecked = false;
        }
    }
}