using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
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
using System.Speech.Recognition;
using System.Printing;
using NAudio.Wave;

namespace VoiceRec
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputFilePath;
        
        public MainWindow()
        {
            InitializeComponent();

            waveIn = new WaveInEvent();
            waveIn.DataAvailable += WaveIn_DataAvailable;
            waveIn.RecordingStopped += WaveIn_RecordingStopped;
        }

     
        private async Task<Voice> GetVoiceAsync()
        {
            var url = @"https://eastus.stt.speech.microsoft.com/speech/recognition/conversation/cognitiveservices/v1?language=en-US&format=detailed";
            var subscriptionKey = "e8002308a52c4b06b80a65e446ba1237";

            using var client = new HttpClient();

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

            using FileStream fs = new("output.wav", FileMode.Open);
            var content = new StreamContent(fs);

            using var response = await client.PostAsync(url, content);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            var res = JsonSerializer.Deserialize<Voice>(responseBody);

            return res;
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            outputFilePath = "output.wav";
            waveIn.WaveFormat = new WaveFormat(44100, 1); // 44.1 kHz, mono
            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            waveIn.StartRecording();
            Start.IsEnabled = false;
            End.IsEnabled = true;    
        }

        private void End_Click(object sender, RoutedEventArgs e)
        {
            waveIn.StopRecording();
            Start.IsEnabled = true;
            End.IsEnabled = false;
        }


        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Write recorded audio to the output file
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        }

        private void WaveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            // Clean up resources
            waveIn.Dispose();
            writer.Dispose();
        }

        private async void Recongize_Click(object sender, RoutedEventArgs e)
        {
            var res = await GetVoiceAsync();
            var text = res.DisplayText;
            Text.Content = text;
        }
    }
}
