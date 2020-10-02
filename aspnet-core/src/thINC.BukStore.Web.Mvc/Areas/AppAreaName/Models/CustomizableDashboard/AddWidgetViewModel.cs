using System.Collections.Generic;
using thINC.BukStore.DashboardCustomization.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
