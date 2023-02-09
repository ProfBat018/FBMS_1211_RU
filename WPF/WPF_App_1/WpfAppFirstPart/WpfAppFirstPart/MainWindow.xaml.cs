using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppFirstPart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var imageDialog = new OpenFileDialog();
            imageDialog.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            imageDialog.FilterIndex = 1;
            imageDialog.InitialDirectory = @"C:\Users\elvin\Pictures";
            var result = imageDialog.ShowDialog();

            if (result.Value)
            {
                var image_path = imageDialog.FileName;
                MessageBox.Show(image_path);
            }
        }
    }
}