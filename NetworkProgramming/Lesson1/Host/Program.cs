using System.Net;
using System.Net.NetworkInformation;

// ReSharper disable All

var ip = new MyIp(10, 1, 10, 17);
var localAddresses = new IPAddress[15];
Ping pingRequest = new Ping();
int count = 0;

for (int i = 0, j = 0; i < 50; i++, ip._ip4++)
{
    var tmpAddress = IPAddress.Parse(ip.ToString());
    Console.WriteLine($"Pinging: {tmpAddress}");

    PingReply pingReply = pingRequest.Send(tmpAddress, 1);
  
    if (pingReply.Status == IPStatus.Success)
    {
        Console.WriteLine($"Ping to: {tmpAddress} Succeeded");
        localAddresses[j] = tmpAddress;
        j++;
        count++;
    }
    else
    {
        Console.WriteLine($"Ping to: {tmpAddress} Failed");
    }
}

Console.Clear();


Console.WriteLine($"Address count: {count}");
foreach (var address in localAddresses)
{
    try
    {
        IPHostEntry hostEntry = Dns.GetHostEntry(address);
        Console.WriteLine($"Host: {hostEntry?.HostName}\tAddress: {address}");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Host: NONE\tAddress: {address}");
    }
}

struct MyIp
{
    public int _ip1;
    public int _ip2;
    public int _ip3;
    public int _ip4;
    public MyIp(int ip1, int ip2, int ip3, int ip4)
    {
        _ip1 = ip1;
        _ip2 = ip2;
        _ip3 = ip3;
        _ip4 = ip4;
    }

    public override string ToString()
    {
        return $"{_ip1}.{_ip2}.{_ip3}.{_ip4}";
    }
}