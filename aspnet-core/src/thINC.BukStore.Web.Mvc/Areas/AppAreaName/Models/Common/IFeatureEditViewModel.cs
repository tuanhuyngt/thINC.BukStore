using System.Collections.Generic;
using Abp.Application.Services.Dto;
using thINC.BukStore.Editions.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}