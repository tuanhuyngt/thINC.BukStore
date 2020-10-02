using System.Threading.Tasks;
using thINC.BukStore.Views;
using Xamarin.Forms;

namespace thINC.BukStore.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
