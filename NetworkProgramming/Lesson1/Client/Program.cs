using System.Net;
using System.Net.Sockets;
using System.Text;

IPAddress address = IPAddress.Parse("10.1.10.13");
IPEndPoint endPoint = new IPEndPoint(address, 49714);
Socket socket = new(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


try
{
    while (true)
    {
        Console.Write("Enter your message: ");
        var message = Console.ReadLine();
        socket.Send(Encoding.ASCII.GetBytes(message));
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    socket.Shutdown(SocketShutdown.Both);
    socket.Close();
}