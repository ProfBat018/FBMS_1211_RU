using System.Net;
using System.Net.Sockets;
using System.Text;

var senderPort = 12001;
var address = IPAddress.Parse("224.0.0.1");


Receive();

void Receive()
{
    var receiver = new UdpClient(senderPort);

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