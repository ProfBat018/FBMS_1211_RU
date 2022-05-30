namespace Proxy;


interface IRequest
{
    public void Request();
}

class Music : IRequest
{
    private bool state;

    public bool State
    {
        get => state; 
        set
        {
            state = value;
            if (state == false)
            {
                Console.WriteLine("Disconnected");
            }
            else
            {
                Console.WriteLine("Connected");
            }
        }
    }


    public void Request()
    {
        State = true;
        Console.WriteLine("Connected");
    }
}


class MusicProxy : IRequest
{
    private Music _music;
    public DateTime RequestTime { get; set; }

    public MusicProxy(Music music)
    {
        RequestTime = DateTime.Now;
        _music = music;
    }

    public void Request()
    {
        if (DateTime.Now > RequestTime.AddSeconds(5))
        {
            _music.State = false;
        }
        else
        {
            _music.State = true;
        }
    }
}

class Program
{
    public static void Main()
    {
        MusicProxy musicProxy = new(new Music());
        
        musicProxy.Request();

        Thread.Sleep(6000);
        
        musicProxy.Request();

    }
}
