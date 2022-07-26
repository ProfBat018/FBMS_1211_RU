using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;

// Server

TcpListener listener = new(IPAddress.Parse("127.0.0.1"), 12001);

listener.Start(); // Start server 

while (true)
{

    var client = await listener.AcceptTcpClientAsync(); // Accept all clients 

    var clientStream = client.GetStream();

    if (client.ReceiveBufferSize > 0)
    {
        var buffer = new byte[client.ReceiveBufferSize];
        var readAsync = await clientStream.ReadAsync(buffer, 0, client.ReceiveBufferSize);

        var clientName = Encoding.ASCII.GetString(buffer);
        Console.WriteLine($"Client Name: {clientName}\t{client.Connected}");
           
        await clientStream.WriteAsync(Encoding.ASCII.GetBytes(Console.ReadLine() ?? string.Empty));
    }
}
