using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using thINC.BukStore.MultiTenancy.Accounting.Dto;

namespace thINC.BukStore.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
