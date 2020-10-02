using System.Threading.Tasks;
using thINC.BukStore.Common;
using thINC.BukStore.Test.Base;
using Shouldly;

namespace thINC.BukStore.Tests.CommonLookup
{
    // ReSharper disable once InconsistentNaming
    public class CommonLookupAppService_Tests : AppTestBase
    {
        private readonly ICommonLookupAppService _commonLookupAppService;

        public CommonLookupAppService_Tests()
        {
            LoginAsHostAdmin();

            _commonLookupAppService = Resolve<ICommonLookupAppService>();
        }

        [MultiTenantFact]
        public async Task Should_Get_Editions()
        {
            var paidEditions = await _commonLookupAppService.GetEditionsForCombobox();
            paidEditions.Items.Count.ShouldBe(7);

            var freeEditions = await _commonLookupAppService.GetEditionsForCombobox(true);
            freeEditions.Items.Count.ShouldBe(4);
        }
    }
}
