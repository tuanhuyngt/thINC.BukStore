using System.Globalization;

namespace thINC.BukStore.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}