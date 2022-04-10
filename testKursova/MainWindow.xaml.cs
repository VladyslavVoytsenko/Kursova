using System.Windows;
using System.Windows.Input;

namespace testKursova
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                DragMove();
            }
        }

        private void ChangeWindowState()
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                Window_Edge.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (WindowState != WindowState.Maximized) return;
                WindowState = WindowState.Normal;
                Window_Edge.Visibility = Visibility.Visible;
            }
            
        }


        private void Main_Window_Panel_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left && e.ClickCount == 2)
            {
                ChangeWindowState();
            }
        }
    }
}