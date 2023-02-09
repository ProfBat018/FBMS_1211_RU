using System.Net;
using System.Net.Sockets;
using System.Text;

var address = IPAddress.Parse("224.0.0.1");

var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

var endpoint = new IPEndPoint(IPAddress.Any, 12001);

socket.Bind(endpoint);

socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(address, IPAddress.Any));

while (true)
{
    var buffer = new byte[1024];

    socket.Receive(buffer);
    IPHostEntry ipHostEntry = Dns.GetHostEntry(address);

    Console.WriteLine($"{ipHostEntry.HostName}:  {Encoding.ASCII.GetString(buffer)}");
}