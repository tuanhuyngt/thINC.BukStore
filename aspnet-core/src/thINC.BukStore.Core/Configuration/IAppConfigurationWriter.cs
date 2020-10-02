namespace thINC.BukStore.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}
