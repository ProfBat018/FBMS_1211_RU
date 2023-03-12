namespace DotNetAzWebApi.Data.Models;

public class Chapter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Theme> Themes { get; set; }
}