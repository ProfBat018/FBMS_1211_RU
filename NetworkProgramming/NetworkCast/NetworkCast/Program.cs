using System.Net;
using System.Net.Sockets;
using System.Text;



Console.WriteLine("Server Started...");

var address = IPAddress.Parse("224.0.0.1");

var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.MulticastTimeToLive, 5);

socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.AddMembership, new MulticastOption(address));

var endpoint = new IPEndPoint(address, 12001);

socket.Connect(endpoint);

while (true)
{
    socket.Send(Encoding.ASCII.GetBytes(Console.ReadLine()));
}