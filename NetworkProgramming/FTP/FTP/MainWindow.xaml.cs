using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
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
using Microsoft.Win32;

namespace FTP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public FtpWebRequest FtpWebRequest { get; set; }
        public FtpWebResponse FtpWebResponse { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Load()
        {
            FtpWebRequest = WebRequest.Create("ftp://127.0.0.1/") as FtpWebRequest;
            FtpWebRequest.EnableSsl = true;

            FtpWebRequest.Credentials = new NetworkCredential("Wayne", "1018");

            FtpWebRequest.Method = WebRequestMethods.Ftp.ListDirectory;

            ServicePointManager.ServerCertificateValidationCallback =
                (s, certificate, chain, sslPolicyErrors) => true;

            FtpWebResponse = FtpWebRequest.GetResponse() as FtpWebResponse;

            using Stream responseStream = FtpWebResponse.GetResponseStream();


            byte[] buffer = new byte[1024];
            int size = 0;

            responseStream.Read(buffer);

            var result = Encoding.ASCII.GetString(buffer);

            var files = result.Split('\n');

            foreach (var file in files)
            {
                ContentBox.Items.Add(file);
            }

        }

        private void Download_OnClick(object sender, RoutedEventArgs e)
        {
            var Selected = ContentBox.SelectedItem.ToString();

            FtpWebRequest = WebRequest.Create($"ftp://127.0.0.1/{Selected}") as FtpWebRequest;
            FtpWebRequest.EnableSsl = true;

            FtpWebRequest.Credentials = new NetworkCredential("Wayne", "1018");
            
            FtpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            ServicePointManager.ServerCertificateValidationCallback =
                (s, certificate, chain, sslPolicyErrors) => true;

            FtpWebResponse = FtpWebRequest.GetResponse() as FtpWebResponse;
            
            using Stream responseStream = FtpWebResponse.GetResponseStream();

            byte[] buffer = new byte[1024];
            int size = 0;

            responseStream.Read(buffer);

            MessageBox.Show(Encoding.ASCII.GetString(buffer));
        }

        private void Upload_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\Wayne\Desktop";
            dialog.ShowDialog();

            FtpWebRequest = WebRequest.Create($"ftp://127.0.0.1/{dialog.SafeFileName}") as FtpWebRequest;
            FtpWebRequest.EnableSsl = true;
            
            FtpWebRequest.Credentials = new NetworkCredential("Wayne", "1018");
            
            FtpWebRequest.Method = WebRequestMethods.Ftp.UploadFile;
            
            ServicePointManager.ServerCertificateValidationCallback =
                (s, certificate, chain, sslPolicyErrors) => true;

            using Stream fs = File.OpenRead(dialog.FileName);
            using Stream ftpStream = FtpWebRequest.GetRequestStream();
            
            fs.CopyTo(ftpStream);

            ContentBox.Items.Clear();
            Load();
        }

        private void Delete_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
