namespace MoviesMVC.Services.Inrerfaces
{
    public interface IDeserializationService
    {
        public Task<T?>? DeserializeAsync<T>(string json);
    }
}
