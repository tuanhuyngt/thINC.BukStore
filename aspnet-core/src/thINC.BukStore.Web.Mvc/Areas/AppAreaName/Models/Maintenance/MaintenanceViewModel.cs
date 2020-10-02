using System.Collections.Generic;
using thINC.BukStore.Caching.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}