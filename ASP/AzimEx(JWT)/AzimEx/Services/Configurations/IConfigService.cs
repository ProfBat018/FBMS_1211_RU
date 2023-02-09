namespace AzimEx.Services.Configurations
{
    public interface IConfigService
    {
        public string? IConfigPath { get; set; }
        public IConfigurationRoot BuildConfiguration();
        public string? GetValue(string? key);
    }
}
