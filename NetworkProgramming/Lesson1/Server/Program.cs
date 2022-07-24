using System.Net;
using System.Net.Sockets;
using System.Text;

IPAddress address = IPAddress.Parse("10.1.10.13");
IPEndPoint endPoint = new IPEndPoint(address, 49714);
Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

try
{
    socket.Bind(endPoint);
    socket.Listen(5);

    string? data;
    
    Console.WriteLine("Waiting...");
    Socket handler = socket.Accept();

    while (true)
    {
        byte[] buffer = new byte[1024];
        var res = handler.Receive(buffer);
        data = Encoding.UTF8.GetString(buffer);
        Console.WriteLine(data);

        if (data.Contains("Exit"))
        {
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();
            break;
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
