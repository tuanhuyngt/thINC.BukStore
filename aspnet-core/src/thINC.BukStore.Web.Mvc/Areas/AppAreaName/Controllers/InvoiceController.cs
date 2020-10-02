using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using thINC.BukStore.MultiTenancy.Accounting;
using thINC.BukStore.Web.Areas.AppAreaName.Models.Accounting;
using thINC.BukStore.Web.Controllers;

namespace thINC.BukStore.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    public class InvoiceController : BukStoreControllerBase
    {
        private readonly IInvoiceAppService _invoiceAppService;

        public InvoiceController(IInvoiceAppService invoiceAppService)
        {
            _invoiceAppService = invoiceAppService;
        }


        [HttpGet]
        public async Task<ActionResult> Index(long paymentId)
        {
            var invoice = await _invoiceAppService.GetInvoiceInfo(new EntityDto<long>(paymentId));
            var model = new InvoiceViewModel
            {
                Invoice = invoice
            };

            return View(model);
        }
    }
}