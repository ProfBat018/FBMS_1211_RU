namespace MoviesMVC.Services.Inrerfaces
{
    public interface IDataDownloaderService
    {
        public Task<string>? DownloadAsync(string? search, string? apiKey, int page = 1);
    }
}
