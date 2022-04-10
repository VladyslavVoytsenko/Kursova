using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
namespace testKursova
{
    public class AddImage
    {
        

        public void OpenImage(Image tmpImg, OpenFileDialog tmpDialog )
        {
            tmpDialog.Filter = "images|*.png;*.jpg;*.jpeg;*.gif";
            tmpDialog.ShowDialog();
            
            var filePath = new Uri(tmpDialog.FileName);
            
            if (tmpImg.Source == null)
            {
                tmpImg.Source = new BitmapImage(filePath);
            }
        }
    }
}