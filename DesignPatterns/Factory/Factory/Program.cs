using System.Collections.ObjectModel;

namespace Factory;


class Android
{
    public Button AndroidButton = new() { Color = ButtonCreator.CreateButton() };
}

class IOS
{
    public Button IOSButton = new() { Color = ButtonCreator.CreateButton() };
}


public static class ButtonCreator
{
    public static string CreateButton()
    {
        return "White";
    }
}

class Button
{
    public string Color { get; set; }
}


class Program
{
    public static void Main()
    {

    }
}