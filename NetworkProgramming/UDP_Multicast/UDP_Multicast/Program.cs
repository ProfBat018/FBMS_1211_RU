using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;

var senderPort = 12001;
var receiverPort = 12001;
var address = IPAddress.Parse("224.0.0.1");

using var stream = new MemoryStream();



Console.Write("Enter your username: ");
var username = Console.ReadLine();

var thread = new Thread(Receive);
thread.Start();

try
{
    while (true)
    {
        Console.Write("Enter your message: ");
        var message = Console.ReadLine();
        message = $"{username}:\t{message}";

        Send(message);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}


void Send(string message)
{
    var sender = new UdpClient();

    try
    {
        var endpoint = new IPEndPoint(address, senderPort);

        var data = Encoding.ASCII.GetBytes(message);
        sender.Send(data, data.Length, endpoint);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    finally
    {
        sender.Close();
    }
}

void Receive()
{
    var receiver = new UdpClient(receiverPort);

    try
    {
        receiver.JoinMulticastGroup(address, 20);

        IPEndPoint receiverEP = null;

        while (true)
        {
            var result = receiver.Receive(ref receiverEP);
            var receivedData = Encoding.ASCII.GetString(result);
            Console.WriteLine(receivedData);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
    finally
    {
        receiver.Close();
    }
}
