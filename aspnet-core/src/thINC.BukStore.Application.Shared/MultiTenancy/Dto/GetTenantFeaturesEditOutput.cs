using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Editions.Dto;

namespace thINC.BukStore.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}