using System.Threading.Tasks;
using Abp.Dependency;

namespace thINC.BukStore.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}