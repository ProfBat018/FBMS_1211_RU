using System.Formats.Asn1;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.Text;
using System.Text.Json;
using System.Xml.Serialization;

namespace Files;

public class Questions
{
    public string Question { get; set; }
    public string Answer { get; set; }
}
internal static class Program
{
    public static void Main()
    {
        #region Part1

        // FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);
        //
        // string? text = "Elvin Azimov";
        //
        // byte[] buffer = Encoding.UTF8.GetBytes(text);
        //
        // foreach (var @byte in buffer)
        // {
        //     fs.WriteByte(@byte);
        // }
        // fs.Close();

        #endregion

        #region Part2

        // using var fs = new FileStream("data.txt", FileMode.OpenOrCreate);
        // const string text = "Elvin Azimov";
        //
        // byte[] buffer = Encoding.UTF8.GetBytes(text);
        //
        // foreach (var @byte in buffer)
        // {
        //     fs.WriteByte(@byte);
        // }

        #endregion

        #region Part3

        // using var fs = new FileStream("data.txt", FileMode.OpenOrCreate);
        //
        // StringBuilder text = new StringBuilder();
        //
        //
        // for (int i = 0; i < fs.Length; i++)
        // {
        //     text.Append((char)fs.ReadByte());
        // }
        //
        // Console.WriteLine(text);

        #endregion

        #region Part4

        // using FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);
        // using StreamReader sr = new StreamReader(fs);
        //
        // string? text = sr.ReadLine();
        //
        // Console.WriteLine(text);

        #endregion

        #region Part5

        // using FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);
        // using StreamWriter sw = new StreamWriter(fs);
        //
        // sw.WriteLine("Hello World");

        #endregion

        #region Part6
        using FileStream fs = new FileStream(@"Elvin.json", FileMode.Open);

        Questions question1 = new Questions() { Question = "Test", Answer = "Test" };
        Questions question2 = new Questions() { Question = "Test", Answer = "Test" };
        Questions question3 = new Questions() { Question = "Test", Answer = "Test" };

        List<Questions> questionsList = new List<Questions>() { question1, question2, question3 };
        
        
        JsonSerializer.Serialize(fs, questionsList);

        #endregion
    }
}