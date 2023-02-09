using System.Net.Sockets;
using System.Text;


// Client



TcpClient client = new();

Console.Write("Enter your username: ");
var username = Console.ReadLine();

if (username != null)
{
    var buffer = Encoding.ASCII.GetBytes(username);

    await client.ConnectAsync("127.0.0.1", 12001);

    var clientStream = client.GetStream();

    await clientStream.WriteAsync(buffer, 0, username.Length);
    Console.WriteLine($"Client connected: {client.Connected}");

    while (true)
    {
        if (clientStream.DataAvailable)
        {
            buffer = new byte[client.ReceiveBufferSize];

            var readAsync = await clientStream.ReadAsync(buffer, 0, client.ReceiveBufferSize);

            var clientName = Encoding.ASCII.GetString(buffer);
            Console.WriteLine($"Received from Server: {clientName}\t{client.Connected}");
        }
    }
}
