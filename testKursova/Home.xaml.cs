using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace testKursova
{
    public partial class Home : UserControl
    {
        private AddImage _addImage = new AddImage();
        public Home()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            _addImage.OpenImage(ImageEditor, fileDialog);
        }
    }
}