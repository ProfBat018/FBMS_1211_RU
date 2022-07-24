using System.Net;
using System.Net.Sockets;
using System.Text;

IPAddress? address = IPAddress.Any;
var host = Dns.GetHostEntry(Dns.GetHostName());
var addressList = host.AddressList;

foreach (var ip in addressList)
{
    if (ip.AddressFamily == AddressFamily.InterNetwork)
    {
        address = ip;
    }
}


IPEndPoint endPoint = new IPEndPoint(address, 12001);
Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


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
