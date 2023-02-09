using MoviesMVC.Converters;
using System.Text.Json.Serialization;

namespace MoviesMVC.Models
{
    public class MoviesViewModel
    {
        public Search[]? Search { get; set; }

        [JsonPropertyName("totalResults")]
        [JsonConverter(typeof(StringToIntConverter))]
        public int? TotalResults { get; set; }

        public string? Response { get; set; }

        [JsonIgnore]
        public int CurrentPage { get; set; } = 1;

        [JsonIgnore] 
        public string? Request { get; set; }

    }

    
    public class Search
    {
        public string? Title { get; set; }
        public string? Year { get; set; }

        [JsonPropertyName("imdbID")]
        public string? ImdbID { get; set; }
        public string? Type { get; set; }
        public string? Poster { get; set; }
    }

}
