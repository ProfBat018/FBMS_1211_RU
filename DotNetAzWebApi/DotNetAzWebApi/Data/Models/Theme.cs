namespace DotNetAzWebApi.Data.Models;

public class Theme
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public int ChapterID { get; set; }
    public Chapter Chapter { get; set; }
}