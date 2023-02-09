using System.Net;
using System.Net.Mail;

namespace MailBox
{
    public partial class Form1 : Form
    {
        public MailMessage MailMessage { get; set; }
        public string path { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void attachButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.InitialDirectory = @"C:\Users\Wayne\Pictures";

            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = openFileDialog.FileName;
            }

            pictureBox1.Image = new Bitmap(new FileStream(path, FileMode.Open));
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            var from = fromTextBox.Text;
            var to = toTextBox.Text;
            var message = dataRichTextBox.Text;



            MailAddress fromAddress = new(from);
            MailAddress toAddress = new(to);

            MailMessage = new(from, to);
            MailMessage.Attachments.Add(new Attachment(path));

            MailMessage.Body = message;
            SmtpClient client = new("smtp.gmail.com", 587);

            client.Credentials = new NetworkCredential("elvin.azim01@gmail.com", "pvswgbrkuqlszant");
            client.EnableSsl = true;

            await client.SendMailAsync(MailMessage);

            // pvswgbrkuqlszant

        }
    }
}