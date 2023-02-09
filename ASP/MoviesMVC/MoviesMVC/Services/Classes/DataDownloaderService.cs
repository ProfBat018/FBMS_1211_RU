using MoviesMVC.Services.Inrerfaces;

namespace MoviesMVC.Services.Classes
{
    public class DataDownloaderService : IDataDownloaderService
    {
        private HttpClient _httpClient = new();

        public async Task<string?>? DownloadAsync(string? search, string? apiKey, int page)
        {
            string url = $"https://www.omdbapi.com/?apikey={apiKey!}&s={search!}&page={page}";
            return await _httpClient.GetStringAsync(url);
        }
    }
}
